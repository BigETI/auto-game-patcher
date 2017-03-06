using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;

namespace AutoGamePatcher
{
    [DataContract]
    public class AppliedPatch
    {
        [DataMember]
        internal string gameFilesDirectory = "";

        [DataMember]
        internal string[] deleteFiles = new string[0];

        public string GameFilesDirectory
        {
            get
            {
                return gameFilesDirectory;
            }
        }

        public AppliedPatch()
        {
            //
        }

        public AppliedPatch(string gameFilesDirectory, string[] deleteFiles)
        {
            this.gameFilesDirectory = gameFilesDirectory;
            this.deleteFiles = deleteFiles;
        }

        public AppliedPatch(string gameFilesDirectory, IEnumerable<string> deleteFiles)
        {
            this.gameFilesDirectory = gameFilesDirectory;
            this.deleteFiles = deleteFiles.ToArray();
        }

        public void DeleteFiles()
        {
            foreach (string file in deleteFiles)
            {
                if (File.Exists(file))
                    File.Delete(file);
            }
        }
    }
}
