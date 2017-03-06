using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Drawing;
using MetroFramework;
using System.Diagnostics;

namespace AutoGamePatcher
{
    public partial class MainForm : MetroForm
    {

        private Dictionary<string, PatchControl> patches = new Dictionary<string, PatchControl>();

        private PatchControl selectedPatch = null;

        private bool updateWhenFocused = true;

        private string downloadedFileName = "";

        public PatchControl SelectedPatch
        {
            get
            {
                return selectedPatch;
            }
            set
            {
                if (selectedPatch != null)
                    Core.LoadThemeAndStyle(selectedPatch);
                selectedPatch = value;
                if (selectedPatch != null)
                    Core.LoadReversedTheme(selectedPatch);
                patchGameButton.Enabled = (selectedPatch != null);
            }
        }

        private void RemovePatches()
        {
            foreach (KeyValuePair<string, PatchControl> patch in patches)
            {
                gamePatchesPanel.Controls.Remove(patch.Value);
                patch.Value.Dispose();
            }
            patches.Clear();
        }

        private void UpdatePatches()
        {
            if (ContainsFocus)
            {
                updateWhenFocused = false;
                RemovePatches();
                try
                {
                    string[] fns = Directory.GetFiles(PatchIO.PATCHES_DIRECTORY, "*.agp", SearchOption.AllDirectories);
                    foreach (string fn in fns)
                    {
                        PatchContainer pc = PatchIO.Load(fn);
                        if (pc != null)
                        {
                            PatchControl pctrl = new PatchControl(pc, this);
                            patches.Add(fn, pctrl);
                            gamePatchesPanel.Controls.Add(pctrl);
                            pctrl.Dock = DockStyle.Top;
                        }
                    }

                }
                catch (Exception e)
                {
                    Console.Error.WriteLine(e.Message);
                }
            }
            else
                updateWhenFocused = true;
        }

        public MainForm()
        {
            InitializeComponent();
            Properties.Settings.Default.Reload();
            Core.LoadThemeAndStyle(this);
            Translator.LoadLanguage(this);
            UpdatePatches();
            PatchIO.RestoreAllPatches();
            Core.ArrayToComboBox(languageComboBox, LanguageCollection.All);
            Core.EnumToComboBox<MetroThemeStyle>(themesComboBox, new MetroThemeStyle[] { MetroThemeStyle.Default });
            Core.EnumToComboBox<MetroColorStyle>(stylesComboBox, new MetroColorStyle[] { MetroColorStyle.Default });
            themesComboBox.SelectedItem = Properties.Settings.Default.UseTheme;
            stylesComboBox.SelectedItem = Properties.Settings.Default.UseStyle;
            versionAboutLabel.Text = Application.ProductVersion + "\r\n";
        }

        private void importCreatePatchRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            importPatchPanel.Enabled = importPatchRadioButton.Checked;
            createPatchPanel.Enabled = createPatchRadioButton.Checked;
        }

