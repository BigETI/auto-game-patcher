namespace AutoGamePatcher
{
    partial class PatchConfigurationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatchConfigurationForm));
            this.buttonsPanel = new MetroFramework.Controls.MetroPanel();
            this.cancelButton = new MetroFramework.Controls.MetroButton();
            this.okButton = new MetroFramework.Controls.MetroButton();
            this.mainPanel = new MetroFramework.Controls.MetroPanel();
            this.gameFilesDirectoryCreateButton = new MetroFramework.Controls.MetroButton();
            this.useImageCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.executableCreateLabel = new MetroFramework.Controls.MetroLabel();
            this.executableTextBox = new MetroFramework.Controls.MetroTextBox();
            this.imageLinkCreateLabel = new MetroFramework.Controls.MetroLabel();
            this.imageLinkTextBox = new MetroFramework.Controls.MetroTextBox();
            this.imageLinkCreateButton = new MetroFramework.Controls.MetroButton();
            this.imageLinkCreatePictureBox = new System.Windows.Forms.PictureBox();
            this.infoCreateLabel = new MetroFramework.Controls.MetroLabel();
            this.infoCreateTextBox = new MetroFramework.Controls.MetroTextBox();
            this.versionCreateLabel = new MetroFramework.Controls.MetroLabel();
            this.versionTextBox = new MetroFramework.Controls.MetroTextBox();
            this.authorCreateLabel = new MetroFramework.Controls.MetroLabel();
            this.authorTextBox = new MetroFramework.Controls.MetroTextBox();
            this.descriptionCreateLabel = new MetroFramework.Controls.MetroLabel();
            this.descriptionTextBox = new MetroFramework.Controls.MetroTextBox();
            this.titleCreateLabel = new MetroFramework.Controls.MetroLabel();
            this.titleTextBox = new MetroFramework.Controls.MetroTextBox();
            this.gameFilesDirectoryCreateLabel = new MetroFramework.Controls.MetroLabel();
            this.gameFilesDirectoryTextBox = new MetroFramework.Controls.MetroTextBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonsPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageLinkCreatePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.Controls.Add(this.cancelButton);
            this.buttonsPanel.Controls.Add(this.okButton);
            this.buttonsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonsPanel.HorizontalScrollbarBarColor = true;
            this.buttonsPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.buttonsPanel.HorizontalScrollbarSize = 10;
            this.buttonsPanel.Location = new System.Drawing.Point(20, 480);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Size = new System.Drawing.Size(693, 23);
            this.buttonsPanel.TabIndex = 1;
            this.buttonsPanel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.buttonsPanel.VerticalScrollbarBarColor = true;
            this.buttonsPanel.VerticalScrollbarHighlightOnWheel = false;
            this.buttonsPanel.VerticalScrollbarSize = 10;
            // 
            // cancelButton
            // 
            this.cancelButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.cancelButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.cancelButton.Location = new System.Drawing.Point(543, 0);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(150, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "{$CANCEL$}";
            this.cancelButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cancelButton.UseSelectable = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.okButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.okButton.Location = new System.Drawing.Point(0, 0);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(150, 23);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "{$OK$}";
            this.okButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.okButton.UseSelectable = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.gameFilesDirectoryCreateButton);
            this.mainPanel.Controls.Add(this.useImageCheckBox);
            this.mainPanel.Controls.Add(this.executableCreateLabel);
            this.mainPanel.Controls.Add(this.executableTextBox);
            this.mainPanel.Controls.Add(this.imageLinkCreateLabel);
            this.mainPanel.Controls.Add(this.imageLinkTextBox);
            this.mainPanel.Controls.Add(this.imageLinkCreateButton);
            this.mainPanel.Controls.Add(this.imageLinkCreatePictureBox);
            this.mainPanel.Controls.Add(this.infoCreateLabel);
            this.mainPanel.Controls.Add(this.infoCreateTextBox);
            this.mainPanel.Controls.Add(this.versionCreateLabel);
            this.mainPanel.Controls.Add(this.versionTextBox);
            this.mainPanel.Controls.Add(this.authorCreateLabel);
            this.mainPanel.Controls.Add(this.authorTextBox);
            this.mainPanel.Controls.Add(this.descriptionCreateLabel);
            this.mainPanel.Controls.Add(this.descriptionTextBox);
            this.mainPanel.Controls.Add(this.titleCreateLabel);
            this.mainPanel.Controls.Add(this.titleTextBox);
            this.mainPanel.Controls.Add(this.gameFilesDirectoryCreateLabel);
            this.mainPanel.Controls.Add(this.gameFilesDirectoryTextBox);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.HorizontalScrollbarBarColor = true;
            this.mainPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.mainPanel.HorizontalScrollbarSize = 10;
            this.mainPanel.Location = new System.Drawing.Point(20, 60);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(693, 420);
            this.mainPanel.TabIndex = 0;
            this.mainPanel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mainPanel.VerticalScrollbarBarColor = true;
            this.mainPanel.VerticalScrollbarHighlightOnWheel = false;
            this.mainPanel.VerticalScrollbarSize = 10;
            // 
            // gameFilesDirectoryCreateButton
            // 
            this.gameFilesDirectoryCreateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gameFilesDirectoryCreateButton.Location = new System.Drawing.Point(663, 32);
            this.gameFilesDirectoryCreateButton.Name = "gameFilesDirectoryCreateButton";
            this.gameFilesDirectoryCreateButton.Size = new System.Drawing.Size(30, 23);
            this.gameFilesDirectoryCreateButton.TabIndex = 4;
            this.gameFilesDirectoryCreateButton.Text = "...";
            this.gameFilesDirectoryCreateButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.gameFilesDirectoryCreateButton.UseSelectable = true;
            this.gameFilesDirectoryCreateButton.Click += new System.EventHandler(this.gameFilesDirectoryCreateButton_Click);
            // 
            // useImageCheckBox
            // 
            this.useImageCheckBox.AutoSize = true;
            this.useImageCheckBox.Location = new System.Drawing.Point(135, 177);
            this.useImageCheckBox.Name = "useImageCheckBox";
            this.useImageCheckBox.Size = new System.Drawing.Size(132, 15);
            this.useImageCheckBox.TabIndex = 13;
            this.useImageCheckBox.Text = "{$REPLACE_IMAGE$}";
            this.useImageCheckBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.useImageCheckBox.UseSelectable = true;
            this.useImageCheckBox.CheckedChanged += new System.EventHandler(this.replaceImageCheckBox_CheckedChanged);
            // 
            // executableCreateLabel
            // 
            this.executableCreateLabel.AutoSize = true;
            this.executableCreateLabel.Location = new System.Drawing.Point(3, 7);
            this.executableCreateLabel.Name = "executableCreateLabel";
            this.executableCreateLabel.Size = new System.Drawing.Size(106, 19);
            this.executableCreateLabel.TabIndex = 0;
            this.executableCreateLabel.Text = "{$EXECUTABLE$}";
            this.executableCreateLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // executableTextBox
            // 
            this.executableTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.executableTextBox.CustomButton.Image = null;
            this.executableTextBox.CustomButton.Location = new System.Drawing.Point(536, 1);
            this.executableTextBox.CustomButton.Name = "";
            this.executableTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.executableTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.executableTextBox.CustomButton.TabIndex = 1;
            this.executableTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.executableTextBox.CustomButton.UseSelectable = true;
            this.executableTextBox.CustomButton.Visible = false;
            this.executableTextBox.Lines = new string[0];
            this.executableTextBox.Location = new System.Drawing.Point(135, 3);
            this.executableTextBox.MaxLength = 32767;
            this.executableTextBox.Name = "executableTextBox";
            this.executableTextBox.PasswordChar = '\0';
            this.executableTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.executableTextBox.SelectedText = "";
            this.executableTextBox.SelectionLength = 0;
            this.executableTextBox.SelectionStart = 0;
            this.executableTextBox.ShortcutsEnabled = true;
            this.executableTextBox.Size = new System.Drawing.Size(558, 23);
            this.executableTextBox.TabIndex = 1;
            this.executableTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.executableTextBox.UseSelectable = true;
            this.executableTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.executableTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // imageLinkCreateLabel
            // 
            this.imageLinkCreateLabel.AutoSize = true;
            this.imageLinkCreateLabel.Enabled = false;
            this.imageLinkCreateLabel.Location = new System.Drawing.Point(3, 152);
            this.imageLinkCreateLabel.Name = "imageLinkCreateLabel";
            this.imageLinkCreateLabel.Size = new System.Drawing.Size(103, 19);
            this.imageLinkCreateLabel.TabIndex = 11;
            this.imageLinkCreateLabel.Text = "{$IMAGE_LINK$}";
            this.imageLinkCreateLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // imageLinkTextBox
            // 
            this.imageLinkTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.imageLinkTextBox.CustomButton.Image = null;
            this.imageLinkTextBox.CustomButton.Location = new System.Drawing.Point(324, 1);
            this.imageLinkTextBox.CustomButton.Name = "";
            this.imageLinkTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.imageLinkTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.imageLinkTextBox.CustomButton.TabIndex = 1;
            this.imageLinkTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.imageLinkTextBox.CustomButton.UseSelectable = true;
            this.imageLinkTextBox.CustomButton.Visible = false;
            this.imageLinkTextBox.Enabled = false;
            this.imageLinkTextBox.Lines = new string[0];
            this.imageLinkTextBox.Location = new System.Drawing.Point(135, 148);
            this.imageLinkTextBox.MaxLength = 32767;
            this.imageLinkTextBox.Name = "imageLinkTextBox";
            this.imageLinkTextBox.PasswordChar = '\0';
            this.imageLinkTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.imageLinkTextBox.SelectedText = "";
            this.imageLinkTextBox.SelectionLength = 0;
            this.imageLinkTextBox.SelectionStart = 0;
            this.imageLinkTextBox.ShortcutsEnabled = true;
            this.imageLinkTextBox.Size = new System.Drawing.Size(346, 23);
            this.imageLinkTextBox.TabIndex = 12;
            this.imageLinkTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.imageLinkTextBox.UseSelectable = true;
            this.imageLinkTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.imageLinkTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // imageLinkCreateButton
            // 
            this.imageLinkCreateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imageLinkCreateButton.Enabled = false;
            this.imageLinkCreateButton.Location = new System.Drawing.Point(593, 148);
            this.imageLinkCreateButton.Name = "imageLinkCreateButton";
            this.imageLinkCreateButton.Size = new System.Drawing.Size(100, 50);
            this.imageLinkCreateButton.TabIndex = 14;
            this.imageLinkCreateButton.Text = "{$PREVIEW_IMAGE$}";
            this.imageLinkCreateButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.imageLinkCreateButton.UseSelectable = true;
            this.imageLinkCreateButton.Click += new System.EventHandler(this.imageLinkCreateButton_Click);
            // 
            // imageLinkCreatePictureBox
            // 
            this.imageLinkCreatePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imageLinkCreatePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.imageLinkCreatePictureBox.ErrorImage = global::AutoGamePatcher.Properties.Resources.NoImage;
            this.imageLinkCreatePictureBox.Image = global::AutoGamePatcher.Properties.Resources.NoImage;
            this.imageLinkCreatePictureBox.InitialImage = global::AutoGamePatcher.Properties.Resources.NoImage;
            this.imageLinkCreatePictureBox.Location = new System.Drawing.Point(487, 148);
            this.imageLinkCreatePictureBox.Name = "imageLinkCreatePictureBox";
            this.imageLinkCreatePictureBox.Size = new System.Drawing.Size(100, 50);
            this.imageLinkCreatePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageLinkCreatePictureBox.TabIndex = 34;
            this.imageLinkCreatePictureBox.TabStop = false;
            // 
            // infoCreateLabel
            // 
            this.infoCreateLabel.AutoSize = true;
            this.infoCreateLabel.Location = new System.Drawing.Point(3, 314);
            this.infoCreateLabel.Name = "infoCreateLabel";
            this.infoCreateLabel.Size = new System.Drawing.Size(144, 19);
            this.infoCreateLabel.TabIndex = 17;
            this.infoCreateLabel.Text = "{$ADDITIONAL_INFO$}";
            this.infoCreateLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // infoCreateTextBox
            // 
            this.infoCreateTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.infoCreateTextBox.CustomButton.Image = null;
            this.infoCreateTextBox.CustomButton.Location = new System.Drawing.Point(456, 2);
            this.infoCreateTextBox.CustomButton.Name = "";
            this.infoCreateTextBox.CustomButton.Size = new System.Drawing.Size(99, 99);
            this.infoCreateTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.infoCreateTextBox.CustomButton.TabIndex = 1;
            this.infoCreateTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.infoCreateTextBox.CustomButton.UseSelectable = true;
            this.infoCreateTextBox.CustomButton.Visible = false;
            this.infoCreateTextBox.Lines = new string[0];
            this.infoCreateTextBox.Location = new System.Drawing.Point(135, 310);
            this.infoCreateTextBox.MaxLength = 32767;
            this.infoCreateTextBox.Multiline = true;
            this.infoCreateTextBox.Name = "infoCreateTextBox";
            this.infoCreateTextBox.PasswordChar = '\0';
            this.infoCreateTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.infoCreateTextBox.SelectedText = "";
            this.infoCreateTextBox.SelectionLength = 0;
            this.infoCreateTextBox.SelectionStart = 0;
            this.infoCreateTextBox.ShortcutsEnabled = true;
            this.infoCreateTextBox.Size = new System.Drawing.Size(558, 104);
            this.infoCreateTextBox.TabIndex = 18;
            this.infoCreateTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.infoCreateTextBox.UseSelectable = true;
            this.infoCreateTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.infoCreateTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // versionCreateLabel
            // 
            this.versionCreateLabel.AutoSize = true;
            this.versionCreateLabel.Location = new System.Drawing.Point(3, 123);
            this.versionCreateLabel.Name = "versionCreateLabel";
            this.versionCreateLabel.Size = new System.Drawing.Size(85, 19);
            this.versionCreateLabel.TabIndex = 9;
            this.versionCreateLabel.Text = "{$VERSION$}";
            this.versionCreateLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // versionTextBox
            // 
            this.versionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.versionTextBox.CustomButton.Image = null;
            this.versionTextBox.CustomButton.Location = new System.Drawing.Point(536, 1);
            this.versionTextBox.CustomButton.Name = "";
            this.versionTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.versionTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.versionTextBox.CustomButton.TabIndex = 1;
            this.versionTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.versionTextBox.CustomButton.UseSelectable = true;
            this.versionTextBox.CustomButton.Visible = false;
            this.versionTextBox.Lines = new string[0];
            this.versionTextBox.Location = new System.Drawing.Point(135, 119);
            this.versionTextBox.MaxLength = 32767;
            this.versionTextBox.Name = "versionTextBox";
            this.versionTextBox.PasswordChar = '\0';
            this.versionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.versionTextBox.SelectedText = "";
            this.versionTextBox.SelectionLength = 0;
            this.versionTextBox.SelectionStart = 0;
            this.versionTextBox.ShortcutsEnabled = true;
            this.versionTextBox.Size = new System.Drawing.Size(558, 23);
            this.versionTextBox.TabIndex = 10;
            this.versionTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.versionTextBox.UseSelectable = true;
            this.versionTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.versionTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // authorCreateLabel
            // 
            this.authorCreateLabel.AutoSize = true;
            this.authorCreateLabel.Location = new System.Drawing.Point(3, 94);
            this.authorCreateLabel.Name = "authorCreateLabel";
            this.authorCreateLabel.Size = new System.Drawing.Size(84, 19);
            this.authorCreateLabel.TabIndex = 7;
            this.authorCreateLabel.Text = "{$AUTHOR$}";
            this.authorCreateLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // authorTextBox
            // 
            this.authorTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.authorTextBox.CustomButton.Image = null;
            this.authorTextBox.CustomButton.Location = new System.Drawing.Point(536, 1);
            this.authorTextBox.CustomButton.Name = "";
            this.authorTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.authorTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.authorTextBox.CustomButton.TabIndex = 1;
            this.authorTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.authorTextBox.CustomButton.UseSelectable = true;
            this.authorTextBox.CustomButton.Visible = false;
            this.authorTextBox.Lines = new string[0];
            this.authorTextBox.Location = new System.Drawing.Point(135, 90);
            this.authorTextBox.MaxLength = 32767;
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.PasswordChar = '\0';
            this.authorTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.authorTextBox.SelectedText = "";
            this.authorTextBox.SelectionLength = 0;
            this.authorTextBox.SelectionStart = 0;
            this.authorTextBox.ShortcutsEnabled = true;
            this.authorTextBox.Size = new System.Drawing.Size(558, 23);
            this.authorTextBox.TabIndex = 8;
            this.authorTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.authorTextBox.UseSelectable = true;
            this.authorTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.authorTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // descriptionCreateLabel
            // 
            this.descriptionCreateLabel.AutoSize = true;
            this.descriptionCreateLabel.Location = new System.Drawing.Point(3, 208);
            this.descriptionCreateLabel.Name = "descriptionCreateLabel";
            this.descriptionCreateLabel.Size = new System.Drawing.Size(113, 19);
            this.descriptionCreateLabel.TabIndex = 15;
            this.descriptionCreateLabel.Text = "{$DESCRIPTION$}";
            this.descriptionCreateLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.descriptionTextBox.CustomButton.Image = null;
            this.descriptionTextBox.CustomButton.Location = new System.Drawing.Point(460, 2);
            this.descriptionTextBox.CustomButton.Name = "";
            this.descriptionTextBox.CustomButton.Size = new System.Drawing.Size(95, 95);
            this.descriptionTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.descriptionTextBox.CustomButton.TabIndex = 1;
            this.descriptionTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.descriptionTextBox.CustomButton.UseSelectable = true;
            this.descriptionTextBox.CustomButton.Visible = false;
            this.descriptionTextBox.Lines = new string[0];
            this.descriptionTextBox.Location = new System.Drawing.Point(135, 204);
            this.descriptionTextBox.MaxLength = 32767;
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.PasswordChar = '\0';
            this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.descriptionTextBox.SelectedText = "";
            this.descriptionTextBox.SelectionLength = 0;
            this.descriptionTextBox.SelectionStart = 0;
            this.descriptionTextBox.ShortcutsEnabled = true;
            this.descriptionTextBox.Size = new System.Drawing.Size(558, 100);
            this.descriptionTextBox.TabIndex = 16;
            this.descriptionTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.descriptionTextBox.UseSelectable = true;
            this.descriptionTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.descriptionTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // titleCreateLabel
            // 
            this.titleCreateLabel.AutoSize = true;
            this.titleCreateLabel.Location = new System.Drawing.Point(3, 65);
            this.titleCreateLabel.Name = "titleCreateLabel";
            this.titleCreateLabel.Size = new System.Drawing.Size(61, 19);
            this.titleCreateLabel.TabIndex = 5;
            this.titleCreateLabel.Text = "{$TITLE$}";
            this.titleCreateLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.titleTextBox.CustomButton.Image = null;
            this.titleTextBox.CustomButton.Location = new System.Drawing.Point(536, 1);
            this.titleTextBox.CustomButton.Name = "";
            this.titleTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.titleTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.titleTextBox.CustomButton.TabIndex = 1;
            this.titleTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.titleTextBox.CustomButton.UseSelectable = true;
            this.titleTextBox.CustomButton.Visible = false;
            this.titleTextBox.Lines = new string[0];
            this.titleTextBox.Location = new System.Drawing.Point(135, 61);
            this.titleTextBox.MaxLength = 32767;
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.PasswordChar = '\0';
            this.titleTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.titleTextBox.SelectedText = "";
            this.titleTextBox.SelectionLength = 0;
            this.titleTextBox.SelectionStart = 0;
            this.titleTextBox.ShortcutsEnabled = true;
            this.titleTextBox.Size = new System.Drawing.Size(558, 23);
            this.titleTextBox.TabIndex = 6;
            this.titleTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.titleTextBox.UseSelectable = true;
            this.titleTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.titleTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // gameFilesDirectoryCreateLabel
            // 
            this.gameFilesDirectoryCreateLabel.AutoSize = true;
            this.gameFilesDirectoryCreateLabel.Location = new System.Drawing.Point(3, 36);
            this.gameFilesDirectoryCreateLabel.Name = "gameFilesDirectoryCreateLabel";
            this.gameFilesDirectoryCreateLabel.Size = new System.Drawing.Size(179, 19);
            this.gameFilesDirectoryCreateLabel.TabIndex = 2;
            this.gameFilesDirectoryCreateLabel.Text = "{$GAME_FILES_DIRECTORY$}";
            this.gameFilesDirectoryCreateLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // gameFilesDirectoryTextBox
            // 
            this.gameFilesDirectoryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.gameFilesDirectoryTextBox.CustomButton.Image = null;
            this.gameFilesDirectoryTextBox.CustomButton.Location = new System.Drawing.Point(500, 1);
            this.gameFilesDirectoryTextBox.CustomButton.Name = "";
            this.gameFilesDirectoryTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.gameFilesDirectoryTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.gameFilesDirectoryTextBox.CustomButton.TabIndex = 1;
            this.gameFilesDirectoryTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.gameFilesDirectoryTextBox.CustomButton.UseSelectable = true;
            this.gameFilesDirectoryTextBox.CustomButton.Visible = false;
            this.gameFilesDirectoryTextBox.Lines = new string[0];
            this.gameFilesDirectoryTextBox.Location = new System.Drawing.Point(135, 32);
            this.gameFilesDirectoryTextBox.MaxLength = 32767;
            this.gameFilesDirectoryTextBox.Name = "gameFilesDirectoryTextBox";
            this.gameFilesDirectoryTextBox.PasswordChar = '\0';
            this.gameFilesDirectoryTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.gameFilesDirectoryTextBox.SelectedText = "";
            this.gameFilesDirectoryTextBox.SelectionLength = 0;
            this.gameFilesDirectoryTextBox.SelectionStart = 0;
            this.gameFilesDirectoryTextBox.ShortcutsEnabled = true;
            this.gameFilesDirectoryTextBox.Size = new System.Drawing.Size(522, 23);
            this.gameFilesDirectoryTextBox.TabIndex = 3;
            this.gameFilesDirectoryTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.gameFilesDirectoryTextBox.UseSelectable = true;
            this.gameFilesDirectoryTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.gameFilesDirectoryTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // PatchConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 523);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.buttonsPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PatchConfigurationForm";
            this.Text = "{$PATCH_CONFIGURATION$}";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TopMost = true;
            this.buttonsPanel.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageLinkCreatePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel buttonsPanel;
        private MetroFramework.Controls.MetroButton cancelButton;
        private MetroFramework.Controls.MetroButton okButton;
        private MetroFramework.Controls.MetroPanel mainPanel;
        private MetroFramework.Controls.MetroLabel executableCreateLabel;
        private MetroFramework.Controls.MetroTextBox executableTextBox;
        private MetroFramework.Controls.MetroLabel imageLinkCreateLabel;
        private MetroFramework.Controls.MetroTextBox imageLinkTextBox;
        private MetroFramework.Controls.MetroButton imageLinkCreateButton;
        private System.Windows.Forms.PictureBox imageLinkCreatePictureBox;
        private MetroFramework.Controls.MetroLabel infoCreateLabel;
        private MetroFramework.Controls.MetroTextBox infoCreateTextBox;
        private MetroFramework.Controls.MetroLabel versionCreateLabel;
        private MetroFramework.Controls.MetroTextBox versionTextBox;
        private MetroFramework.Controls.MetroLabel authorCreateLabel;
        private MetroFramework.Controls.MetroTextBox authorTextBox;
        private MetroFramework.Controls.MetroLabel descriptionCreateLabel;
        private MetroFramework.Controls.MetroTextBox descriptionTextBox;
        private MetroFramework.Controls.MetroLabel titleCreateLabel;
        private MetroFramework.Controls.MetroTextBox titleTextBox;
        private MetroFramework.Controls.MetroLabel gameFilesDirectoryCreateLabel;
        private MetroFramework.Controls.MetroTextBox gameFilesDirectoryTextBox;
        private MetroFramework.Controls.MetroCheckBox useImageCheckBox;
        private MetroFramework.Controls.MetroButton gameFilesDirectoryCreateButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    }
}