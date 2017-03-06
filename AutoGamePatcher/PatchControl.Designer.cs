namespace AutoGamePatcher
{
    partial class PatchControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.patchPanel = new MetroFramework.Controls.MetroPanel();
            this.descriptionTextBox = new MetroFramework.Controls.MetroTextBox();
            this.titlePanel = new MetroFramework.Controls.MetroPanel();
            this.titleLabel = new MetroFramework.Controls.MetroLabel();
            this.extendButton = new MetroFramework.Controls.MetroButton();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.contextMenu = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.configureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patchPanel.SuspendLayout();
            this.titlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // patchPanel
            // 
            this.patchPanel.Controls.Add(this.descriptionTextBox);
            this.patchPanel.Controls.Add(this.titlePanel);
            this.patchPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.patchPanel.HorizontalScrollbarBarColor = true;
            this.patchPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.patchPanel.HorizontalScrollbarSize = 10;
            this.patchPanel.Location = new System.Drawing.Point(0, 0);
            this.patchPanel.Name = "patchPanel";
            this.patchPanel.Size = new System.Drawing.Size(400, 50);
            this.patchPanel.TabIndex = 1;
            this.patchPanel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.patchPanel.VerticalScrollbarBarColor = true;
            this.patchPanel.VerticalScrollbarHighlightOnWheel = false;
            this.patchPanel.VerticalScrollbarSize = 10;
            // 
            // descriptionTextBox
            // 
            // 
            // 
            // 
            this.descriptionTextBox.CustomButton.Image = null;
            this.descriptionTextBox.CustomButton.Location = new System.Drawing.Point(397, 2);
            this.descriptionTextBox.CustomButton.Name = "";
            this.descriptionTextBox.CustomButton.Size = new System.Drawing.Size(0, 0);
            this.descriptionTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.descriptionTextBox.CustomButton.TabIndex = 1;
            this.descriptionTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.descriptionTextBox.CustomButton.UseSelectable = true;
            this.descriptionTextBox.CustomButton.Visible = false;
            this.descriptionTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.descriptionTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.descriptionTextBox.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.descriptionTextBox.Lines = new string[] {
        "Patch Description"};
            this.descriptionTextBox.Location = new System.Drawing.Point(0, 50);
            this.descriptionTextBox.MaxLength = 32767;
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.PasswordChar = '\0';
            this.descriptionTextBox.ReadOnly = true;
            this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.descriptionTextBox.SelectedText = "";
            this.descriptionTextBox.SelectionLength = 0;
            this.descriptionTextBox.SelectionStart = 0;
            this.descriptionTextBox.ShortcutsEnabled = true;
            this.descriptionTextBox.Size = new System.Drawing.Size(400, 0);
            this.descriptionTextBox.TabIndex = 3;
            this.descriptionTextBox.Text = "Patch Description";
            this.descriptionTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.descriptionTextBox.UseSelectable = true;
            this.descriptionTextBox.Visible = false;
            this.descriptionTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.descriptionTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // titlePanel
            // 
            this.titlePanel.Controls.Add(this.titleLabel);
            this.titlePanel.Controls.Add(this.extendButton);
            this.titlePanel.Controls.Add(this.logoPictureBox);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.HorizontalScrollbarBarColor = true;
            this.titlePanel.HorizontalScrollbarHighlightOnWheel = false;
            this.titlePanel.HorizontalScrollbarSize = 10;
            this.titlePanel.Location = new System.Drawing.Point(0, 0);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(400, 50);
            this.titlePanel.TabIndex = 2;
            this.titlePanel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.titlePanel.VerticalScrollbarBarColor = true;
            this.titlePanel.VerticalScrollbarHighlightOnWheel = false;
            this.titlePanel.VerticalScrollbarSize = 10;
            // 
            // titleLabel
            // 
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.titleLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.titleLabel.Location = new System.Drawing.Point(100, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(240, 50);
            this.titleLabel.TabIndex = 5;
            this.titleLabel.Text = "Patch";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.titleLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.titleLabel.Click += new System.EventHandler(this.titleLabel_Click);
            // 
            // extendButton
            // 
            this.extendButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.extendButton.Location = new System.Drawing.Point(340, 0);
            this.extendButton.Name = "extendButton";
            this.extendButton.Size = new System.Drawing.Size(60, 50);
            this.extendButton.TabIndex = 4;
            this.extendButton.Text = "{$MORE$}";
            this.extendButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.extendButton.UseSelectable = true;
            this.extendButton.Click += new System.EventHandler(this.extendButton_Click);
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.logoPictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.logoPictureBox.ErrorImage = global::AutoGamePatcher.Properties.Resources.NoImage;
            this.logoPictureBox.Image = global::AutoGamePatcher.Properties.Resources.NoImage;
            this.logoPictureBox.InitialImage = global::AutoGamePatcher.Properties.Resources.NoImage;
            this.logoPictureBox.Location = new System.Drawing.Point(0, 0);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(100, 50);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPictureBox.TabIndex = 2;
            this.logoPictureBox.TabStop = false;
            this.logoPictureBox.Click += new System.EventHandler(this.logoPictureBox_Click);
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configureToolStripMenuItem,
            this.manageFilesToolStripMenuItem});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(223, 48);
            // 
            // configureToolStripMenuItem
            // 
            this.configureToolStripMenuItem.Name = "configureToolStripMenuItem";
            this.configureToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.configureToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.configureToolStripMenuItem.Text = "{$CONFIGURE$}";
            this.configureToolStripMenuItem.Click += new System.EventHandler(this.configureToolStripMenuItem_Click);
            // 
            // manageFilesToolStripMenuItem
            // 
            this.manageFilesToolStripMenuItem.Name = "manageFilesToolStripMenuItem";
            this.manageFilesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F2)));
            this.manageFilesToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.manageFilesToolStripMenuItem.Text = "{$MANAGE_FILES$}";
            this.manageFilesToolStripMenuItem.Click += new System.EventHandler(this.manageFilesToolStripMenuItem_Click);
            // 
            // PatchControl
            // 
            this.ContextMenuStrip = this.contextMenu;
            this.Controls.Add(this.patchPanel);
            this.Name = "PatchControl";
            this.Size = new System.Drawing.Size(400, 50);
            this.patchPanel.ResumeLayout(false);
            this.titlePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel patchPanel;
        private MetroFramework.Controls.MetroPanel titlePanel;
        private MetroFramework.Controls.MetroLabel titleLabel;
        private MetroFramework.Controls.MetroButton extendButton;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private MetroFramework.Controls.MetroTextBox descriptionTextBox;
        private MetroFramework.Controls.MetroContextMenu contextMenu;
        private System.Windows.Forms.ToolStripMenuItem configureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageFilesToolStripMenuItem;
    }
}
