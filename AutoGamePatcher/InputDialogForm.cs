using MetroFramework.Forms;
using System;
using System.Windows.Forms;

namespace AutoGamePatcher
{
    public partial class InputDialogForm : MetroForm
    {
        public InputDialogForm(string message, string title, string input = "")
        {
            InitializeComponent();
            Core.LoadThemeAndStyle(this);
            messageLabel.Text = message;
            Text = title;
            Translator.LoadLanguage(this);
            inputTextBox.Text = input;
        }

        public string InputResult
        {
            get
            {
                return inputTextBox.Text;
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
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
