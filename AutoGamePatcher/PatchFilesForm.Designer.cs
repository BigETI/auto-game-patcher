namespace AutoGamePatcher
{
    partial class PatchFilesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("{$DIRECTORIES$}", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("{$FILES$}", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("{$INTERNAL$}", System.Windows.Forms.HorizontalAlignment.Left);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatchFilesForm));
            this.buttonsPanel = new MetroFramework.Controls.MetroPanel();
            this.createPatchButton = new MetroFramework.Controls.MetroButton();
            this.cancelButton = new MetroFramework.Controls.MetroButton();
            this.addDirectoryButton = new MetroFramework.Controls.MetroButton();
            this.addFileButton = new MetroFramework.Controls.MetroButton();
            this.filesListView = new MetroFramework.Controls.MetroListView();
            this.patchFileEntryNameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fileNameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.filesContextMenu = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.editEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonsPanel.SuspendLayout();
            this.filesContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.Controls.Add(this.createPatchButton);
            this.buttonsPanel.Controls.Add(this.cancelButton);
            this.buttonsPanel.Controls.Add(this.addDirectoryButton);
            this.buttonsPanel.Controls.Add(this.addFileButton);
            this.buttonsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonsPanel.HorizontalScrollbarBarColor = true;
            this.buttonsPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.buttonsPanel.HorizontalScrollbarSize = 10;
            this.buttonsPanel.Location = new System.Drawing.Point(20, 459);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Size = new System.Drawing.Size(731, 50);
            this.buttonsPanel.TabIndex = 1;
            this.buttonsPanel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.buttonsPanel.VerticalScrollbarBarColor = true;
            this.buttonsPanel.VerticalScrollbarHighlightOnWheel = false;
            this.buttonsPanel.VerticalScrollbarSize = 10;
            // 
            // createPatchButton
            // 
            this.createPatchButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.createPatchButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.createPatchButton.Location = new System.Drawing.Point(300, 0);
            this.createPatchButton.Name = "createPatchButton";
            this.createPatchButton.Size = new System.Drawing.Size(281, 50);
            this.createPatchButton.TabIndex = 5;
            this.createPatchButton.Text = "{$CREATE_PATCH$}";
            this.createPatchButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.createPatchButton.UseSelectable = true;
            this.createPatchButton.Click += new System.EventHandler(this.createPatchButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.cancelButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.cancelButton.Location = new System.Drawing.Point(581, 0);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(150, 50);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "{$CANCEL$}";
            this.cancelButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cancelButton.UseSelectable = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // addDirectoryButton
            // 
            this.addDirectoryButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.addDirectoryButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.addDirectoryButton.Location = new System.Drawing.Point(150, 0);
            this.addDirectoryButton.Name = "addDirectoryButton";
            this.addDirectoryButton.Size = new System.Drawing.Size(150, 50);
            this.addDirectoryButton.TabIndex = 3;
            this.addDirectoryButton.Text = "{$ADD_DIRECTORY$}";
            this.addDirectoryButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.addDirectoryButton.UseSelectable = true;
            this.addDirectoryButton.Click += new System.EventHandler(this.addDirectoryButton_Click);
            // 
            // addFileButton
            // 
            this.addFileButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.addFileButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.addFileButton.Location = new System.Drawing.Point(0, 0);
            this.addFileButton.Name = "addFileButton";
            this.addFileButton.Size = new System.Drawing.Size(150, 50);
            this.addFileButton.TabIndex = 2;
            this.addFileButton.Text = "{$ADD_FILE$}";
            this.addFileButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.addFileButton.UseSelectable = true;
            this.addFileButton.Click += new System.EventHandler(this.addFileButton_Click);
            // 
            // filesListView
            // 
            this.filesListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.filesListView.BackColor = System.Drawing.SystemColors.Window;
            this.filesListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.filesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.patchFileEntryNameColumnHeader,
            this.fileNameColumnHeader});
            this.filesListView.ContextMenuStrip = this.filesContextMenu;
            this.filesListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filesListView.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.filesListView.FullRowSelect = true;
            listViewGroup1.Header = "{$DIRECTORIES$}";
            listViewGroup1.Name = "directoriesListViewGroup";
            listViewGroup2.Header = "{$FILES$}";
            listViewGroup2.Name = "filesListViewGroup";
            listViewGroup3.Header = "{$INTERNAL$}";
            listViewGroup3.Name = "internalListViewGroup";
            this.filesListView.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3});
            this.filesListView.HotTracking = true;
            this.filesListView.HoverSelection = true;
            this.filesListView.Location = new System.Drawing.Point(20, 60);
            this.filesListView.Name = "filesListView";
            this.filesListView.OwnerDraw = true;
            this.filesListView.Size = new System.Drawing.Size(731, 399);
            this.filesListView.TabIndex = 2;
            this.filesListView.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.filesListView.UseCompatibleStateImageBehavior = false;
            this.filesListView.UseSelectable = true;
            this.filesListView.View = System.Windows.Forms.View.Details;
            // 
            // patchFileEntryNameColumnHeader
            // 
            this.patchFileEntryNameColumnHeader.Text = "{$PATCH_FILE_ENTRY$}";
            this.patchFileEntryNameColumnHeader.Width = 181;
            // 
            // fileNameColumnHeader
            // 
            this.fileNameColumnHeader.Text = "{$FILE_NAME$}";
            this.fileNameColumnHeader.Width = 123;
            // 
            // filesContextMenu
            // 
            this.filesContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editEntryToolStripMenuItem,
            this.deleteEntryToolStripMenuItem});
            this.filesContextMenu.Name = "filesContextMenu";
            this.filesContextMenu.Size = new System.Drawing.Size(144, 48);
            // 
            // editEntryToolStripMenuItem
            // 
            this.editEntryToolStripMenuItem.Name = "editEntryToolStripMenuItem";
            this.editEntryToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.editEntryToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.editEntryToolStripMenuItem.Text = "Edit entry";
            this.editEntryToolStripMenuItem.Click += new System.EventHandler(this.editEntryToolStripMenuItem_Click);
            // 
            // deleteEntryToolStripMenuItem
            // 
            this.deleteEntryToolStripMenuItem.Name = "deleteEntryToolStripMenuItem";
            this.deleteEntryToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.deleteEntryToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.deleteEntryToolStripMenuItem.Text = "Delete";
            this.deleteEntryToolStripMenuItem.Click += new System.EventHandler(this.deleteEntryToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Multiselect = true;
            // 
            // PatchFilesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 529);
            this.Controls.Add(this.filesListView);
            this.Controls.Add(this.buttonsPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PatchFilesForm";
            this.Text = "{$SELECT_FILES_TO_PATCH_FILE$}";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.buttonsPanel.ResumeLayout(false);
            this.filesContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroPanel buttonsPanel;
        private MetroFramework.Controls.MetroListView filesListView;
        private System.Windows.Forms.ColumnHeader fileNameColumnHeader;
        private System.Windows.Forms.ColumnHeader patchFileEntryNameColumnHeader;
        private MetroFramework.Controls.MetroButton createPatchButton;
        private MetroFramework.Controls.MetroButton cancelButton;
        private MetroFramework.Controls.MetroButton addDirectoryButton;
        private MetroFramework.Controls.MetroButton addFileButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private MetroFramework.Controls.MetroContextMenu filesContextMenu;
        private System.Windows.Forms.ToolStripMenuItem editEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteEntryToolStripMenuItem;
    }
}