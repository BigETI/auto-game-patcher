using MetroFramework.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AutoGamePatcher
{
    public partial class PatchConfigurationForm : MetroForm
    {

        private PatchContainer patchContainer;

        public PatchConfigurationForm(PatchContainer patchContainer)
        {
            InitializeComponent();
            Core.LoadThemeAndStyle(this);
            Translator.LoadLanguage(this);
            this.patchContainer = patchContainer;
            executableTextBox.Text = patchContainer.Executable;
            gameFilesDirectoryTextBox.Text = patchContainer.GameFilesDirectory;
            titleTextBox.Text = patchContainer.Title;
            authorTextBox.Text = patchContainer.Author;
            versionTextBox.Text = patchContainer.Version;
            imageLinkTextBox.Text = "";
            descriptionTextBox.Text = patchContainer.Description;
        }

        private void replaceImageCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            bool c = useImageCheckBox.Checked;
            imageLinkCreateLabel.Enabled = c;
            imageLinkTextBox.Enabled = c;
            imageLinkCreateButton.Enabled = c;
            if (!c)
                imageLinkCreatePictureBox.Image = patchContainer.Image;
        }

        private void gameFilesDirectoryCreateButton_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog.ShowDialog();
            DialogResult = DialogResult.None;
            if (result == DialogResult.OK)
                gameFilesDirectoryTextBox.Text = folderBrowserDialog.SelectedPath;
        }

        private void imageLinkCreateButton_Click(object sender, EventArgs e)
        {
            Image image = PatchIO.LoadImage(imageLinkTextBox.Text);
            imageLinkCreatePictureBox.Image = image;
            if (image == null)
                MessageBox.Show(Translator.GetTranslation("IMAGE_REFERENCE_ERROR"), Translator.GetTranslation("IMAGE_LOAD_ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            patchContainer.executable = executableTextBox.Text;
            patchContainer.gameFilesDirectory = gameFilesDirectoryTextBox.Text;
            patchContainer.title = titleTextBox.Text;
            patchContainer.author = authorTextBox.Text;
            patchContainer.version = versionTextBox.Text;
            if (useImageCheckBox.Checked)
                patchContainer.image = PatchIO.LoadImage(imageLinkTextBox.Text);
            patchContainer.description = descriptionTextBox.Text;
            patchContainer.Save();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
