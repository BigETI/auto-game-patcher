using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AutoGamePatcher
{
    public partial class PatchControl : UserControl
    {

        private MainForm mainForm;

        private PatchContainer patchContainer;

        private bool extended = false;

        public PatchContainer PatchContainer
        {
            get
            {
                return patchContainer;
            }
        }

        public PatchControl(PatchContainer patchContainer, MainForm mainForm)
        {
            InitializeComponent();
            Core.LoadThemeAndStyle(this);
            Translator.LoadLanguage(this);
            Translator.LoadLanguage(contextMenu);
            this.patchContainer = patchContainer;
            this.mainForm = mainForm;
            if (patchContainer != null)
            {
                if (patchContainer.Image != null)
                    logoPictureBox.Image = patchContainer.Image;
                StringBuilder txt = new StringBuilder();
                txt.AppendLine(patchContainer.Title);
                txt.Append(Translator.GetTranslation("VERSION"));
                txt.Append(": ");
                txt.Append(patchContainer.Version);
                titleLabel.Text = txt.ToString();
                txt.Clear();
                txt.Append(Translator.GetTranslation("AUTHOR"));
                txt.Append(": ");
                txt.AppendLine(patchContainer.Author);
                txt.Append("\n");
                txt.Append(Translator.GetTranslation("DESCRIPTION"));
                txt.AppendLine(":");
                txt.AppendLine(patchContainer.Description);
                txt.Append("\n");
                txt.Append(Translator.GetTranslation("GAME_FILES_DIRECTORY"));
                txt.Append(": ");
                txt.AppendLine(patchContainer.GameFilesDirectory);
                txt.Append("\n");
                txt.Append(Translator.GetTranslation("ADDITIONAL_INFO"));
                txt.AppendLine(":");
                txt.AppendLine(patchContainer.Info);
                descriptionTextBox.Text = txt.ToString();
            }
        }

        private void extendButton_Click(object sender, EventArgs e)
        {
            extended = !extended;
            Size = new Size(Size.Width, extended ? 400 : 50);
            extendButton.Text = Translator.GetTranslation(extended ? "LESS" : "MORE");
            descriptionTextBox.Visible = extended;
        }

        private void logoPictureBox_Click(object sender, EventArgs e)
        {
            mainForm.SelectedPatch = this;
        }

        private void titleLabel_Click(object sender, EventArgs e)
        {
            mainForm.SelectedPatch = this;
        }

        private void configureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            patchContainer.ShowConfigurationDialog();
            mainForm.DialogResult = DialogResult.None;
            mainForm.FocusMe();
        }

        private void manageFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PatchFilesForm pff = new PatchFilesForm(patchContainer);
            DialogResult result = pff.ShowDialog();
            mainForm.DialogResult = DialogResult.None;
            if (result == DialogResult.OK)
            {
                patchContainer.Modify(pff.Files, pff.Directories, pff.DeleteInternal, pff.RenameInternal);
            }
        }
    }
}
