using System;
using System.IO;
using System.Windows.Forms;

namespace AutoGamePatcher
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (!Directory.Exists(PatchIO.PATCHES_DIRECTORY))
                Directory.CreateDirectory(PatchIO.PATCHES_DIRECTORY);
            if (!Directory.Exists(PatchIO.CURRENT_DIRECTORY))
                Directory.CreateDirectory(PatchIO.CURRENT_DIRECTORY);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
