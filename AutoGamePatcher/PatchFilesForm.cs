using MetroFramework.Controls;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;

namespace AutoGamePatcher
{
    public partial class PatchFilesForm : MetroForm
    {

        private PatchContainer patchContainer;

        private HashSet<string> deleteInternal = new HashSet<string>();

        public IEnumerable<KeyValuePair<string, string>> Files
        {
            get
            {
                Dictionary<string, string> ret = new Dictionary<string, string>();
                foreach (ListViewItem lvi in filesListView.Groups[1].Items)
                    ret.Add(lvi.SubItems[0].Text, lvi.SubItems[1].Text);
                return ret;
            }
        }

        public IEnumerable<KeyValuePair<string, string>> Directories
        {
            get
            {
                Dictionary<string, string> ret = new Dictionary<string, string>();
                foreach (ListViewItem lvi in filesListView.Groups[0].Items)
                    ret.Add(lvi.SubItems[0].Text, lvi.SubItems[1].Text);
                return ret;
            }
        }

        public IEnumerable<string> DeleteInternal
        {
            get
            {
                return deleteInternal;
            }
        }

        public IEnumerable<KeyValuePair<string, string>> RenameInternal
        {
            get
            {
                Dictionary<string, string> ret = new Dictionary<string, string>();
                foreach (ListViewItem lvi in filesListView.Groups[2].Items)
                {
                    if (lvi.SubItems[0].Text != lvi.SubItems[1].Text)
                        ret.Add(lvi.SubItems[0].Text, lvi.SubItems[1].Text);
                }
                return ret;
            }
        }

        public bool HasEntry(string name)
        {
            bool ret = false;
            foreach (ListViewItem lvi in filesListView.Items)
            {
                if (lvi.SubItems[0].Text == name)
                {
                    ret = true;
                    break;
                }
            }
            return ret;
        }

        public PatchFilesForm(PatchContainer patchContainer)
        {
            InitializeComponent();
            Core.LoadThemeAndStyle(this);
            Translator.LoadLanguage(this);
            this.patchContainer = patchContainer;
            MetroListView mlv = filesListView;
            if (File.Exists(patchContainer.archiveName))
            {
                createPatchButton.Text = Translator.GetTranslation("EDIT_PATCH");
                try
                {
                    using (ZipArchive za = patchContainer.Open(ZipArchiveMode.Read))
                    {
                        foreach (ZipArchiveEntry zae in za.Entries)
                        {
                            if ((zae.FullName != PatchIO.META_FILE) && (zae.FullName != PatchIO.LOGO_FILE))
                                filesListView.Items.Add(new ListViewItem(new string[] { zae.FullName, zae.FullName }, filesListView.Groups[2]));
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.Error.WriteLine(e.Message);
                }
            }
        }

        private void addFileButton_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog.ShowDialog();
            DialogResult = DialogResult.None;
            if (result == DialogResult.OK)
            {
                foreach (string file_name in openFileDialog.FileNames)
                {
                    do
                    {
                        InputDialogForm idf = new InputDialogForm("{$ASSIGN_PATCH_FILE_ENTRY_TO_CONTINUE$}", "{$PATCH_FILE_ENTRY$}", Path.GetFileName(file_name));
                        result = idf.ShowDialog();
                        DialogResult = DialogResult.None;
                        if (result == DialogResult.OK)
                        {
                            if (HasEntry(idf.InputResult))
                                MessageBox.Show(Translator.GetTranslation("THIS_ENTRY_ALREADY_EXISTS"), Translator.GetTranslation("ENTRY_ALREADY_EXISTS"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                            else
                            {
                                filesListView.Items.Add(new ListViewItem(new string[] { idf.InputResult, file_name }, filesListView.Groups[1]));
                                break;
                            }
                        }
                        else
                            break;
                    } while (true);

                }
            }
        }

        private void addDirectoryButton_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog.ShowDialog();
            DialogResult = DialogResult.None;
            if (result == DialogResult.OK)
            {
                string path_name = folderBrowserDialog.SelectedPath;
                do
                {
                    InputDialogForm idf = new InputDialogForm("{$ASSIGN_PATCH_FILE_ENTRY_TO_CONTINUE$}", "{$PATCH_FILE_ENTRY$}", (new DirectoryInfo(path_name)).Name);
                    result = idf.ShowDialog();
                    DialogResult = DialogResult.None;
                    if (result == DialogResult.OK)
                    {
                        if (HasEntry(idf.InputResult))
                            MessageBox.Show(Translator.GetTranslation("THIS_ENTRY_ALREADY_EXISTS"), Translator.GetTranslation("ENTRY_ALREADY_EXISTS"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                        {
                            filesListView.Items.Add(new ListViewItem(new string[] { idf.InputResult, path_name }, filesListView.Groups[0]));
                            break;
                        }
                    }
                    else
                        break;
                } while (true);
            }
        }

        private void createPatchButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void editEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (filesListView.SelectedItems.Count > 0)
            {
                ListViewItem lvi = filesListView.SelectedItems[0];
                InputDialogForm idf = new InputDialogForm("{$ASSIGN_PATCH_FILE_ENTRY_TO_CONTINUE$}", "{$PATCH_FILE_ENTRY$}", lvi.SubItems[0].Text);
                DialogResult result = idf.ShowDialog();
                DialogResult = DialogResult.None;
                if (result == DialogResult.OK)
                    lvi.SubItems[0].Text = idf.InputResult;
            }
        }

        private void deleteEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (filesListView.SelectedItems.Count > 0)
            {
                DialogResult result = MessageBox.Show(Translator.GetTranslation("DELETE_ENTRY_QUESTION"), Translator.GetTranslation("DELETE_ENTRY_TITLE"), MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                DialogResult = DialogResult.None;
                if (result == DialogResult.Yes)
                {
                    List<ListViewItem> lvis = new List<ListViewItem>();
                    foreach (ListViewItem lvi in filesListView.SelectedItems)
                        lvis.Add(lvi);
                    foreach (ListViewItem lvi in lvis)
                    {
                        if (lvi.Group == filesListView.Groups[2])
                            deleteInternal.Add(lvi.SubItems[1].Text);
                        filesListView.Items.Remove(lvi);
                    }
                }
            }
        }
    }
}
