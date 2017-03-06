namespace AutoGamePatcher
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.openAGPFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.fileSystemWatcher = new System.IO.FileSystemWatcher();
            this.languagePanel = new MetroFramework.Controls.MetroPanel();
            this.languageComboBox = new MetroFramework.Controls.MetroComboBox();
            this.mainTabControl = new MetroFramework.Controls.MetroTabControl();
            this.gamePatchesTabPage = new MetroFramework.Controls.MetroTabPage();
            this.gamePatchesPanel = new MetroFramework.Controls.MetroPanel();
            this.patchGamePanel = new MetroFramework.Controls.MetroPanel();
            this.patchGameButton = new MetroFramework.Controls.MetroButton();
            this.importCreatePatchTabPage = new MetroFramework.Controls.MetroTabPage();
            this.createPatchPanel = new MetroFramework.Controls.MetroPanel();
            this.executableCreateLabel = new MetroFramework.Controls.MetroLabel();
            this.executableCreateTextBox = new MetroFramework.Controls.MetroTextBox();
            this.archiveNameCreateButton = new MetroFramework.Controls.MetroButton();
            this.archiveNameCreateLabel = new MetroFramework.Controls.MetroLabel();
            this.archiveNameCreateTextBox = new MetroFramework.Controls.MetroTextBox();
            this.imageLinkCreateLabel = new MetroFramework.Controls.MetroLabel();
            this.imageLinkCreateTextBox = new MetroFramework.Controls.MetroTextBox();
            this.imageLinkCreateButton = new MetroFramework.Controls.MetroButton();
            this.imageLinkCreatePictureBox = new System.Windows.Forms.PictureBox();
            this.infoCreateLabel = new MetroFramework.Controls.MetroLabel();
            this.infoCreateTextBox = new MetroFramework.Controls.MetroTextBox();
            this.versionCreateLabel = new MetroFramework.Controls.MetroLabel();
            this.versionCreateTextBox = new MetroFramework.Controls.MetroTextBox();
            this.authorCreateLabel = new MetroFramework.Controls.MetroLabel();
            this.authorCreateTextBox = new MetroFramework.Controls.MetroTextBox();
            this.descriptionCreateLabel = new MetroFramework.Controls.MetroLabel();
            this.descriptionCreateTextBox = new MetroFramework.Controls.MetroTextBox();
            this.titleCreateLabel = new MetroFramework.Controls.MetroLabel();
            this.titleCreateTextBox = new MetroFramework.Controls.MetroTextBox();
            this.gameFilesDirectoryCreateButton = new MetroFramework.Controls.MetroButton();
            this.gameFilesDirectoryCreateLabel = new MetroFramework.Controls.MetroLabel();
            this.gameFilesDirectoryCreateTextBox = new MetroFramework.Controls.MetroTextBox();
            this.createPatchButtonPanel = new MetroFramework.Controls.MetroPanel();
            this.createPatchButton = new MetroFramework.Controls.MetroButton();
            this.createPatchRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.importPatchPanel = new MetroFramework.Controls.MetroPanel();
            this.selectPatchFileButton = new MetroFramework.Controls.MetroButton();
            this.importPatchTextBox = new MetroFramework.Controls.MetroTextBox();
            this.importPatchLabel = new MetroFramework.Controls.MetroLabel();
            this.importPatchButtonPanel = new MetroFramework.Controls.MetroPanel();
            this.importPatchProgressBar = new MetroFramework.Controls.MetroProgressBar();
            this.importPatchButton = new MetroFramework.Controls.MetroButton();
            this.importPatchRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.settingsTabPage = new MetroFramework.Controls.MetroTabPage();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.appearanceSettingsTabPage = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.stylesComboBox = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.themesComboBox = new MetroFramework.Controls.MetroComboBox();
            this.docsTabPage = new MetroFramework.Controls.MetroTabPage();
            this.docsTabControl = new MetroFramework.Controls.MetroTabControl();
            this.patchesDocsTabPage = new MetroFramework.Controls.MetroTabPage();
            this.patchesDocsTabControl = new MetroFramework.Controls.MetroTabControl();
            this.importPatchDocsTabPage = new MetroFramework.Controls.MetroTabPage();
            this.importDocsWebBrowser = new System.Windows.Forms.WebBrowser();
            this.createPatchDocsTabPage = new MetroFramework.Controls.MetroTabPage();
            this.createDocsWebBrowser = new System.Windows.Forms.WebBrowser();
            this.shareDocsTabPage = new MetroFramework.Controls.MetroTabPage();
            this.shareDocsWebBrowser = new System.Windows.Forms.WebBrowser();
            this.settingsDocsTabPage = new MetroFramework.Controls.MetroTabPage();
            this.aboutTabPage = new MetroFramework.Controls.MetroTabPage();
            this.gitHubAboutLink = new MetroFramework.Controls.MetroLink();
            this.gitHubAboutPictureBox = new System.Windows.Forms.PictureBox();
            this.projectAboutLabel = new MetroFramework.Controls.MetroLabel();
            this.projectTitleAboutLabel = new MetroFramework.Controls.MetroLabel();
            this.translationsLabel = new MetroFramework.Controls.MetroLabel();
            this.translationsTitleLabel = new MetroFramework.Controls.MetroLabel();
            this.gplLinkAboutLink = new MetroFramework.Controls.MetroLink();
            this.developerAboutLabel = new MetroFramework.Controls.MetroLabel();
            this.developerTitleAboutLabel = new MetroFramework.Controls.MetroLabel();
            this.softwareAboutLabel = new MetroFramework.Controls.MetroLabel();
            this.softwareTitleAboutLabel4 = new MetroFramework.Controls.MetroLabel();
            this.versionAboutLabel = new MetroFramework.Controls.MetroLabel();
            this.softwareVersionAboutLabel = new MetroFramework.Controls.MetroLabel();
            this.saveAGPFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher)).BeginInit();
            this.languagePanel.SuspendLayout();
            this.mainTabControl.SuspendLayout();
            this.gamePatchesTabPage.SuspendLayout();
            this.patchGamePanel.SuspendLayout();
            this.importCreatePatchTabPage.SuspendLayout();
            this.createPatchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageLinkCreatePictureBox)).BeginInit();
            this.createPatchButtonPanel.SuspendLayout();
            this.importPatchPanel.SuspendLayout();
            this.importPatchButtonPanel.SuspendLayout();
            this.settingsTabPage.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.appearanceSettingsTabPage.SuspendLayout();
            this.docsTabPage.SuspendLayout();
            this.docsTabControl.SuspendLayout();
            this.patchesDocsTabPage.SuspendLayout();
            this.patchesDocsTabControl.SuspendLayout();
            this.importPatchDocsTabPage.SuspendLayout();
            this.createPatchDocsTabPage.SuspendLayout();
            this.shareDocsTabPage.SuspendLayout();
            this.settingsDocsTabPage.SuspendLayout();
            this.aboutTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gitHubAboutPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // openAGPFileDialog
            // 
            this.openAGPFileDialog.DefaultExt = "agp";
            this.openAGPFileDialog.Filter = "Auto game patcher files (*.agp)|*.agp";
            this.openAGPFileDialog.InitialDirectory = "Patches";
            // 
            // fileSystemWatcher
            // 
            this.fileSystemWatcher.EnableRaisingEvents = true;
            this.fileSystemWatcher.Filter = "*.agp";
            this.fileSystemWatcher.Path = "Patches";
            this.fileSystemWatcher.SynchronizingObject = this;
            this.fileSystemWatcher.Changed += new System.IO.FileSystemEventHandler(this.fileSystemWatcher_ChangedCreatedDeleted);
            this.fileSystemWatcher.Created += new System.IO.FileSystemEventHandler(this.fileSystemWatcher_ChangedCreatedDeleted);
            this.fileSystemWatcher.Deleted += new System.IO.FileSystemEventHandler(this.fileSystemWatcher_ChangedCreatedDeleted);
            this.fileSystemWatcher.Renamed += new System.IO.RenamedEventHandler(this.fileSystemWatcher_Renamed);
            // 
            // languagePanel
            // 
            this.languagePanel.Controls.Add(this.languageComboBox);
            this.languagePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.languagePanel.HorizontalScrollbarBarColor = true;
            this.languagePanel.HorizontalScrollbarHighlightOnWheel = false;
            this.languagePanel.HorizontalScrollbarSize = 10;
            this.languagePanel.Location = new System.Drawing.Point(20, 801);
            this.languagePanel.Name = "languagePanel";
            this.languagePanel.Size = new System.Drawing.Size(760, 29);
            this.languagePanel.TabIndex = 1;
            this.languagePanel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.languagePanel.VerticalScrollbarBarColor = true;
            this.languagePanel.VerticalScrollbarHighlightOnWheel = false;
            this.languagePanel.VerticalScrollbarSize = 10;
            // 
            // languageComboBox
            // 
            this.languageComboBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.languageComboBox.FormattingEnabled = true;
            this.languageComboBox.ItemHeight = 23;
            this.languageComboBox.Location = new System.Drawing.Point(555, 0);
            this.languageComboBox.Name = "languageComboBox";
            this.languageComboBox.PromptText = "{$SELECT_LANGUAGE$}";
            this.languageComboBox.Size = new System.Drawing.Size(205, 29);
            this.languageComboBox.TabIndex = 3;
            this.languageComboBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.languageComboBox.UseSelectable = true;
            this.languageComboBox.SelectedIndexChanged += new System.EventHandler(this.languageComboBox_SelectedIndexChanged);
            // 
            // mainTabControl
            // 
            this.mainTabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.mainTabControl.Controls.Add(this.gamePatchesTabPage);
            this.mainTabControl.Controls.Add(this.importCreatePatchTabPage);
            this.mainTabControl.Controls.Add(this.settingsTabPage);
            this.mainTabControl.Controls.Add(this.docsTabPage);
            this.mainTabControl.Controls.Add(this.aboutTabPage);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.FontSize = MetroFramework.MetroTabControlSize.Tall;
            this.mainTabControl.FontWeight = MetroFramework.MetroTabControlWeight.Regular;
            this.mainTabControl.Location = new System.Drawing.Point(20, 60);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(760, 741);
            this.mainTabControl.TabIndex = 2;
            this.mainTabControl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mainTabControl.UseSelectable = true;
            // 
            // gamePatchesTabPage
            // 
            this.gamePatchesTabPage.Controls.Add(this.gamePatchesPanel);
            this.gamePatchesTabPage.Controls.Add(this.patchGamePanel);
            this.gamePatchesTabPage.HorizontalScrollbarBarColor = true;
            this.gamePatchesTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.gamePatchesTabPage.HorizontalScrollbarSize = 10;
            this.gamePatchesTabPage.Location = new System.Drawing.Point(4, 47);
            this.gamePatchesTabPage.Name = "gamePatchesTabPage";
            this.gamePatchesTabPage.Size = new System.Drawing.Size(752, 690);
            this.gamePatchesTabPage.TabIndex = 0;
            this.gamePatchesTabPage.Text = "{$GAME_PATCHES$}";
            this.gamePatchesTabPage.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.gamePatchesTabPage.VerticalScrollbarBarColor = true;
            this.gamePatchesTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.gamePatchesTabPage.VerticalScrollbarSize = 10;
            // 
            // gamePatchesPanel
            // 
            this.gamePatchesPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gamePatchesPanel.AutoScroll = true;
            this.gamePatchesPanel.HorizontalScrollbar = true;
            this.gamePatchesPanel.HorizontalScrollbarBarColor = true;
            this.gamePatchesPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.gamePatchesPanel.HorizontalScrollbarSize = 10;
            this.gamePatchesPanel.Location = new System.Drawing.Point(0, 3);
            this.gamePatchesPanel.Name = "gamePatchesPanel";
            this.gamePatchesPanel.Size = new System.Drawing.Size(752, 631);
            this.gamePatchesPanel.TabIndex = 0;
            this.gamePatchesPanel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.gamePatchesPanel.VerticalScrollbar = true;
            this.gamePatchesPanel.VerticalScrollbarBarColor = true;
            this.gamePatchesPanel.VerticalScrollbarHighlightOnWheel = false;
            this.gamePatchesPanel.VerticalScrollbarSize = 10;
            this.gamePatchesPanel.Click += new System.EventHandler(this.gamePatchesPanel_Click);
            // 
            // patchGamePanel
            // 
            this.patchGamePanel.Controls.Add(this.patchGameButton);
            this.patchGamePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.patchGamePanel.HorizontalScrollbarBarColor = true;
            this.patchGamePanel.HorizontalScrollbarHighlightOnWheel = false;
            this.patchGamePanel.HorizontalScrollbarSize = 10;
            this.patchGamePanel.Location = new System.Drawing.Point(0, 640);
            this.patchGamePanel.Name = "patchGamePanel";
            this.patchGamePanel.Size = new System.Drawing.Size(752, 50);
            this.patchGamePanel.TabIndex = 1;
            this.patchGamePanel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.patchGamePanel.VerticalScrollbarBarColor = true;
            this.patchGamePanel.VerticalScrollbarHighlightOnWheel = false;
            this.patchGamePanel.VerticalScrollbarSize = 10;
            // 
            // patchGameButton
            // 
            this.patchGameButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.patchGameButton.Enabled = false;
            this.patchGameButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.patchGameButton.Location = new System.Drawing.Point(551, 0);
            this.patchGameButton.Name = "patchGameButton";
            this.patchGameButton.Size = new System.Drawing.Size(201, 50);
            this.patchGameButton.TabIndex = 0;
            this.patchGameButton.Text = "Patch && Run";
            this.patchGameButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.patchGameButton.UseSelectable = true;
            this.patchGameButton.Click += new System.EventHandler(this.patchGameButton_Click);
            // 
            // importCreatePatchTabPage
            // 
            this.importCreatePatchTabPage.Controls.Add(this.createPatchPanel);
            this.importCreatePatchTabPage.Controls.Add(this.createPatchRadioButton);
            this.importCreatePatchTabPage.Controls.Add(this.importPatchPanel);
            this.importCreatePatchTabPage.Controls.Add(this.importPatchRadioButton);
            this.importCreatePatchTabPage.HorizontalScrollbarBarColor = true;
            this.importCreatePatchTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.importCreatePatchTabPage.HorizontalScrollbarSize = 10;
            this.importCreatePatchTabPage.Location = new System.Drawing.Point(4, 47);
            this.importCreatePatchTabPage.Name = "importCreatePatchTabPage";
            this.importCreatePatchTabPage.Size = new System.Drawing.Size(752, 690);
            this.importCreatePatchTabPage.TabIndex = 1;
            this.importCreatePatchTabPage.Text = "{$IMPORT_CREATE_PATCH$}";
            this.importCreatePatchTabPage.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.importCreatePatchTabPage.VerticalScrollbarBarColor = true;
            this.importCreatePatchTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.importCreatePatchTabPage.VerticalScrollbarSize = 10;
            // 
            // createPatchPanel
            // 
            this.createPatchPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.createPatchPanel.Controls.Add(this.executableCreateLabel);
            this.createPatchPanel.Controls.Add(this.executableCreateTextBox);
            this.createPatchPanel.Controls.Add(this.archiveNameCreateButton);
            this.createPatchPanel.Controls.Add(this.archiveNameCreateLabel);
            this.createPatchPanel.Controls.Add(this.archiveNameCreateTextBox);
            this.createPatchPanel.Controls.Add(this.imageLinkCreateLabel);
            this.createPatchPanel.Controls.Add(this.imageLinkCreateTextBox);
            this.createPatchPanel.Controls.Add(this.imageLinkCreateButton);
            this.createPatchPanel.Controls.Add(this.imageLinkCreatePictureBox);
            this.createPatchPanel.Controls.Add(this.infoCreateLabel);
            this.createPatchPanel.Controls.Add(this.infoCreateTextBox);
            this.createPatchPanel.Controls.Add(this.versionCreateLabel);
            this.createPatchPanel.Controls.Add(this.versionCreateTextBox);
            this.createPatchPanel.Controls.Add(this.authorCreateLabel);
            this.createPatchPanel.Controls.Add(this.authorCreateTextBox);
            this.createPatchPanel.Controls.Add(this.descriptionCreateLabel);
            this.createPatchPanel.Controls.Add(this.descriptionCreateTextBox);
            this.createPatchPanel.Controls.Add(this.titleCreateLabel);
            this.createPatchPanel.Controls.Add(this.titleCreateTextBox);
            this.createPatchPanel.Controls.Add(this.gameFilesDirectoryCreateButton);
            this.createPatchPanel.Controls.Add(this.gameFilesDirectoryCreateLabel);
            this.createPatchPanel.Controls.Add(this.gameFilesDirectoryCreateTextBox);
            this.createPatchPanel.Controls.Add(this.createPatchButtonPanel);
            this.createPatchPanel.Enabled = false;
            this.createPatchPanel.HorizontalScrollbarBarColor = true;
            this.createPatchPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.createPatchPanel.HorizontalScrollbarSize = 10;
            this.createPatchPanel.Location = new System.Drawing.Point(0, 157);
            this.createPatchPanel.Name = "createPatchPanel";
            this.createPatchPanel.Size = new System.Drawing.Size(741, 530);
            this.createPatchPanel.TabIndex = 3;
            this.createPatchPanel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.createPatchPanel.VerticalScrollbarBarColor = true;
            this.createPatchPanel.VerticalScrollbarHighlightOnWheel = false;
            this.createPatchPanel.VerticalScrollbarSize = 10;
            // 
            // executableCreateLabel
            // 
            this.executableCreateLabel.AutoSize = true;
            this.executableCreateLabel.Location = new System.Drawing.Point(3, 36);
            this.executableCreateLabel.Name = "executableCreateLabel";
            this.executableCreateLabel.Size = new System.Drawing.Size(106, 19);
            this.executableCreateLabel.TabIndex = 3;
            this.executableCreateLabel.Text = "{$EXECUTABLE$}";
            this.executableCreateLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // executableCreateTextBox
            // 
            this.executableCreateTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.executableCreateTextBox.CustomButton.Image = null;
            this.executableCreateTextBox.CustomButton.Location = new System.Drawing.Point(583, 1);
            this.executableCreateTextBox.CustomButton.Name = "";
            this.executableCreateTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.executableCreateTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.executableCreateTextBox.CustomButton.TabIndex = 1;
            this.executableCreateTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.executableCreateTextBox.CustomButton.UseSelectable = true;
            this.executableCreateTextBox.CustomButton.Visible = false;
            this.executableCreateTextBox.Lines = new string[0];
            this.executableCreateTextBox.Location = new System.Drawing.Point(136, 32);
            this.executableCreateTextBox.MaxLength = 32767;
            this.executableCreateTextBox.Name = "executableCreateTextBox";
            this.executableCreateTextBox.PasswordChar = '\0';
            this.executableCreateTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.executableCreateTextBox.SelectedText = "";
            this.executableCreateTextBox.SelectionLength = 0;
            this.executableCreateTextBox.SelectionStart = 0;
            this.executableCreateTextBox.ShortcutsEnabled = true;
            this.executableCreateTextBox.Size = new System.Drawing.Size(605, 23);
            this.executableCreateTextBox.TabIndex = 4;
            this.executableCreateTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.executableCreateTextBox.UseSelectable = true;
            this.executableCreateTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.executableCreateTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // archiveNameCreateButton
            // 
            this.archiveNameCreateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.archiveNameCreateButton.Location = new System.Drawing.Point(711, 3);
            this.archiveNameCreateButton.Name = "archiveNameCreateButton";
            this.archiveNameCreateButton.Size = new System.Drawing.Size(30, 23);
            this.archiveNameCreateButton.TabIndex = 2;
            this.archiveNameCreateButton.Text = "...";
            this.archiveNameCreateButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.archiveNameCreateButton.UseSelectable = true;
            this.archiveNameCreateButton.Click += new System.EventHandler(this.archiveNameCreateButton_Click);
            // 
            // archiveNameCreateLabel
            // 
            this.archiveNameCreateLabel.AutoSize = true;
            this.archiveNameCreateLabel.Location = new System.Drawing.Point(3, 7);
            this.archiveNameCreateLabel.Name = "archiveNameCreateLabel";
            this.archiveNameCreateLabel.Size = new System.Drawing.Size(98, 19);
            this.archiveNameCreateLabel.TabIndex = 0;
            this.archiveNameCreateLabel.Text = "{$FILE_NAME$}";
            this.archiveNameCreateLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // archiveNameCreateTextBox
            // 
            this.archiveNameCreateTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.archiveNameCreateTextBox.CustomButton.Image = null;
            this.archiveNameCreateTextBox.CustomButton.Location = new System.Drawing.Point(547, 1);
            this.archiveNameCreateTextBox.CustomButton.Name = "";
            this.archiveNameCreateTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.archiveNameCreateTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.archiveNameCreateTextBox.CustomButton.TabIndex = 1;
            this.archiveNameCreateTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.archiveNameCreateTextBox.CustomButton.UseSelectable = true;
            this.archiveNameCreateTextBox.CustomButton.Visible = false;
            this.archiveNameCreateTextBox.Lines = new string[0];
            this.archiveNameCreateTextBox.Location = new System.Drawing.Point(136, 3);
            this.archiveNameCreateTextBox.MaxLength = 32767;
            this.archiveNameCreateTextBox.Name = "archiveNameCreateTextBox";
            this.archiveNameCreateTextBox.PasswordChar = '\0';
            this.archiveNameCreateTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.archiveNameCreateTextBox.SelectedText = "";
            this.archiveNameCreateTextBox.SelectionLength = 0;
            this.archiveNameCreateTextBox.SelectionStart = 0;
            this.archiveNameCreateTextBox.ShortcutsEnabled = true;
            this.archiveNameCreateTextBox.Size = new System.Drawing.Size(569, 23);
            this.archiveNameCreateTextBox.TabIndex = 1;
            this.archiveNameCreateTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.archiveNameCreateTextBox.UseSelectable = true;
            this.archiveNameCreateTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.archiveNameCreateTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // imageLinkCreateLabel
            // 
            this.imageLinkCreateLabel.AutoSize = true;
            this.imageLinkCreateLabel.Location = new System.Drawing.Point(3, 181);
            this.imageLinkCreateLabel.Name = "imageLinkCreateLabel";
            this.imageLinkCreateLabel.Size = new System.Drawing.Size(103, 19);
            this.imageLinkCreateLabel.TabIndex = 13;
            this.imageLinkCreateLabel.Text = "{$IMAGE_LINK$}";
            this.imageLinkCreateLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // imageLinkCreateTextBox
            // 
            this.imageLinkCreateTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.imageLinkCreateTextBox.CustomButton.Image = null;
            this.imageLinkCreateTextBox.CustomButton.Location = new System.Drawing.Point(371, 1);
            this.imageLinkCreateTextBox.CustomButton.Name = "";
            this.imageLinkCreateTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.imageLinkCreateTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.imageLinkCreateTextBox.CustomButton.TabIndex = 1;
            this.imageLinkCreateTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.imageLinkCreateTextBox.CustomButton.UseSelectable = true;
            this.imageLinkCreateTextBox.CustomButton.Visible = false;
            this.imageLinkCreateTextBox.Lines = new string[0];
            this.imageLinkCreateTextBox.Location = new System.Drawing.Point(136, 177);
            this.imageLinkCreateTextBox.MaxLength = 32767;
            this.imageLinkCreateTextBox.Name = "imageLinkCreateTextBox";
            this.imageLinkCreateTextBox.PasswordChar = '\0';
            this.imageLinkCreateTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.imageLinkCreateTextBox.SelectedText = "";
            this.imageLinkCreateTextBox.SelectionLength = 0;
            this.imageLinkCreateTextBox.SelectionStart = 0;
            this.imageLinkCreateTextBox.ShortcutsEnabled = true;
            this.imageLinkCreateTextBox.Size = new System.Drawing.Size(393, 23);
            this.imageLinkCreateTextBox.TabIndex = 14;
            this.imageLinkCreateTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.imageLinkCreateTextBox.UseSelectable = true;
            this.imageLinkCreateTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.imageLinkCreateTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // imageLinkCreateButton
            // 
            this.imageLinkCreateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imageLinkCreateButton.Location = new System.Drawing.Point(641, 177);
            this.imageLinkCreateButton.Name = "imageLinkCreateButton";
            this.imageLinkCreateButton.Size = new System.Drawing.Size(100, 50);
            this.imageLinkCreateButton.TabIndex = 15;
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
            this.imageLinkCreatePictureBox.Location = new System.Drawing.Point(535, 177);
            this.imageLinkCreatePictureBox.Name = "imageLinkCreatePictureBox";
            this.imageLinkCreatePictureBox.Size = new System.Drawing.Size(100, 50);
            this.imageLinkCreatePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageLinkCreatePictureBox.TabIndex = 17;
            this.imageLinkCreatePictureBox.TabStop = false;
            // 
            // infoCreateLabel
            // 
            this.infoCreateLabel.AutoSize = true;
            this.infoCreateLabel.Location = new System.Drawing.Point(3, 343);
            this.infoCreateLabel.Name = "infoCreateLabel";
            this.infoCreateLabel.Size = new System.Drawing.Size(144, 19);
            this.infoCreateLabel.TabIndex = 18;
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
            this.infoCreateTextBox.CustomButton.Location = new System.Drawing.Point(471, 1);
            this.infoCreateTextBox.CustomButton.Name = "";
            this.infoCreateTextBox.CustomButton.Size = new System.Drawing.Size(133, 133);
            this.infoCreateTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.infoCreateTextBox.CustomButton.TabIndex = 1;
            this.infoCreateTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.infoCreateTextBox.CustomButton.UseSelectable = true;
            this.infoCreateTextBox.CustomButton.Visible = false;
            this.infoCreateTextBox.Lines = new string[0];
            this.infoCreateTextBox.Location = new System.Drawing.Point(136, 339);
            this.infoCreateTextBox.MaxLength = 32767;
            this.infoCreateTextBox.Multiline = true;
            this.infoCreateTextBox.Name = "infoCreateTextBox";
            this.infoCreateTextBox.PasswordChar = '\0';
            this.infoCreateTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.infoCreateTextBox.SelectedText = "";
            this.infoCreateTextBox.SelectionLength = 0;
            this.infoCreateTextBox.SelectionStart = 0;
            this.infoCreateTextBox.ShortcutsEnabled = true;
            this.infoCreateTextBox.Size = new System.Drawing.Size(605, 135);
            this.infoCreateTextBox.TabIndex = 19;
            this.infoCreateTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.infoCreateTextBox.UseSelectable = true;
            this.infoCreateTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.infoCreateTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // versionCreateLabel
            // 
            this.versionCreateLabel.AutoSize = true;
            this.versionCreateLabel.Location = new System.Drawing.Point(3, 152);
            this.versionCreateLabel.Name = "versionCreateLabel";
            this.versionCreateLabel.Size = new System.Drawing.Size(85, 19);
            this.versionCreateLabel.TabIndex = 11;
            this.versionCreateLabel.Text = "{$VERSION$}";
            this.versionCreateLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // versionCreateTextBox
            // 
            this.versionCreateTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.versionCreateTextBox.CustomButton.Image = null;
            this.versionCreateTextBox.CustomButton.Location = new System.Drawing.Point(583, 1);
            this.versionCreateTextBox.CustomButton.Name = "";
            this.versionCreateTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.versionCreateTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.versionCreateTextBox.CustomButton.TabIndex = 1;
            this.versionCreateTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.versionCreateTextBox.CustomButton.UseSelectable = true;
            this.versionCreateTextBox.CustomButton.Visible = false;
            this.versionCreateTextBox.Lines = new string[] {
        "1.0.0.0"};
            this.versionCreateTextBox.Location = new System.Drawing.Point(136, 148);
            this.versionCreateTextBox.MaxLength = 32767;
            this.versionCreateTextBox.Name = "versionCreateTextBox";
            this.versionCreateTextBox.PasswordChar = '\0';
            this.versionCreateTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.versionCreateTextBox.SelectedText = "";
            this.versionCreateTextBox.SelectionLength = 0;
            this.versionCreateTextBox.SelectionStart = 0;
            this.versionCreateTextBox.ShortcutsEnabled = true;
            this.versionCreateTextBox.Size = new System.Drawing.Size(605, 23);
            this.versionCreateTextBox.TabIndex = 12;
            this.versionCreateTextBox.Text = "1.0.0.0";
            this.versionCreateTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.versionCreateTextBox.UseSelectable = true;
            this.versionCreateTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.versionCreateTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // authorCreateLabel
            // 
            this.authorCreateLabel.AutoSize = true;
            this.authorCreateLabel.Location = new System.Drawing.Point(3, 123);
            this.authorCreateLabel.Name = "authorCreateLabel";
            this.authorCreateLabel.Size = new System.Drawing.Size(84, 19);
            this.authorCreateLabel.TabIndex = 9;
            this.authorCreateLabel.Text = "{$AUTHOR$}";
            this.authorCreateLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // authorCreateTextBox
            // 
            this.authorCreateTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.authorCreateTextBox.CustomButton.Image = null;
            this.authorCreateTextBox.CustomButton.Location = new System.Drawing.Point(583, 1);
            this.authorCreateTextBox.CustomButton.Name = "";
            this.authorCreateTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.authorCreateTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.authorCreateTextBox.CustomButton.TabIndex = 1;
            this.authorCreateTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.authorCreateTextBox.CustomButton.UseSelectable = true;
            this.authorCreateTextBox.CustomButton.Visible = false;
            this.authorCreateTextBox.Lines = new string[0];
            this.authorCreateTextBox.Location = new System.Drawing.Point(136, 119);
            this.authorCreateTextBox.MaxLength = 32767;
            this.authorCreateTextBox.Name = "authorCreateTextBox";
            this.authorCreateTextBox.PasswordChar = '\0';
            this.authorCreateTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.authorCreateTextBox.SelectedText = "";
            this.authorCreateTextBox.SelectionLength = 0;
            this.authorCreateTextBox.SelectionStart = 0;
            this.authorCreateTextBox.ShortcutsEnabled = true;
            this.authorCreateTextBox.Size = new System.Drawing.Size(605, 23);
            this.authorCreateTextBox.TabIndex = 10;
            this.authorCreateTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.authorCreateTextBox.UseSelectable = true;
            this.authorCreateTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.authorCreateTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // descriptionCreateLabel
            // 
            this.descriptionCreateLabel.AutoSize = true;
            this.descriptionCreateLabel.Location = new System.Drawing.Point(3, 237);
            this.descriptionCreateLabel.Name = "descriptionCreateLabel";
            this.descriptionCreateLabel.Size = new System.Drawing.Size(113, 19);
            this.descriptionCreateLabel.TabIndex = 16;
            this.descriptionCreateLabel.Text = "{$DESCRIPTION$}";
            this.descriptionCreateLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // descriptionCreateTextBox
            // 
            this.descriptionCreateTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.descriptionCreateTextBox.CustomButton.Image = null;
            this.descriptionCreateTextBox.CustomButton.Location = new System.Drawing.Point(507, 2);
            this.descriptionCreateTextBox.CustomButton.Name = "";
            this.descriptionCreateTextBox.CustomButton.Size = new System.Drawing.Size(95, 95);
            this.descriptionCreateTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.descriptionCreateTextBox.CustomButton.TabIndex = 1;
            this.descriptionCreateTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.descriptionCreateTextBox.CustomButton.UseSelectable = true;
            this.descriptionCreateTextBox.CustomButton.Visible = false;
            this.descriptionCreateTextBox.Lines = new string[0];
            this.descriptionCreateTextBox.Location = new System.Drawing.Point(136, 233);
            this.descriptionCreateTextBox.MaxLength = 32767;
            this.descriptionCreateTextBox.Multiline = true;
            this.descriptionCreateTextBox.Name = "descriptionCreateTextBox";
            this.descriptionCreateTextBox.PasswordChar = '\0';
            this.descriptionCreateTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.descriptionCreateTextBox.SelectedText = "";
            this.descriptionCreateTextBox.SelectionLength = 0;
            this.descriptionCreateTextBox.SelectionStart = 0;
            this.descriptionCreateTextBox.ShortcutsEnabled = true;
            this.descriptionCreateTextBox.Size = new System.Drawing.Size(605, 100);
            this.descriptionCreateTextBox.TabIndex = 17;
            this.descriptionCreateTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.descriptionCreateTextBox.UseSelectable = true;
            this.descriptionCreateTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.descriptionCreateTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // titleCreateLabel
            // 
            this.titleCreateLabel.AutoSize = true;
            this.titleCreateLabel.Location = new System.Drawing.Point(3, 94);
            this.titleCreateLabel.Name = "titleCreateLabel";
            this.titleCreateLabel.Size = new System.Drawing.Size(61, 19);
            this.titleCreateLabel.TabIndex = 7;
            this.titleCreateLabel.Text = "{$TITLE$}";
            this.titleCreateLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // titleCreateTextBox
            // 
            this.titleCreateTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.titleCreateTextBox.CustomButton.Image = null;
            this.titleCreateTextBox.CustomButton.Location = new System.Drawing.Point(583, 1);
            this.titleCreateTextBox.CustomButton.Name = "";
            this.titleCreateTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.titleCreateTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.titleCreateTextBox.CustomButton.TabIndex = 1;
            this.titleCreateTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.titleCreateTextBox.CustomButton.UseSelectable = true;
            this.titleCreateTextBox.CustomButton.Visible = false;
            this.titleCreateTextBox.Lines = new string[0];
            this.titleCreateTextBox.Location = new System.Drawing.Point(136, 90);
            this.titleCreateTextBox.MaxLength = 32767;
            this.titleCreateTextBox.Name = "titleCreateTextBox";
            this.titleCreateTextBox.PasswordChar = '\0';
            this.titleCreateTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.titleCreateTextBox.SelectedText = "";
            this.titleCreateTextBox.SelectionLength = 0;
            this.titleCreateTextBox.SelectionStart = 0;
            this.titleCreateTextBox.ShortcutsEnabled = true;
            this.titleCreateTextBox.Size = new System.Drawing.Size(605, 23);
            this.titleCreateTextBox.TabIndex = 8;
            this.titleCreateTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.titleCreateTextBox.UseSelectable = true;
            this.titleCreateTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.titleCreateTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // gameFilesDirectoryCreateButton
            // 
            this.gameFilesDirectoryCreateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gameFilesDirectoryCreateButton.Location = new System.Drawing.Point(711, 61);
            this.gameFilesDirectoryCreateButton.Name = "gameFilesDirectoryCreateButton";
            this.gameFilesDirectoryCreateButton.Size = new System.Drawing.Size(30, 23);
            this.gameFilesDirectoryCreateButton.TabIndex = 7;
            this.gameFilesDirectoryCreateButton.Text = "...";
            this.gameFilesDirectoryCreateButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.gameFilesDirectoryCreateButton.UseSelectable = true;
            this.gameFilesDirectoryCreateButton.Click += new System.EventHandler(this.gameFilesDirectoryCreateButton_Click);
            // 
            // gameFilesDirectoryCreateLabel
            // 
            this.gameFilesDirectoryCreateLabel.AutoSize = true;
            this.gameFilesDirectoryCreateLabel.Location = new System.Drawing.Point(3, 65);
            this.gameFilesDirectoryCreateLabel.Name = "gameFilesDirectoryCreateLabel";
            this.gameFilesDirectoryCreateLabel.Size = new System.Drawing.Size(179, 19);
            this.gameFilesDirectoryCreateLabel.TabIndex = 5;
            this.gameFilesDirectoryCreateLabel.Text = "{$GAME_FILES_DIRECTORY$}";
            this.gameFilesDirectoryCreateLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // gameFilesDirectoryCreateTextBox
            // 
            this.gameFilesDirectoryCreateTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.gameFilesDirectoryCreateTextBox.CustomButton.Image = null;
            this.gameFilesDirectoryCreateTextBox.CustomButton.Location = new System.Drawing.Point(547, 1);
            this.gameFilesDirectoryCreateTextBox.CustomButton.Name = "";
            this.gameFilesDirectoryCreateTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.gameFilesDirectoryCreateTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.gameFilesDirectoryCreateTextBox.CustomButton.TabIndex = 1;
            this.gameFilesDirectoryCreateTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.gameFilesDirectoryCreateTextBox.CustomButton.UseSelectable = true;
            this.gameFilesDirectoryCreateTextBox.CustomButton.Visible = false;
            this.gameFilesDirectoryCreateTextBox.Lines = new string[0];
            this.gameFilesDirectoryCreateTextBox.Location = new System.Drawing.Point(136, 61);
            this.gameFilesDirectoryCreateTextBox.MaxLength = 32767;
            this.gameFilesDirectoryCreateTextBox.Name = "gameFilesDirectoryCreateTextBox";
            this.gameFilesDirectoryCreateTextBox.PasswordChar = '\0';
            this.gameFilesDirectoryCreateTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.gameFilesDirectoryCreateTextBox.SelectedText = "";
            this.gameFilesDirectoryCreateTextBox.SelectionLength = 0;
            this.gameFilesDirectoryCreateTextBox.SelectionStart = 0;
            this.gameFilesDirectoryCreateTextBox.ShortcutsEnabled = true;
            this.gameFilesDirectoryCreateTextBox.Size = new System.Drawing.Size(569, 23);
            this.gameFilesDirectoryCreateTextBox.TabIndex = 6;
            this.gameFilesDirectoryCreateTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.gameFilesDirectoryCreateTextBox.UseSelectable = true;
            this.gameFilesDirectoryCreateTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.gameFilesDirectoryCreateTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // createPatchButtonPanel
            // 
            this.createPatchButtonPanel.Controls.Add(this.createPatchButton);
            this.createPatchButtonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.createPatchButtonPanel.HorizontalScrollbarBarColor = true;
            this.createPatchButtonPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.createPatchButtonPanel.HorizontalScrollbarSize = 10;
            this.createPatchButtonPanel.Location = new System.Drawing.Point(0, 480);
            this.createPatchButtonPanel.Name = "createPatchButtonPanel";
            this.createPatchButtonPanel.Size = new System.Drawing.Size(741, 50);
            this.createPatchButtonPanel.TabIndex = 20;
            this.createPatchButtonPanel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.createPatchButtonPanel.VerticalScrollbarBarColor = true;
            this.createPatchButtonPanel.VerticalScrollbarHighlightOnWheel = false;
            this.createPatchButtonPanel.VerticalScrollbarSize = 10;
            // 
            // createPatchButton
            // 
            this.createPatchButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.createPatchButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.createPatchButton.Location = new System.Drawing.Point(541, 0);
            this.createPatchButton.Name = "createPatchButton";
            this.createPatchButton.Size = new System.Drawing.Size(200, 50);
            this.createPatchButton.TabIndex = 0;
            this.createPatchButton.Text = "{$CREATE_PATCH$}";
            this.createPatchButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.createPatchButton.UseSelectable = true;
            this.createPatchButton.Click += new System.EventHandler(this.createPatchButton_Click);
            // 
            // createPatchRadioButton
            // 
            this.createPatchRadioButton.AutoSize = true;
            this.createPatchRadioButton.Location = new System.Drawing.Point(0, 136);
            this.createPatchRadioButton.Name = "createPatchRadioButton";
            this.createPatchRadioButton.Size = new System.Drawing.Size(125, 15);
            this.createPatchRadioButton.TabIndex = 2;
            this.createPatchRadioButton.Text = "{$CREATE_PATCH$}";
            this.createPatchRadioButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.createPatchRadioButton.UseSelectable = true;
            this.createPatchRadioButton.CheckedChanged += new System.EventHandler(this.importCreatePatchRadioButton_CheckedChanged);
            // 
            // importPatchPanel
            // 
            this.importPatchPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.importPatchPanel.Controls.Add(this.selectPatchFileButton);
            this.importPatchPanel.Controls.Add(this.importPatchTextBox);
            this.importPatchPanel.Controls.Add(this.importPatchLabel);
            this.importPatchPanel.Controls.Add(this.importPatchButtonPanel);
            this.importPatchPanel.HorizontalScrollbarBarColor = true;
            this.importPatchPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.importPatchPanel.HorizontalScrollbarSize = 10;
            this.importPatchPanel.Location = new System.Drawing.Point(0, 24);
            this.importPatchPanel.Name = "importPatchPanel";
            this.importPatchPanel.Size = new System.Drawing.Size(741, 106);
            this.importPatchPanel.TabIndex = 1;
            this.importPatchPanel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.importPatchPanel.VerticalScrollbarBarColor = true;
            this.importPatchPanel.VerticalScrollbarHighlightOnWheel = false;
            this.importPatchPanel.VerticalScrollbarSize = 10;
            // 
            // selectPatchFileButton
            // 
            this.selectPatchFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectPatchFileButton.Location = new System.Drawing.Point(711, 27);
            this.selectPatchFileButton.Name = "selectPatchFileButton";
            this.selectPatchFileButton.Size = new System.Drawing.Size(30, 23);
            this.selectPatchFileButton.TabIndex = 2;
            this.selectPatchFileButton.Text = "...";
            this.selectPatchFileButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.selectPatchFileButton.UseSelectable = true;
            this.selectPatchFileButton.Click += new System.EventHandler(this.selectPatchFileButton_Click);
            // 
            // importPatchTextBox
            // 
            this.importPatchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.importPatchTextBox.CustomButton.Image = null;
            this.importPatchTextBox.CustomButton.Location = new System.Drawing.Point(680, 1);
            this.importPatchTextBox.CustomButton.Name = "";
            this.importPatchTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.importPatchTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.importPatchTextBox.CustomButton.TabIndex = 1;
            this.importPatchTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.importPatchTextBox.CustomButton.UseSelectable = true;
            this.importPatchTextBox.CustomButton.Visible = false;
            this.importPatchTextBox.Lines = new string[0];
            this.importPatchTextBox.Location = new System.Drawing.Point(3, 27);
            this.importPatchTextBox.MaxLength = 32767;
            this.importPatchTextBox.Name = "importPatchTextBox";
            this.importPatchTextBox.PasswordChar = '\0';
            this.importPatchTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.importPatchTextBox.SelectedText = "";
            this.importPatchTextBox.SelectionLength = 0;
            this.importPatchTextBox.SelectionStart = 0;
            this.importPatchTextBox.ShortcutsEnabled = true;
            this.importPatchTextBox.Size = new System.Drawing.Size(702, 23);
            this.importPatchTextBox.TabIndex = 1;
            this.importPatchTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.importPatchTextBox.UseSelectable = true;
            this.importPatchTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.importPatchTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // importPatchLabel
            // 
            this.importPatchLabel.AutoSize = true;
            this.importPatchLabel.Location = new System.Drawing.Point(3, 5);
            this.importPatchLabel.Name = "importPatchLabel";
            this.importPatchLabel.Size = new System.Drawing.Size(152, 19);
            this.importPatchLabel.TabIndex = 0;
            this.importPatchLabel.Text = "{$SELECT_TO_IMPORT$}";
            this.importPatchLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // importPatchButtonPanel
            // 
            this.importPatchButtonPanel.Controls.Add(this.importPatchProgressBar);
            this.importPatchButtonPanel.Controls.Add(this.importPatchButton);
            this.importPatchButtonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.importPatchButtonPanel.HorizontalScrollbarBarColor = true;
            this.importPatchButtonPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.importPatchButtonPanel.HorizontalScrollbarSize = 10;
            this.importPatchButtonPanel.Location = new System.Drawing.Point(0, 56);
            this.importPatchButtonPanel.Name = "importPatchButtonPanel";
            this.importPatchButtonPanel.Size = new System.Drawing.Size(741, 50);
            this.importPatchButtonPanel.TabIndex = 3;
            this.importPatchButtonPanel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.importPatchButtonPanel.VerticalScrollbarBarColor = true;
            this.importPatchButtonPanel.VerticalScrollbarHighlightOnWheel = false;
            this.importPatchButtonPanel.VerticalScrollbarSize = 10;
            // 
            // importPatchProgressBar
            // 
            this.importPatchProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.importPatchProgressBar.Location = new System.Drawing.Point(3, 13);
            this.importPatchProgressBar.Name = "importPatchProgressBar";
            this.importPatchProgressBar.Size = new System.Drawing.Size(532, 23);
            this.importPatchProgressBar.Step = 1;
            this.importPatchProgressBar.TabIndex = 2;
            this.importPatchProgressBar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.importPatchProgressBar.Visible = false;
            // 
            // importPatchButton
            // 
            this.importPatchButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.importPatchButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.importPatchButton.Location = new System.Drawing.Point(541, 0);
            this.importPatchButton.Name = "importPatchButton";
            this.importPatchButton.Size = new System.Drawing.Size(200, 50);
            this.importPatchButton.TabIndex = 0;
            this.importPatchButton.Text = "{$IMPORT_PATCH$}";
            this.importPatchButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.importPatchButton.UseSelectable = true;
            this.importPatchButton.Click += new System.EventHandler(this.importPatchButton_Click);
            // 
            // importPatchRadioButton
            // 
            this.importPatchRadioButton.AutoSize = true;
            this.importPatchRadioButton.Checked = true;
            this.importPatchRadioButton.Location = new System.Drawing.Point(0, 3);
            this.importPatchRadioButton.Name = "importPatchRadioButton";
            this.importPatchRadioButton.Size = new System.Drawing.Size(127, 15);
            this.importPatchRadioButton.TabIndex = 0;
            this.importPatchRadioButton.TabStop = true;
            this.importPatchRadioButton.Text = "{$IMPORT_PATCH$}";
            this.importPatchRadioButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.importPatchRadioButton.UseSelectable = true;
            this.importPatchRadioButton.CheckedChanged += new System.EventHandler(this.importCreatePatchRadioButton_CheckedChanged);
            // 
            // settingsTabPage
            // 
            this.settingsTabPage.Controls.Add(this.metroTabControl1);
            this.settingsTabPage.HorizontalScrollbarBarColor = true;
            this.settingsTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.settingsTabPage.HorizontalScrollbarSize = 10;
            this.settingsTabPage.Location = new System.Drawing.Point(4, 47);
            this.settingsTabPage.Name = "settingsTabPage";
            this.settingsTabPage.Size = new System.Drawing.Size(752, 690);
            this.settingsTabPage.TabIndex = 2;
            this.settingsTabPage.Text = "{$SETTINGS$}";
            this.settingsTabPage.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.settingsTabPage.VerticalScrollbarBarColor = true;
            this.settingsTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.settingsTabPage.VerticalScrollbarSize = 10;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.appearanceSettingsTabPage);
            this.metroTabControl1.Location = new System.Drawing.Point(-4, 3);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(749, 724);
            this.metroTabControl1.TabIndex = 2;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabControl1.UseSelectable = true;
            // 
            // appearanceSettingsTabPage
            // 
            this.appearanceSettingsTabPage.Controls.Add(this.metroLabel2);
            this.appearanceSettingsTabPage.Controls.Add(this.stylesComboBox);
            this.appearanceSettingsTabPage.Controls.Add(this.metroLabel1);
            this.appearanceSettingsTabPage.Controls.Add(this.themesComboBox);
            this.appearanceSettingsTabPage.HorizontalScrollbarBarColor = true;
            this.appearanceSettingsTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.appearanceSettingsTabPage.HorizontalScrollbarSize = 10;
            this.appearanceSettingsTabPage.Location = new System.Drawing.Point(4, 38);
            this.appearanceSettingsTabPage.Name = "appearanceSettingsTabPage";
            this.appearanceSettingsTabPage.Size = new System.Drawing.Size(741, 682);
            this.appearanceSettingsTabPage.TabIndex = 0;
            this.appearanceSettingsTabPage.Text = "{$APPEARANCE$}";
            this.appearanceSettingsTabPage.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.appearanceSettingsTabPage.VerticalScrollbarBarColor = true;
            this.appearanceSettingsTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.appearanceSettingsTabPage.VerticalScrollbarSize = 10;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(3, 48);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(73, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "{$STYLES$}";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // stylesComboBox
            // 
            this.stylesComboBox.FormattingEnabled = true;
            this.stylesComboBox.ItemHeight = 23;
            this.stylesComboBox.Location = new System.Drawing.Point(89, 38);
            this.stylesComboBox.Name = "stylesComboBox";
            this.stylesComboBox.PromptText = "{$SELECT_STYLE$}";
            this.stylesComboBox.Size = new System.Drawing.Size(652, 29);
            this.stylesComboBox.TabIndex = 4;
            this.stylesComboBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.stylesComboBox.UseSelectable = true;
            this.stylesComboBox.SelectedIndexChanged += new System.EventHandler(this.stylesComboBox_SelectedIndexChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 13);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(80, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "{$THEMES$}";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // themesComboBox
            // 
            this.themesComboBox.FormattingEnabled = true;
            this.themesComboBox.ItemHeight = 23;
            this.themesComboBox.Location = new System.Drawing.Point(89, 3);
            this.themesComboBox.Name = "themesComboBox";
            this.themesComboBox.PromptText = "{$SELECT_THEME$}";
            this.themesComboBox.Size = new System.Drawing.Size(652, 29);
            this.themesComboBox.TabIndex = 2;
            this.themesComboBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.themesComboBox.UseSelectable = true;
            this.themesComboBox.SelectedIndexChanged += new System.EventHandler(this.themesComboBox_SelectedIndexChanged);
            // 
            // docsTabPage
            // 
            this.docsTabPage.Controls.Add(this.docsTabControl);
            this.docsTabPage.HorizontalScrollbarBarColor = true;
            this.docsTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.docsTabPage.HorizontalScrollbarSize = 10;
            this.docsTabPage.Location = new System.Drawing.Point(4, 47);
            this.docsTabPage.Name = "docsTabPage";
            this.docsTabPage.Size = new System.Drawing.Size(752, 690);
            this.docsTabPage.TabIndex = 3;
            this.docsTabPage.Text = "{$DOCUMENTATION_AND_HELP$}";
            this.docsTabPage.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.docsTabPage.VerticalScrollbarBarColor = true;
            this.docsTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.docsTabPage.VerticalScrollbarSize = 10;
            // 
            // docsTabControl
            // 
            this.docsTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.docsTabControl.Controls.Add(this.patchesDocsTabPage);
            this.docsTabControl.Controls.Add(this.settingsDocsTabPage);
            this.docsTabControl.Location = new System.Drawing.Point(0, 3);
            this.docsTabControl.Name = "docsTabControl";
            this.docsTabControl.SelectedIndex = 0;
            this.docsTabControl.Size = new System.Drawing.Size(741, 731);
            this.docsTabControl.TabIndex = 3;
            this.docsTabControl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.docsTabControl.UseSelectable = true;
            // 
            // patchesDocsTabPage
            // 
            this.patchesDocsTabPage.Controls.Add(this.patchesDocsTabControl);
            this.patchesDocsTabPage.HorizontalScrollbarBarColor = true;
            this.patchesDocsTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.patchesDocsTabPage.HorizontalScrollbarSize = 10;
            this.patchesDocsTabPage.Location = new System.Drawing.Point(4, 38);
            this.patchesDocsTabPage.Name = "patchesDocsTabPage";
            this.patchesDocsTabPage.Size = new System.Drawing.Size(733, 689);
            this.patchesDocsTabPage.TabIndex = 0;
            this.patchesDocsTabPage.Text = "{$PATCHES$}";
            this.patchesDocsTabPage.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.patchesDocsTabPage.VerticalScrollbarBarColor = true;
            this.patchesDocsTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.patchesDocsTabPage.VerticalScrollbarSize = 10;
            // 
            // patchesDocsTabControl
            // 
            this.patchesDocsTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.patchesDocsTabControl.Controls.Add(this.importPatchDocsTabPage);
            this.patchesDocsTabControl.Controls.Add(this.createPatchDocsTabPage);
            this.patchesDocsTabControl.Controls.Add(this.shareDocsTabPage);
            this.patchesDocsTabControl.Location = new System.Drawing.Point(0, 3);
            this.patchesDocsTabControl.Name = "patchesDocsTabControl";
            this.patchesDocsTabControl.SelectedIndex = 0;
            this.patchesDocsTabControl.Size = new System.Drawing.Size(733, 697);
            this.patchesDocsTabControl.TabIndex = 4;
            this.patchesDocsTabControl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.patchesDocsTabControl.UseSelectable = true;
            // 
            // importPatchDocsTabPage
            // 
            this.importPatchDocsTabPage.Controls.Add(this.importDocsWebBrowser);
            this.importPatchDocsTabPage.HorizontalScrollbarBarColor = true;
            this.importPatchDocsTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.importPatchDocsTabPage.HorizontalScrollbarSize = 10;
            this.importPatchDocsTabPage.Location = new System.Drawing.Point(4, 38);
            this.importPatchDocsTabPage.Name = "importPatchDocsTabPage";
            this.importPatchDocsTabPage.Size = new System.Drawing.Size(725, 655);
            this.importPatchDocsTabPage.TabIndex = 0;
            this.importPatchDocsTabPage.Text = "{$HOW_TO_IMPORT$}";
            this.importPatchDocsTabPage.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.importPatchDocsTabPage.VerticalScrollbarBarColor = true;
            this.importPatchDocsTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.importPatchDocsTabPage.VerticalScrollbarSize = 10;
            // 
            // importDocsWebBrowser
            // 
            this.importDocsWebBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.importDocsWebBrowser.Location = new System.Drawing.Point(0, 3);
            this.importDocsWebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.importDocsWebBrowser.Name = "importDocsWebBrowser";
            this.importDocsWebBrowser.ScriptErrorsSuppressed = true;
            this.importDocsWebBrowser.Size = new System.Drawing.Size(725, 681);
            this.importDocsWebBrowser.TabIndex = 0;
            this.importDocsWebBrowser.Url = new System.Uri("http://bigeti.de/autogamepatcher/documentations/how-to-import.html", System.UriKind.Absolute);
            // 
            // createPatchDocsTabPage
            // 
            this.createPatchDocsTabPage.Controls.Add(this.createDocsWebBrowser);
            this.createPatchDocsTabPage.HorizontalScrollbarBarColor = true;
            this.createPatchDocsTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.createPatchDocsTabPage.HorizontalScrollbarSize = 10;
            this.createPatchDocsTabPage.Location = new System.Drawing.Point(4, 38);
            this.createPatchDocsTabPage.Name = "createPatchDocsTabPage";
            this.createPatchDocsTabPage.Size = new System.Drawing.Size(725, 655);
            this.createPatchDocsTabPage.TabIndex = 1;
            this.createPatchDocsTabPage.Text = "{$HOW_TO_CREATE$}";
            this.createPatchDocsTabPage.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.createPatchDocsTabPage.VerticalScrollbarBarColor = true;
            this.createPatchDocsTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.createPatchDocsTabPage.VerticalScrollbarSize = 10;
            // 
            // createDocsWebBrowser
            // 
            this.createDocsWebBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.createDocsWebBrowser.Location = new System.Drawing.Point(0, 3);
            this.createDocsWebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.createDocsWebBrowser.Name = "createDocsWebBrowser";
            this.createDocsWebBrowser.ScriptErrorsSuppressed = true;
            this.createDocsWebBrowser.Size = new System.Drawing.Size(725, 674);
            this.createDocsWebBrowser.TabIndex = 0;
            this.createDocsWebBrowser.Url = new System.Uri("http://bigeti.de/autogamepatcher/documentations/how-to-create.html", System.UriKind.Absolute);
            // 
            // shareDocsTabPage
            // 
            this.shareDocsTabPage.Controls.Add(this.shareDocsWebBrowser);
            this.shareDocsTabPage.HorizontalScrollbarBarColor = true;
            this.shareDocsTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.shareDocsTabPage.HorizontalScrollbarSize = 10;
            this.shareDocsTabPage.Location = new System.Drawing.Point(4, 38);
            this.shareDocsTabPage.Name = "shareDocsTabPage";
            this.shareDocsTabPage.Size = new System.Drawing.Size(725, 655);
            this.shareDocsTabPage.TabIndex = 2;
            this.shareDocsTabPage.Text = "{$HOW_TO_SHARE$}";
            this.shareDocsTabPage.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.shareDocsTabPage.VerticalScrollbarBarColor = true;
            this.shareDocsTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.shareDocsTabPage.VerticalScrollbarSize = 10;
            // 
            // shareDocsWebBrowser
            // 
            this.shareDocsWebBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.shareDocsWebBrowser.Location = new System.Drawing.Point(0, 3);
            this.shareDocsWebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.shareDocsWebBrowser.Name = "shareDocsWebBrowser";
            this.shareDocsWebBrowser.ScriptErrorsSuppressed = true;
            this.shareDocsWebBrowser.Size = new System.Drawing.Size(725, 642);
            this.shareDocsWebBrowser.TabIndex = 0;
            this.shareDocsWebBrowser.Url = new System.Uri("http://bigeti.de/autogamepatcher/documentations/how-to-share.html", System.UriKind.Absolute);
            // 
            // settingsDocsTabPage
            // 
            this.settingsDocsTabPage.Controls.Add(this.webBrowser1);
            this.settingsDocsTabPage.HorizontalScrollbarBarColor = true;
            this.settingsDocsTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.settingsDocsTabPage.HorizontalScrollbarSize = 10;
            this.settingsDocsTabPage.Location = new System.Drawing.Point(4, 38);
            this.settingsDocsTabPage.Name = "settingsDocsTabPage";
            this.settingsDocsTabPage.Size = new System.Drawing.Size(733, 689);
            this.settingsDocsTabPage.TabIndex = 1;
            this.settingsDocsTabPage.Text = "{$SETTINGS$}";
            this.settingsDocsTabPage.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.settingsDocsTabPage.VerticalScrollbarBarColor = true;
            this.settingsDocsTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.settingsDocsTabPage.VerticalScrollbarSize = 10;
            // 
            // aboutTabPage
            // 
            this.aboutTabPage.Controls.Add(this.gitHubAboutLink);
            this.aboutTabPage.Controls.Add(this.gitHubAboutPictureBox);
            this.aboutTabPage.Controls.Add(this.projectAboutLabel);
            this.aboutTabPage.Controls.Add(this.projectTitleAboutLabel);
            this.aboutTabPage.Controls.Add(this.translationsLabel);
            this.aboutTabPage.Controls.Add(this.translationsTitleLabel);
            this.aboutTabPage.Controls.Add(this.gplLinkAboutLink);
            this.aboutTabPage.Controls.Add(this.developerAboutLabel);
            this.aboutTabPage.Controls.Add(this.developerTitleAboutLabel);
            this.aboutTabPage.Controls.Add(this.softwareAboutLabel);
            this.aboutTabPage.Controls.Add(this.softwareTitleAboutLabel4);
            this.aboutTabPage.Controls.Add(this.versionAboutLabel);
            this.aboutTabPage.Controls.Add(this.softwareVersionAboutLabel);
            this.aboutTabPage.HorizontalScrollbarBarColor = true;
            this.aboutTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.aboutTabPage.HorizontalScrollbarSize = 10;
            this.aboutTabPage.Location = new System.Drawing.Point(4, 47);
            this.aboutTabPage.Name = "aboutTabPage";
            this.aboutTabPage.Size = new System.Drawing.Size(752, 690);
            this.aboutTabPage.TabIndex = 4;
            this.aboutTabPage.Text = "{$ABOUT$}";
            this.aboutTabPage.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.aboutTabPage.VerticalScrollbarBarColor = true;
            this.aboutTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.aboutTabPage.VerticalScrollbarSize = 10;
            // 
            // gitHubAboutLink
            // 
            this.gitHubAboutLink.AutoSize = true;
            this.gitHubAboutLink.Dock = System.Windows.Forms.DockStyle.Top;
            this.gitHubAboutLink.Location = new System.Drawing.Point(0, 365);
            this.gitHubAboutLink.Name = "gitHubAboutLink";
            this.gitHubAboutLink.Size = new System.Drawing.Size(752, 23);
            this.gitHubAboutLink.TabIndex = 12;
            this.gitHubAboutLink.Text = "https://github.com/BigETI/auto-game-patcher";
            this.gitHubAboutLink.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.gitHubAboutLink.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.gitHubAboutLink.UseSelectable = true;
            this.gitHubAboutLink.Click += new System.EventHandler(this.gitHubAboutLink_Click);
            // 
            // gitHubAboutPictureBox
            // 
            this.gitHubAboutPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.gitHubAboutPictureBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.gitHubAboutPictureBox.ErrorImage = null;
            this.gitHubAboutPictureBox.Image = global::AutoGamePatcher.Properties.Resources.GitHub;
            this.gitHubAboutPictureBox.InitialImage = global::AutoGamePatcher.Properties.Resources.GitHub;
            this.gitHubAboutPictureBox.Location = new System.Drawing.Point(0, 237);
            this.gitHubAboutPictureBox.MaximumSize = new System.Drawing.Size(128, 128);
            this.gitHubAboutPictureBox.MinimumSize = new System.Drawing.Size(128, 128);
            this.gitHubAboutPictureBox.Name = "gitHubAboutPictureBox";
            this.gitHubAboutPictureBox.Size = new System.Drawing.Size(128, 128);
            this.gitHubAboutPictureBox.TabIndex = 11;
            this.gitHubAboutPictureBox.TabStop = false;
            // 
            // projectAboutLabel
            // 
            this.projectAboutLabel.AutoSize = true;
            this.projectAboutLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.projectAboutLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.projectAboutLabel.Location = new System.Drawing.Point(0, 218);
            this.projectAboutLabel.Name = "projectAboutLabel";
            this.projectAboutLabel.Size = new System.Drawing.Size(174, 19);
            this.projectAboutLabel.TabIndex = 10;
            this.projectAboutLabel.Text = "{$ABOUT_PROJECT_TEXT$}";
            this.projectAboutLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // projectTitleAboutLabel
            // 
            this.projectTitleAboutLabel.AutoSize = true;
            this.projectTitleAboutLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.projectTitleAboutLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.projectTitleAboutLabel.Location = new System.Drawing.Point(0, 199);
            this.projectTitleAboutLabel.Name = "projectTitleAboutLabel";
            this.projectTitleAboutLabel.Size = new System.Drawing.Size(148, 19);
            this.projectTitleAboutLabel.TabIndex = 9;
            this.projectTitleAboutLabel.Text = "{$ABOUT_PROJECT$}";
            this.projectTitleAboutLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // translationsLabel
            // 
            this.translationsLabel.AutoSize = true;
            this.translationsLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.translationsLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.translationsLabel.Location = new System.Drawing.Point(0, 180);
            this.translationsLabel.Name = "translationsLabel";
            this.translationsLabel.Size = new System.Drawing.Size(214, 19);
            this.translationsLabel.TabIndex = 8;
            this.translationsLabel.Text = "{$ABOUT_TRANSLATIONS_TEXT$}";
            this.translationsLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // translationsTitleLabel
            // 
            this.translationsTitleLabel.AutoSize = true;
            this.translationsTitleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.translationsTitleLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.translationsTitleLabel.Location = new System.Drawing.Point(0, 161);
            this.translationsTitleLabel.Name = "translationsTitleLabel";
            this.translationsTitleLabel.Size = new System.Drawing.Size(193, 19);
            this.translationsTitleLabel.TabIndex = 7;
            this.translationsTitleLabel.Text = "{$ABOUT_TRANSLATIONS$}";
            this.translationsTitleLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // gplLinkAboutLink
            // 
            this.gplLinkAboutLink.AutoSize = true;
            this.gplLinkAboutLink.Dock = System.Windows.Forms.DockStyle.Top;
            this.gplLinkAboutLink.Location = new System.Drawing.Point(0, 133);
            this.gplLinkAboutLink.Name = "gplLinkAboutLink";
            this.gplLinkAboutLink.Size = new System.Drawing.Size(752, 28);
            this.gplLinkAboutLink.TabIndex = 6;
            this.gplLinkAboutLink.Text = "http://www.gnu.org/licenses/gpl-3.0.txt\r\n";
            this.gplLinkAboutLink.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.gplLinkAboutLink.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.gplLinkAboutLink.UseSelectable = true;
            this.gplLinkAboutLink.Click += new System.EventHandler(this.gplLinkAboutLink_Click);
            // 
            // developerAboutLabel
            // 
            this.developerAboutLabel.AutoSize = true;
            this.developerAboutLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.developerAboutLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.developerAboutLabel.Location = new System.Drawing.Point(0, 114);
            this.developerAboutLabel.Name = "developerAboutLabel";
            this.developerAboutLabel.Size = new System.Drawing.Size(330, 19);
            this.developerAboutLabel.TabIndex = 5;
            this.developerAboutLabel.Text = "{$ABOUT_DEVELOPER_AND_CONTRIBUTERS_TEXT$}";
            this.developerAboutLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // developerTitleAboutLabel
            // 
            this.developerTitleAboutLabel.AutoSize = true;
            this.developerTitleAboutLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.developerTitleAboutLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.developerTitleAboutLabel.Location = new System.Drawing.Point(0, 95);
            this.developerTitleAboutLabel.Name = "developerTitleAboutLabel";
            this.developerTitleAboutLabel.Size = new System.Drawing.Size(311, 19);
            this.developerTitleAboutLabel.TabIndex = 4;
            this.developerTitleAboutLabel.Text = "{$ABOUT_DEVELOPER_AND_CONTRIBUTERS$}";
            this.developerTitleAboutLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // softwareAboutLabel
            // 
            this.softwareAboutLabel.AutoSize = true;
            this.softwareAboutLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.softwareAboutLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.softwareAboutLabel.Location = new System.Drawing.Point(0, 76);
            this.softwareAboutLabel.Name = "softwareAboutLabel";
            this.softwareAboutLabel.Size = new System.Drawing.Size(221, 19);
            this.softwareAboutLabel.TabIndex = 3;
            this.softwareAboutLabel.Text = "{$ABOUT_THIS_SOFTWARE_TEXT$}";
            this.softwareAboutLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // softwareTitleAboutLabel4
            // 
            this.softwareTitleAboutLabel4.AutoSize = true;
            this.softwareTitleAboutLabel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.softwareTitleAboutLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.softwareTitleAboutLabel4.Location = new System.Drawing.Point(0, 57);
            this.softwareTitleAboutLabel4.Name = "softwareTitleAboutLabel4";
            this.softwareTitleAboutLabel4.Size = new System.Drawing.Size(200, 19);
            this.softwareTitleAboutLabel4.TabIndex = 2;
            this.softwareTitleAboutLabel4.Text = "{$ABOUT_THIS_SOFTWARE$}";
            this.softwareTitleAboutLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // versionAboutLabel
            // 
            this.versionAboutLabel.AutoSize = true;
            this.versionAboutLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.versionAboutLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.versionAboutLabel.Location = new System.Drawing.Point(0, 19);
            this.versionAboutLabel.Name = "versionAboutLabel";
            this.versionAboutLabel.Size = new System.Drawing.Size(72, 38);
            this.versionAboutLabel.TabIndex = 1;
            this.versionAboutLabel.Text = "Undefined\r\n";
            this.versionAboutLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // softwareVersionAboutLabel
            // 
            this.softwareVersionAboutLabel.AutoSize = true;
            this.softwareVersionAboutLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.softwareVersionAboutLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.softwareVersionAboutLabel.Location = new System.Drawing.Point(0, 0);
            this.softwareVersionAboutLabel.Name = "softwareVersionAboutLabel";
            this.softwareVersionAboutLabel.Size = new System.Drawing.Size(305, 19);
            this.softwareVersionAboutLabel.TabIndex = 0;
            this.softwareVersionAboutLabel.Text = "{$ABOUT_AUTO_GAME_PATCHER_VERSION$}";
            this.softwareVersionAboutLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // saveAGPFileDialog
            // 
            this.saveAGPFileDialog.DefaultExt = "agp";
            this.saveAGPFileDialog.Filter = "Auto game patcher files (*.agp)|*.agp";
            this.saveAGPFileDialog.InitialDirectory = "Patches";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(0, 4);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(733, 642);
            this.webBrowser1.TabIndex = 2;
            this.webBrowser1.Url = new System.Uri("http://bigeti.de/autogamepatcher/documentations/settings.html", System.UriKind.Absolute);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 850);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.languagePanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "{$AUTO_GAME_PATCHER$}";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher)).EndInit();
            this.languagePanel.ResumeLayout(false);
            this.mainTabControl.ResumeLayout(false);
            this.gamePatchesTabPage.ResumeLayout(false);
            this.patchGamePanel.ResumeLayout(false);
            this.importCreatePatchTabPage.ResumeLayout(false);
            this.importCreatePatchTabPage.PerformLayout();
            this.createPatchPanel.ResumeLayout(false);
            this.createPatchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageLinkCreatePictureBox)).EndInit();
            this.createPatchButtonPanel.ResumeLayout(false);
            this.importPatchPanel.ResumeLayout(false);
            this.importPatchPanel.PerformLayout();
            this.importPatchButtonPanel.ResumeLayout(false);
            this.settingsTabPage.ResumeLayout(false);
            this.metroTabControl1.ResumeLayout(false);
            this.appearanceSettingsTabPage.ResumeLayout(false);
            this.appearanceSettingsTabPage.PerformLayout();
            this.docsTabPage.ResumeLayout(false);
            this.docsTabControl.ResumeLayout(false);
            this.patchesDocsTabPage.ResumeLayout(false);
            this.patchesDocsTabControl.ResumeLayout(false);
            this.importPatchDocsTabPage.ResumeLayout(false);
            this.createPatchDocsTabPage.ResumeLayout(false);
            this.shareDocsTabPage.ResumeLayout(false);
            this.settingsDocsTabPage.ResumeLayout(false);
            this.aboutTabPage.ResumeLayout(false);
            this.aboutTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gitHubAboutPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openAGPFileDialog;
        private System.IO.FileSystemWatcher fileSystemWatcher;
        private MetroFramework.Controls.MetroTabControl mainTabControl;
        private MetroFramework.Controls.MetroTabPage importCreatePatchTabPage;
        private MetroFramework.Controls.MetroPanel createPatchPanel;
        private MetroFramework.Controls.MetroLabel executableCreateLabel;
        private MetroFramework.Controls.MetroTextBox executableCreateTextBox;
        private MetroFramework.Controls.MetroButton archiveNameCreateButton;
        private MetroFramework.Controls.MetroLabel archiveNameCreateLabel;
        private MetroFramework.Controls.MetroTextBox archiveNameCreateTextBox;
        private MetroFramework.Controls.MetroLabel imageLinkCreateLabel;
        private MetroFramework.Controls.MetroTextBox imageLinkCreateTextBox;
        private MetroFramework.Controls.MetroButton imageLinkCreateButton;
        private System.Windows.Forms.PictureBox imageLinkCreatePictureBox;
        private MetroFramework.Controls.MetroLabel infoCreateLabel;
        private MetroFramework.Controls.MetroTextBox infoCreateTextBox;
        private MetroFramework.Controls.MetroLabel versionCreateLabel;
        private MetroFramework.Controls.MetroTextBox versionCreateTextBox;
        private MetroFramework.Controls.MetroLabel authorCreateLabel;
        private MetroFramework.Controls.MetroTextBox authorCreateTextBox;
        private MetroFramework.Controls.MetroLabel descriptionCreateLabel;
        private MetroFramework.Controls.MetroTextBox descriptionCreateTextBox;
        private MetroFramework.Controls.MetroLabel titleCreateLabel;
        private MetroFramework.Controls.MetroTextBox titleCreateTextBox;
        private MetroFramework.Controls.MetroButton gameFilesDirectoryCreateButton;
        private MetroFramework.Controls.MetroLabel gameFilesDirectoryCreateLabel;
        private MetroFramework.Controls.MetroTextBox gameFilesDirectoryCreateTextBox;
        private MetroFramework.Controls.MetroPanel createPatchButtonPanel;
        private MetroFramework.Controls.MetroButton createPatchButton;
        private MetroFramework.Controls.MetroRadioButton createPatchRadioButton;
        private MetroFramework.Controls.MetroPanel importPatchPanel;
        private MetroFramework.Controls.MetroButton selectPatchFileButton;
        private MetroFramework.Controls.MetroTextBox importPatchTextBox;
        private MetroFramework.Controls.MetroLabel importPatchLabel;
        private MetroFramework.Controls.MetroPanel importPatchButtonPanel;
        private MetroFramework.Controls.MetroProgressBar importPatchProgressBar;
        private MetroFramework.Controls.MetroButton importPatchButton;
        private MetroFramework.Controls.MetroRadioButton importPatchRadioButton;
        private MetroFramework.Controls.MetroTabPage gamePatchesTabPage;
        private MetroFramework.Controls.MetroPanel gamePatchesPanel;
        private MetroFramework.Controls.MetroPanel patchGamePanel;
        private MetroFramework.Controls.MetroButton patchGameButton;
        private MetroFramework.Controls.MetroTabPage docsTabPage;
        private MetroFramework.Controls.MetroTabControl docsTabControl;
        private MetroFramework.Controls.MetroTabPage patchesDocsTabPage;
        private MetroFramework.Controls.MetroTabControl patchesDocsTabControl;
        private MetroFramework.Controls.MetroTabPage importPatchDocsTabPage;
        private System.Windows.Forms.WebBrowser importDocsWebBrowser;
        private MetroFramework.Controls.MetroTabPage createPatchDocsTabPage;
        private System.Windows.Forms.WebBrowser createDocsWebBrowser;
        private MetroFramework.Controls.MetroTabPage shareDocsTabPage;
        private System.Windows.Forms.WebBrowser shareDocsWebBrowser;
        private MetroFramework.Controls.MetroTabPage settingsDocsTabPage;
        private MetroFramework.Controls.MetroTabPage settingsTabPage;
        private MetroFramework.Controls.MetroTabPage aboutTabPage;
        private MetroFramework.Controls.MetroPanel languagePanel;
        private MetroFramework.Controls.MetroComboBox languageComboBox;
        private System.Windows.Forms.SaveFileDialog saveAGPFileDialog;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage appearanceSettingsTabPage;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox stylesComboBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox themesComboBox;
        private MetroFramework.Controls.MetroLabel developerAboutLabel;
        private MetroFramework.Controls.MetroLabel developerTitleAboutLabel;
        private MetroFramework.Controls.MetroLabel softwareAboutLabel;
        private MetroFramework.Controls.MetroLabel softwareTitleAboutLabel4;
        private MetroFramework.Controls.MetroLabel versionAboutLabel;
        private MetroFramework.Controls.MetroLabel softwareVersionAboutLabel;
        private MetroFramework.Controls.MetroLabel translationsLabel;
        private MetroFramework.Controls.MetroLabel translationsTitleLabel;
        private MetroFramework.Controls.MetroLink gplLinkAboutLink;
        private MetroFramework.Controls.MetroLabel projectAboutLabel;
        private MetroFramework.Controls.MetroLabel projectTitleAboutLabel;
        private System.Windows.Forms.PictureBox gitHubAboutPictureBox;
        private MetroFramework.Controls.MetroLink gitHubAboutLink;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

