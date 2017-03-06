using System;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Runtime.Serialization.Json;

namespace AutoGamePatcher
{
    public static class PatchIO
    {
        public static readonly string META_FILE = "meta.agp.json";

        public static readonly string LOGO_FILE = "logo.agp.png";

        public static readonly string PATCHES_DIRECTORY = "./Patches/";

        public static readonly string CURRENT_DIRECTORY = "./Current/";

        public static string GetRelativePath(string fromPath, string toPath)
        {
            string ret = toPath;
            try
            {
                Uri fu = new Uri(fromPath);
                Uri tu = new Uri(toPath);
                if (fu.Scheme == tu.Scheme)
                {
                    Uri relativeUri = fu.MakeRelativeUri(tu);
                    ret = Uri.UnescapeDataString(relativeUri.ToString());
                    if (tu.Scheme.Equals("file", StringComparison.InvariantCultureIgnoreCase))
                        ret = ret.Replace(Path.AltDirectorySeparatorChar, Path.DirectorySeparatorChar);
                }
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
            }
            return ret;
        }

        public static PatchContainer Load(string archiveName)
        {
            PatchContainer ret = null;
            try
            {
                using (ZipArchive za = ZipFile.Open(archiveName, ZipArchiveMode.Read))
                {
                    if (za != null)
                    {
                        ZipArchiveEntry zaem = za.GetEntry(META_FILE);
                        if (zaem != null)
                        {
                            byte[] data = new byte[zaem.Length];
                            using (Stream s = zaem.Open())
                            {
                                try
                                {
                                    DataContractJsonSerializer dcjs = new DataContractJsonSerializer(typeof(PatchContainer));
                                    ret = (PatchContainer)dcjs.ReadObject(s);
                                    if (ret != null)
                                    {
                                        ret.archiveName = archiveName;
                                        try
                                        {
                                            ZipArchiveEntry zael = za.GetEntry(LOGO_FILE);
                                            if (zael != null)
                                            {
                                                using (Stream sl = zael.Open())
                                                    ret.image = Image.FromStream(sl);
                                            }
                                            else
                                                ret = null;
                                        }
                                        catch (Exception e)
                                        {
                                            ret = null;
                                            Console.Error.WriteLine(e.Message);
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
                }
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
            }
            return ret;
        }

        public static Image LoadImage(string imageLink)
        {
            Image ret = null;
            try
            {
                Uri iuri = new Uri(imageLink);
                if ((iuri.Scheme == Uri.UriSchemeHttp) || (iuri.Scheme == Uri.UriSchemeHttps) || (iuri.Scheme == Uri.UriSchemeFtp))
                {
                    WebRequest request = WebRequest.Create(imageLink);
                    using (WebResponse response = request.GetResponse())
                    {
                        using (Stream stream = response.GetResponseStream())
                            ret = Image.FromStream(stream);
                    }
                }
                else if (iuri.Scheme == Uri.UriSchemeFile)
                    ret = Image.FromFile(imageLink);
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
            }
            if (ret == null)
                ret = Properties.Resources.NoImage;
            return ret;
        }

        public static void RestoreAllPatches()
        {
            string[] files = Directory.GetFiles(CURRENT_DIRECTORY, "*.agp");
            foreach (string file in files)
            {
                try
                {
                    using (ZipArchive zab = ZipFile.Open(file, ZipArchiveMode.Read))
                    {
                        ZipArchiveEntry zaem = zab.GetEntry(META_FILE);
                        if (zaem != null)
                        {
                            AppliedPatch ap = null;
                            using (Stream s = zaem.Open())
                            {
                                DataContractJsonSerializer dcjs = new DataContractJsonSerializer(typeof(AppliedPatch));
                                ap = (AppliedPatch)dcjs.ReadObject(s);
                            }
                            if (ap != null)
                            {
                                if (Directory.Exists(ap.GameFilesDirectory))
                                {
                                    foreach (ZipArchiveEntry zae in zab.Entries)
                                    {
                                        if (zae.FullName != META_FILE)
                                        {
                                            string extract_file = Core.AddLastChar(ap.GameFilesDirectory, '\\') + zae.FullName;
                                            if (File.Exists(extract_file))
                                                File.Delete(extract_file);
                                            zae.ExtractToFile(extract_file);
                                        }
                                    }
                                    ap.DeleteFiles();
                                }
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.Error.WriteLine(e.Message);
                }
                if (File.Exists(file))
                    File.Delete(file);
            }
        }
    }
}
