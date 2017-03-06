using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.IO.Compression;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace AutoGamePatcher
{
    [DataContract]
    public class PatchContainer
    {

        [DataMember]
        internal string executable = "";

        [DataMember]
        internal string gameFilesDirectory = "";

        [DataMember]
        internal string title = "";

        [DataMember]
        internal string description = "";

        [DataMember]
        internal string author = "";

        [DataMember]
        internal string version = "";

        [DataMember]
        internal string info = "";

        internal Image image = null;

        internal string archiveName = "";

        public string Executable
        {
            get
            {
                return executable;
            }
        }

        public string GameFilesDirectory
        {
            get
            {
                return gameFilesDirectory;
            }
        }

        public string Title
        {
            get
            {
                return title;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }
        }

        public string Author
        {
            get
            {
                return author;
            }
        }

        public string Version
        {
            get
            {
                return version;
            }
        }

        public string Info
        {
            get
            {
                return info;
            }
        }

        public Image Image
        {
            get
            {
                return image;
            }
        }

        internal PatchContainer()
        {
            //
        }

        public PatchContainer(string executable, string gameFilesDirectory, string title, string description, string author, string version, string info, string imageLink, string archiveName)
        {
            Init(executable, gameFilesDirectory, title, description, author, version, info, PatchIO.LoadImage(imageLink), archiveName);
        }

        public PatchContainer(string executable, string gameFilesDirectory, string title, string description, string author, string version, string info, Image image, string archiveName)
        {
            Init(executable, gameFilesDirectory, title, description, author, version, info, image, archiveName);
        }

        private void Init(string executable, string gameFilesDirectory, string title, string description, string author, string version, string info, Image image, string archiveName)
        {
            this.executable = executable;
            this.gameFilesDirectory = gameFilesDirectory;
            this.title = title;
            this.description = description;
            this.author = author;
            this.version = version;
            this.info = info;
            this.image = image;
            this.archiveName = archiveName;
        }

        public ZipArchive Open(ZipArchiveMode mode)
        {
            return ZipFile.Open(archiveName, mode);
        }

        private void ModifyEntries(ZipArchive zipArchive, IEnumerable<KeyValuePair<string, string>> files, IEnumerable<KeyValuePair<string, string>> directories, IEnumerable<string> deleteInternal = null, IEnumerable<KeyValuePair<string, string>> renameInternal = null)
        {
            if (deleteInternal != null)
            {
                foreach (string entry in deleteInternal)
                {
                    try
                    {
                        ZipArchiveEntry zae = zipArchive.GetEntry(entry);
                        if (zae != null)
                            zae.Delete();
                    }
                    catch (Exception ex)
                    {
                        Console.Error.WriteLine(ex.Message);
                    }
                }
            }
            if (renameInternal != null)
            {
                foreach (KeyValuePair<string, string> entry in renameInternal)
                {
                    try
                    {
                        ZipArchiveEntry zaeo = zipArchive.GetEntry(entry.Value);
                        if (zaeo != null)
                        {
                            ZipArchiveEntry zaen = zipArchive.CreateEntry(entry.Key);
                            if (zaen != null)
                            {
                                using (Stream so = zaeo.Open())
                                {
                                    using (Stream sn = zaen.Open())
                                        so.CopyTo(sn);
                                }
                            }
                            zaeo.Delete();
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.Error.WriteLine(ex.Message);
                    }
                }
            }
            foreach (KeyValuePair<string, string> file in files)
            {
                try
                {
                    zipArchive.CreateEntryFromFile(file.Value, file.Key, CompressionLevel.Fastest);
                }
                catch (Exception ex)
                {
                    Console.Error.WriteLine(ex.Message);
                }
            }
            foreach (KeyValuePair<string, string> directory in directories)
            {
                try
                {
                    string[] fs = Directory.GetFiles(directory.Value, "*", SearchOption.AllDirectories);
                    foreach (string file in fs)
                        zipArchive.CreateEntryFromFile(file, Core.ReplacePath(file, directory.Value, directory.Key), CompressionLevel.Fastest);
                }
                catch (Exception ex)
                {
                    Console.Error.WriteLine(ex.Message);
                }
            }
        }

        public void Create(IEnumerable<KeyValuePair<string, string>> files, IEnumerable<KeyValuePair<string, string>> directories)
        {
            if (File.Exists(archiveName))
                File.Delete(archiveName);
            using (ZipArchive za = Open(ZipArchiveMode.Create))
            {
                ZipArchiveEntry zaem = za.CreateEntry(PatchIO.META_FILE, CompressionLevel.Fastest);
                if (zaem != null)
                {
                    ModifyEntries(za, files, directories);
                    if (image != null)
                        za.CreateEntry(PatchIO.LOGO_FILE, CompressionLevel.Fastest);
                }
            }
            using (ZipArchive za = Open(ZipArchiveMode.Update))
            {
                ZipArchiveEntry zaem = za.GetEntry(PatchIO.META_FILE);
                using (Stream s = zaem.Open())
                {
                    DataContractJsonSerializer dcjs = new DataContractJsonSerializer(typeof(PatchContainer));
                    dcjs.WriteObject(s, this);
                }
                if (image != null)
                {
                    ZipArchiveEntry zael = za.GetEntry(PatchIO.LOGO_FILE);
                    if (zael != null)
                    {
                        using (Stream s = zael.Open())
                            image.Save(s, ImageFormat.Png);
                    }
                }
            }
        }

        public void Modify(IEnumerable<KeyValuePair<string, string>> files, IEnumerable<KeyValuePair<string, string>> directories, IEnumerable<string> deleteInternal, IEnumerable<KeyValuePair<string, string>> renameInternal)
        {
            using (ZipArchive za = Open(ZipArchiveMode.Update))
            {
                ModifyEntries(za, files, directories, deleteInternal, renameInternal);
            }
        }

        public int PatchAndRun()
        {
            int ret = -1;
            if (Directory.Exists(gameFilesDirectory))
            {
                List<string> delete_files = new List<string>();
                string an = PatchIO.CURRENT_DIRECTORY + Path.GetFileName(archiveName);
                try
                {
                    using (ZipArchive za = Open(ZipArchiveMode.Read))
                    {
                        using (ZipArchive zab = ZipFile.Open(an, ZipArchiveMode.Create))
                        {
                            foreach (ZipArchiveEntry zae in za.Entries)
                            {
                                if ((zae.FullName != PatchIO.LOGO_FILE) && (zae.FullName != PatchIO.META_FILE))
                                {
                                    string extract_file = Core.AddLastChar(gameFilesDirectory, '\\') + zae.FullName;
                                    if (File.Exists(extract_file))
                                    {
                                        zab.CreateEntryFromFile(extract_file, zae.FullName, CompressionLevel.Fastest);
                                        File.Delete(extract_file);
                                    }
                                    else
                                        delete_files.Add(extract_file);
                                    zae.ExtractToFile(extract_file);
                                }
                            }
                            zab.CreateEntry(PatchIO.META_FILE, CompressionLevel.Fastest);
                        }
                        using (ZipArchive zab = ZipFile.Open(an, ZipArchiveMode.Update))
                        {
                            ZipArchiveEntry zaem = zab.GetEntry(PatchIO.META_FILE);
                            using (Stream s = zaem.Open())
                            {
                                AppliedPatch ap = new AppliedPatch(gameFilesDirectory, delete_files);
                                DataContractJsonSerializer dcjs = new DataContractJsonSerializer(typeof(AppliedPatch));
                                dcjs.WriteObject(s, ap);
                            }
                        }
                    }
                    try
                    {
                        ProcessStartInfo psi = new ProcessStartInfo(executable);
                        psi.WorkingDirectory = gameFilesDirectory;
                        Process p = Process.Start(psi);
                        while (!p.HasExited) { }
                        ret = p.ExitCode;
                    }
                    catch (Exception e)
                    {
                        Console.Error.WriteLine(e.Message);
                    }
                    try
                    {
                        using (ZipArchive zab = ZipFile.Open(an, ZipArchiveMode.Read))
                        {
                            foreach (ZipArchiveEntry zae in zab.Entries)
                            {
                                if (zae.FullName != PatchIO.META_FILE)
                                {
                                    string extract_file = Core.AddLastChar(gameFilesDirectory, '\\') + zae.FullName;
                                    if (File.Exists(extract_file))
                                        File.Delete(extract_file);
                                    zae.ExtractToFile(extract_file);
                                }
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        Console.Error.WriteLine(e.Message);
                    }
                    foreach (string file in delete_files)
                    {
                        if (File.Exists(file))
                            File.Delete(file);
                    }
                    if (File.Exists(an))
                        File.Delete(an);
                }
                catch (Exception e)
                {
                    if (File.Exists(an))
                        File.Delete(an);
                    Console.Error.WriteLine(e.Message);
                }
            }
            return ret;
        }

        public void ShowConfigurationDialog()
        {
            PatchConfigurationForm pcf = new PatchConfigurationForm(this);
            pcf.ShowDialog();
        }

        public void Save()
        {
            try
            {
                using (ZipArchive za = Open(ZipArchiveMode.Update))
                {
                    ZipArchiveEntry zae = za.GetEntry(PatchIO.META_FILE);
                    if (zae != null)
                    {
                        zae.Delete();
                        zae = za.CreateEntry(PatchIO.META_FILE, CompressionLevel.Fastest);
                    }
                    if (zae != null)
                    {
                        using (Stream s = zae.Open())
                        {
                            DataContractJsonSerializer dcjs = new DataContractJsonSerializer(typeof(PatchContainer));
                            dcjs.WriteObject(s, this);
                        }
                    }
                    try
                    {
                        zae = za.GetEntry(PatchIO.LOGO_FILE);
                        if (zae != null)
                            zae.Delete();
                    }
                    catch (Exception e)
                    {
                        zae = null;
                        Console.Error.WriteLine(e.Message);
                    }
                    if (image != null)
                    {
                        zae = za.CreateEntry(PatchIO.LOGO_FILE, CompressionLevel.Fastest);
                        if (zae != null)
                        {
                            using (Stream s = zae.Open())
                                image.Save(s, ImageFormat.Png);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
            }
        }
    }
}