        private void selectPatchFileButton_Click(object sender, EventArgs e)
        {
            bool success = false;
            DialogResult result = openAGPFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (PatchIO.Load(openAGPFileDialog.FileName) != null)
                {
                    success = true;
                    importPatchTextBox.Text = openAGPFileDialog.FileName;
                }
            }
            DialogResult = DialogResult.None;
            if (!success)
                MessageBox.Show(Translator.GetTranslation("THIS_IS_NOT_AGP_FILE"), Translator.GetTranslation("INVALID_FILE"), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void importPatchButton_Click(object sender, EventArgs e)
        {
            InputDialogForm idf = new InputDialogForm("{$SELECT_FILE_NAME_TO_CONTINUE$}", "{$SELECT_FILE_NAME$}", PatchIO.PATCHES_DIRECTORY + Path.GetFileName(importPatchTextBox.Text));
            DialogResult result = idf.ShowDialog();
            DialogResult = DialogResult.None;
            if (result == DialogResult.OK)
            {
                downloadedFileName = idf.InputResult;
                bool success = false;
                if (File.Exists(downloadedFileName))
                {
                    result = MessageBox.Show(Translator.GetTranslation("THIS_FILE_ALREADY_EXISTS"), Translator.GetTranslation("FILE_ALREADY_EXISTS"), MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    DialogResult = DialogResult.None;
                    success = (result == DialogResult.Yes);
                }
                else
                    success = true;
                if (success)
                {
                    Uri uri = null;
                    if (Uri.TryCreate(importPatchTextBox.Text.Trim(), UriKind.Absolute, out uri))
                    {
                        if ((uri.Scheme == Uri.UriSchemeHttp) || (uri.Scheme == Uri.UriSchemeHttps) || (uri.Scheme == Uri.UriSchemeFtp))
                        {
                            // Is URL
                            importCreatePatchTabPage.Enabled = false;
                            importPatchProgressBar.Value = 0;
                            importPatchProgressBar.Visible = true;
                            WebClient wc = new WebClient();
                            wc.DownloadProgressChanged += OnDownloadProgressChanged;
                            wc.DownloadDataCompleted += OnDownloadDataCompleted;
                            wc.DownloadDataAsync(uri);
                        }
                        else if (uri.Scheme == Uri.UriSchemeFile)
                        {
                            // Is File
                            if (File.Exists(downloadedFileName))
                                File.Delete(downloadedFileName);
                            File.Copy(importPatchTextBox.Text, downloadedFileName);
                            PatchContainer pc = PatchIO.Load(downloadedFileName);
                            if (pc == null)
                            {
                                File.Delete(downloadedFileName);
                                MessageBox.Show(Translator.GetTranslation("THIS_IS_NOT_AGP_FILE"), Translator.GetTranslation("INVALID_FILE"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                pc.ShowConfigurationDialog();
                                DialogResult = DialogResult.None;
                            }
                            mainTabControl.SelectedTab = gamePatchesTabPage;
                        }
                    }
                }
            }
        }

        //[MethodImpl(MethodImplOptions.Synchronized)]
        private void OnDownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            importPatchProgressBar.Maximum = (int)e.TotalBytesToReceive;
            importPatchProgressBar.Value = (int)e.BytesReceived;
        }

        //[MethodImpl(MethodImplOptions.Synchronized)]
        private void OnDownloadDataCompleted(object sender, DownloadDataCompletedEventArgs e)
        {
            importCreatePatchTabPage.Enabled = true;
            importPatchProgressBar.Visible = false;
            if ((!e.Cancelled) && (e.Result.Length > 0))
            {
                mainTabControl.SelectedTab = gamePatchesTabPage;
                try
                {
                    if (File.Exists(downloadedFileName))
                        File.Delete(downloadedFileName);
                    using (FileStream fs = File.Create(downloadedFileName))
                        fs.Write(e.Result, 0, e.Result.Length);
                    PatchContainer pc = PatchIO.Load(downloadedFileName);
                    if (pc == null)
                    {
                        File.Delete(downloadedFileName);
                        MessageBox.Show(Translator.GetTranslation("THIS_IS_NOT_AGP_FILE"), Translator.GetTranslation("INVALID_FILE"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        pc.ShowConfigurationDialog();
                        DialogResult = DialogResult.None;
                    }
                }
                catch (Exception ex)
                {
                    Console.Error.WriteLine(ex.Message);
                }
            }
        }

        private void createPatchButton_Click(object sender, EventArgs e)
        {
            bool success = false;
            PatchContainer pc = new PatchContainer(executableCreateTextBox.Text, gameFilesDirectoryCreateTextBox.Text, titleCreateTextBox.Text, descriptionCreateTextBox.Text, authorCreateTextBox.Text, versionCreateTextBox.Text, infoCreateTextBox.Text, imageLinkCreateTextBox.Text, archiveNameCreateTextBox.Text);
            if (File.Exists(pc.archiveName))
            {
                DialogResult result = MessageBox.Show(Translator.GetTranslation("THIS_FILE_ALREADY_EXISTS"), Translator.GetTranslation("FILE_ALREADY_EXISTS"), MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                DialogResult = DialogResult.None;
                if (result == DialogResult.Yes)
                {
                    File.Delete(pc.archiveName);
                    success = true;
                }
            }
            else
                success = true;
            if (success)
            {
                PatchFilesForm pff = new PatchFilesForm(pc);
                DialogResult result = pff.ShowDialog();
                DialogResult = DialogResult.None;
                if (result == DialogResult.OK)
                    pc.Create(pff.Files, pff.Directories);
            }
        }

        private void gameFilesDirectoryButton_Click(object sender, EventArgs e)
        {
            //
        }

        private void imageLinkCreateButton_Click(object sender, EventArgs e)
        {
            Image image = PatchIO.LoadImage(imageLinkCreateTextBox.Text);
            imageLinkCreatePictureBox.Image = image;
            if (image == null)
                MessageBox.Show(Translator.GetTranslation("IMAGE_REFERENCE_ERROR"), Translator.GetTranslation("IMAGE_LOAD_ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void languageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Translator.ChangeLanguage((Language)languageComboBox.SelectedItem);
            //languageComboBox.SelectedIndex = -1;
        }

        private void fileSystemWatcher_ChangedCreatedDeleted(object sender, FileSystemEventArgs e)
        {
            UpdatePatches();
        }

        private void fileSystemWatcher_Renamed(object sender, RenamedEventArgs e)
        {
            UpdatePatches();
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            if (updateWhenFocused)
                UpdatePatches();
        }

        private void archiveNameCreateButton_Click(object sender, EventArgs e)
        {
            DialogResult result = saveAGPFileDialog.ShowDialog();
            DialogResult = DialogResult.None;
            if (result == DialogResult.OK)
                archiveNameCreateTextBox.Text = saveAGPFileDialog.FileName;
        }

        private void gameFilesDirectoryCreateButton_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog.ShowDialog();
            DialogResult = DialogResult.None;
            if (result == DialogResult.OK)
                gameFilesDirectoryCreateTextBox.Text = folderBrowserDialog.SelectedPath;
        }

        private void gamePatchesPanel_Click(object sender, EventArgs e)
        {
            SelectedPatch = null;
        }

        private void patchGameButton_Click(object sender, EventArgs e)
        {
            if (selectedPatch != null)
                selectedPatch.PatchContainer.PatchAndRun();
        }

        private void themesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.UseTheme = (MetroThemeStyle)themesComboBox.SelectedItem;
            Properties.Settings.Default.Save();
            Core.LoadThemeAndStyle(this);
            SelectedPatch = null;
        }

        private void stylesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.UseStyle = (MetroColorStyle)stylesComboBox.SelectedItem;
            Properties.Settings.Default.Save();
            Core.LoadThemeAndStyle(this);
            SelectedPatch = null;
        }

        private void gplLinkAboutLink_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.gnu.org/licenses/gpl-3.0.txt");
        }

        private void gitHubAboutLink_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/BigETI/auto-game-patcher");
        }
    }
}
