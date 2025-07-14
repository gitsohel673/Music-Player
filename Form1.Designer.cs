using System.Drawing;

namespace OnlineSongImplement
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bachThameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontStyleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.segoeUIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arialBlackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calibriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comicSansMSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.courierNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.georgiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.impactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lucidaConsoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.microsoftSansSerifToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tahomaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timesNewRomanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trebuchetMSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verdanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.weddingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wingdingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TrackTimer = new System.Windows.Forms.Timer(this.components);
            this.lblTimer = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addOnlineSongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteOnlineSong = new System.Windows.Forms.ToolStripMenuItem();
            this.treeViewFolders = new System.Windows.Forms.TreeView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.trackBarVolume = new System.Windows.Forms.TrackBar();
            this.lblTotalTime = new System.Windows.Forms.Label();
            this.SoundMeter = new System.Windows.Forms.Label();
            this.SongName = new System.Windows.Forms.Label();
            this.informationLabel = new System.Windows.Forms.Label();
            this.SearchSong = new System.Windows.Forms.TextBox();
            this.listViewSongs = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.metroProgressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.wavePanel = new System.Windows.Forms.Panel();
            this.BackPanel = new System.Windows.Forms.Panel();
            this.btnPrevious = new FontAwesome.Sharp.IconButton();
            this.btnNext = new FontAwesome.Sharp.IconButton();
            this.btnPlayPuse = new FontAwesome.Sharp.IconButton();
            this.metroContextMenu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.informationLabel2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.BackPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.thameToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1290, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.openToolStripMenuItem.Text = "&Open Song";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(186, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // thameToolStripMenuItem
            // 
            this.thameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bachThameToolStripMenuItem,
            this.fontStyleToolStripMenuItem});
            this.thameToolStripMenuItem.Name = "thameToolStripMenuItem";
            this.thameToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
            this.thameToolStripMenuItem.Text = "Thame";
            // 
            // bachThameToolStripMenuItem
            // 
            this.bachThameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.whiteToolStripMenuItem,
            this.orangeToolStripMenuItem,
            this.redToolStripMenuItem,
            this.blueToolStripMenuItem});
            this.bachThameToolStripMenuItem.Name = "bachThameToolStripMenuItem";
            this.bachThameToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bachThameToolStripMenuItem.Text = "Back Color";
            this.bachThameToolStripMenuItem.Click += new System.EventHandler(this.bachThameToolStripMenuItem_Click);
            // 
            // whiteToolStripMenuItem
            // 
            this.whiteToolStripMenuItem.Name = "whiteToolStripMenuItem";
            this.whiteToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.whiteToolStripMenuItem.Text = "White";
            this.whiteToolStripMenuItem.Click += new System.EventHandler(this.whiteToolStripMenuItem_Click);
            // 
            // orangeToolStripMenuItem
            // 
            this.orangeToolStripMenuItem.Name = "orangeToolStripMenuItem";
            this.orangeToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.orangeToolStripMenuItem.Text = "Orange";
            this.orangeToolStripMenuItem.Click += new System.EventHandler(this.orangeToolStripMenuItem_Click);
            // 
            // redToolStripMenuItem
            // 
            this.redToolStripMenuItem.Name = "redToolStripMenuItem";
            this.redToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.redToolStripMenuItem.Text = "Red";
            this.redToolStripMenuItem.Click += new System.EventHandler(this.redToolStripMenuItem_Click);
            // 
            // blueToolStripMenuItem
            // 
            this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            this.blueToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.blueToolStripMenuItem.Text = "Blue";
            this.blueToolStripMenuItem.Click += new System.EventHandler(this.blueToolStripMenuItem_Click);
            // 
            // fontStyleToolStripMenuItem
            // 
            this.fontStyleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.segoeUIToolStripMenuItem,
            this.arialToolStripMenuItem,
            this.arialBlackToolStripMenuItem,
            this.calibriToolStripMenuItem,
            this.comicSansMSToolStripMenuItem,
            this.courierNewToolStripMenuItem,
            this.georgiaToolStripMenuItem,
            this.impactToolStripMenuItem,
            this.lucidaConsoleToolStripMenuItem,
            this.microsoftSansSerifToolStripMenuItem,
            this.tahomaToolStripMenuItem,
            this.timesNewRomanToolStripMenuItem,
            this.trebuchetMSToolStripMenuItem,
            this.verdanaToolStripMenuItem,
            this.weddingsToolStripMenuItem,
            this.wingdingsToolStripMenuItem});
            this.fontStyleToolStripMenuItem.Name = "fontStyleToolStripMenuItem";
            this.fontStyleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fontStyleToolStripMenuItem.Text = "Font Style";
            // 
            // segoeUIToolStripMenuItem
            // 
            this.segoeUIToolStripMenuItem.Name = "segoeUIToolStripMenuItem";
            this.segoeUIToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.segoeUIToolStripMenuItem.Text = "Segoe UI";
            this.segoeUIToolStripMenuItem.Click += new System.EventHandler(this.segoeUIToolStripMenuItem_Click);
            // 
            // arialToolStripMenuItem
            // 
            this.arialToolStripMenuItem.Name = "arialToolStripMenuItem";
            this.arialToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.arialToolStripMenuItem.Text = "Arial";
            this.arialToolStripMenuItem.Click += new System.EventHandler(this.arialToolStripMenuItem_Click);
            // 
            // arialBlackToolStripMenuItem
            // 
            this.arialBlackToolStripMenuItem.Name = "arialBlackToolStripMenuItem";
            this.arialBlackToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.arialBlackToolStripMenuItem.Text = "Arial Black";
            this.arialBlackToolStripMenuItem.Click += new System.EventHandler(this.arialBlackToolStripMenuItem_Click);
            // 
            // calibriToolStripMenuItem
            // 
            this.calibriToolStripMenuItem.Name = "calibriToolStripMenuItem";
            this.calibriToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.calibriToolStripMenuItem.Text = "Calibri";
            this.calibriToolStripMenuItem.Click += new System.EventHandler(this.calibriToolStripMenuItem_Click);
            // 
            // comicSansMSToolStripMenuItem
            // 
            this.comicSansMSToolStripMenuItem.Name = "comicSansMSToolStripMenuItem";
            this.comicSansMSToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.comicSansMSToolStripMenuItem.Text = "Comic Sans MS";
            this.comicSansMSToolStripMenuItem.Click += new System.EventHandler(this.comicSansMSToolStripMenuItem_Click);
            // 
            // courierNewToolStripMenuItem
            // 
            this.courierNewToolStripMenuItem.Name = "courierNewToolStripMenuItem";
            this.courierNewToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.courierNewToolStripMenuItem.Text = "Courier New";
            this.courierNewToolStripMenuItem.Click += new System.EventHandler(this.courierNewToolStripMenuItem_Click);
            // 
            // georgiaToolStripMenuItem
            // 
            this.georgiaToolStripMenuItem.Name = "georgiaToolStripMenuItem";
            this.georgiaToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.georgiaToolStripMenuItem.Text = "Georgia";
            this.georgiaToolStripMenuItem.Click += new System.EventHandler(this.georgiaToolStripMenuItem_Click);
            // 
            // impactToolStripMenuItem
            // 
            this.impactToolStripMenuItem.Name = "impactToolStripMenuItem";
            this.impactToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.impactToolStripMenuItem.Text = "Impact";
            this.impactToolStripMenuItem.Click += new System.EventHandler(this.impactToolStripMenuItem_Click);
            // 
            // lucidaConsoleToolStripMenuItem
            // 
            this.lucidaConsoleToolStripMenuItem.Name = "lucidaConsoleToolStripMenuItem";
            this.lucidaConsoleToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.lucidaConsoleToolStripMenuItem.Text = "Lucida Console";
            this.lucidaConsoleToolStripMenuItem.Click += new System.EventHandler(this.lucidaConsoleToolStripMenuItem_Click);
            // 
            // microsoftSansSerifToolStripMenuItem
            // 
            this.microsoftSansSerifToolStripMenuItem.Name = "microsoftSansSerifToolStripMenuItem";
            this.microsoftSansSerifToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.microsoftSansSerifToolStripMenuItem.Text = "Microsoft Sans Serif";
            this.microsoftSansSerifToolStripMenuItem.Click += new System.EventHandler(this.microsoftSansSerifToolStripMenuItem_Click);
            // 
            // tahomaToolStripMenuItem
            // 
            this.tahomaToolStripMenuItem.Name = "tahomaToolStripMenuItem";
            this.tahomaToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.tahomaToolStripMenuItem.Text = "Tahoma";
            this.tahomaToolStripMenuItem.Click += new System.EventHandler(this.tahomaToolStripMenuItem_Click);
            // 
            // timesNewRomanToolStripMenuItem
            // 
            this.timesNewRomanToolStripMenuItem.Name = "timesNewRomanToolStripMenuItem";
            this.timesNewRomanToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.timesNewRomanToolStripMenuItem.Text = "Times New Roman";
            this.timesNewRomanToolStripMenuItem.Click += new System.EventHandler(this.timesNewRomanToolStripMenuItem_Click);
            // 
            // trebuchetMSToolStripMenuItem
            // 
            this.trebuchetMSToolStripMenuItem.Name = "trebuchetMSToolStripMenuItem";
            this.trebuchetMSToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.trebuchetMSToolStripMenuItem.Text = "Trebuchet MS";
            this.trebuchetMSToolStripMenuItem.Click += new System.EventHandler(this.trebuchetMSToolStripMenuItem_Click);
            // 
            // verdanaToolStripMenuItem
            // 
            this.verdanaToolStripMenuItem.Name = "verdanaToolStripMenuItem";
            this.verdanaToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.verdanaToolStripMenuItem.Text = "Verdana";
            this.verdanaToolStripMenuItem.Click += new System.EventHandler(this.verdanaToolStripMenuItem_Click);
            // 
            // weddingsToolStripMenuItem
            // 
            this.weddingsToolStripMenuItem.Name = "weddingsToolStripMenuItem";
            this.weddingsToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.weddingsToolStripMenuItem.Text = "Webdings";
            this.weddingsToolStripMenuItem.Click += new System.EventHandler(this.weddingsToolStripMenuItem_Click);
            // 
            // wingdingsToolStripMenuItem
            // 
            this.wingdingsToolStripMenuItem.Name = "wingdingsToolStripMenuItem";
            this.wingdingsToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.wingdingsToolStripMenuItem.Text = "Wingdings";
            this.wingdingsToolStripMenuItem.Click += new System.EventHandler(this.wingdingsToolStripMenuItem_Click);
            // 
            // TrackTimer
            // 
            this.TrackTimer.Tick += new System.EventHandler(this.TrackTimer_Tick_1);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(299, 90);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(0, 21);
            this.lblTimer.TabIndex = 7;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addOnlineSongToolStripMenuItem,
            this.DeleteOnlineSong});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(186, 48);
            // 
            // addOnlineSongToolStripMenuItem
            // 
            this.addOnlineSongToolStripMenuItem.Name = "addOnlineSongToolStripMenuItem";
            this.addOnlineSongToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.addOnlineSongToolStripMenuItem.Text = "Add online song";
            this.addOnlineSongToolStripMenuItem.Click += new System.EventHandler(this.addOnlineSongToolStripMenuItem_Click);
            // 
            // DeleteOnlineSong
            // 
            this.DeleteOnlineSong.Name = "DeleteOnlineSong";
            this.DeleteOnlineSong.Size = new System.Drawing.Size(185, 22);
            this.DeleteOnlineSong.Text = "Delete online song";
            this.DeleteOnlineSong.Click += new System.EventHandler(this.DeleteOnlineSong_Click);
            // 
            // treeViewFolders
            // 
            this.treeViewFolders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeViewFolders.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeViewFolders.Location = new System.Drawing.Point(0, 0);
            this.treeViewFolders.Name = "treeViewFolders";
            this.treeViewFolders.Size = new System.Drawing.Size(264, 492);
            this.treeViewFolders.TabIndex = 18;
            this.treeViewFolders.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.treeViewFolders_ItemDrag);
            this.treeViewFolders.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewFolders_AfterSelect);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(12, 32);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(27, 27);
            this.toolStrip1.TabIndex = 19;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.ToolTipText = "folder";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // trackBarVolume
            // 
            this.trackBarVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarVolume.BackColor = System.Drawing.Color.White;
            this.trackBarVolume.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBarVolume.Location = new System.Drawing.Point(1203, 272);
            this.trackBarVolume.Name = "trackBarVolume";
            this.trackBarVolume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarVolume.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBarVolume.Size = new System.Drawing.Size(45, 275);
            this.trackBarVolume.TabIndex = 6;
            this.trackBarVolume.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarVolume.Scroll += new System.EventHandler(this.trackBarVolume_Scroll);
            // 
            // lblTotalTime
            // 
            this.lblTotalTime.AutoSize = true;
            this.lblTotalTime.Location = new System.Drawing.Point(1117, 138);
            this.lblTotalTime.Name = "lblTotalTime";
            this.lblTotalTime.Size = new System.Drawing.Size(0, 13);
            this.lblTotalTime.TabIndex = 8;
            // 
            // SoundMeter
            // 
            this.SoundMeter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SoundMeter.AutoSize = true;
            this.SoundMeter.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoundMeter.Location = new System.Drawing.Point(1212, 240);
            this.SoundMeter.Name = "SoundMeter";
            this.SoundMeter.Size = new System.Drawing.Size(0, 20);
            this.SoundMeter.TabIndex = 10;
            // 
            // SongName
            // 
            this.SongName.AutoSize = true;
            this.SongName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SongName.Location = new System.Drawing.Point(292, 133);
            this.SongName.Name = "SongName";
            this.SongName.Size = new System.Drawing.Size(0, 21);
            this.SongName.TabIndex = 11;
            // 
            // informationLabel
            // 
            this.informationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.informationLabel.AutoSize = true;
            this.informationLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.informationLabel.Location = new System.Drawing.Point(81, 584);
            this.informationLabel.Name = "informationLabel";
            this.informationLabel.Size = new System.Drawing.Size(451, 21);
            this.informationLabel.TabIndex = 12;
            this.informationLabel.Text = "File >> Open Song >> Choose your song form the FIle explorer";
            // 
            // SearchSong
            // 
            this.SearchSong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchSong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchSong.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchSong.Location = new System.Drawing.Point(945, 214);
            this.SearchSong.Multiline = true;
            this.SearchSong.Name = "SearchSong";
            this.SearchSong.Size = new System.Drawing.Size(235, 25);
            this.SearchSong.TabIndex = 14;
            this.SearchSong.TextChanged += new System.EventHandler(this.TypeSongName_TextChanged);
            // 
            // listViewSongs
            // 
            this.listViewSongs.AllowDrop = true;
            this.listViewSongs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewSongs.BackColor = System.Drawing.Color.FloralWhite;
            this.listViewSongs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewSongs.ContextMenuStrip = this.contextMenuStrip1;
            this.listViewSongs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listViewSongs.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewSongs.FullRowSelect = true;
            this.listViewSongs.HideSelection = false;
            this.listViewSongs.Location = new System.Drawing.Point(-2, -2);
            this.listViewSongs.Name = "listViewSongs";
            this.listViewSongs.OwnerDraw = true;
            this.listViewSongs.Size = new System.Drawing.Size(873, 304);
            this.listViewSongs.TabIndex = 17;
            this.listViewSongs.UseCompatibleStateImageBehavior = false;
            this.listViewSongs.View = System.Windows.Forms.View.Details;
            this.listViewSongs.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.listViewSongs_DrawColumnHeader);
            this.listViewSongs.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.listViewSongs_DrawSubItem);
            this.listViewSongs.DragDrop += new System.Windows.Forms.DragEventHandler(this.listViewSongs_DragDrop);
            this.listViewSongs.DragEnter += new System.Windows.Forms.DragEventHandler(this.listViewSongs_DragEnter);
            this.listViewSongs.DoubleClick += new System.EventHandler(this.listViewSongs_DoubleClick);
            this.listViewSongs.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listViewSongs_KeyDown);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.listViewSongs);
            this.panel1.Location = new System.Drawing.Point(306, 237);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(875, 306);
            this.panel1.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.Controls.Add(this.treeViewFolders);
            this.panel2.Location = new System.Drawing.Point(12, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(264, 492);
            this.panel2.TabIndex = 21;
            // 
            // metroProgressBar1
            // 
            this.metroProgressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroProgressBar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroProgressBar1.Location = new System.Drawing.Point(306, 162);
            this.metroProgressBar1.Name = "metroProgressBar1";
            this.metroProgressBar1.Size = new System.Drawing.Size(875, 10);
            this.metroProgressBar1.TabIndex = 25;
            this.metroProgressBar1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.metroProgressBar1_MouseDown);
            this.metroProgressBar1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.metroProgressBar1_MouseMove);
            this.metroProgressBar1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.metroProgressBar1_MouseUp);
            // 
            // wavePanel
            // 
            this.wavePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wavePanel.BackColor = System.Drawing.Color.Transparent;
            this.wavePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.wavePanel.Location = new System.Drawing.Point(405, 76);
            this.wavePanel.Name = "wavePanel";
            this.wavePanel.Size = new System.Drawing.Size(775, 59);
            this.wavePanel.TabIndex = 26;
            this.wavePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.wavePanel_Paint);
            // 
            // BackPanel
            // 
            this.BackPanel.BackColor = System.Drawing.Color.White;
            this.BackPanel.Controls.Add(this.informationLabel2);
            this.BackPanel.Controls.Add(this.btnPrevious);
            this.BackPanel.Controls.Add(this.btnNext);
            this.BackPanel.Controls.Add(this.btnPlayPuse);
            this.BackPanel.Controls.Add(this.SearchSong);
            this.BackPanel.Controls.Add(this.SongName);
            this.BackPanel.Controls.Add(this.wavePanel);
            this.BackPanel.Controls.Add(this.toolStrip1);
            this.BackPanel.Controls.Add(this.SoundMeter);
            this.BackPanel.Controls.Add(this.informationLabel);
            this.BackPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackPanel.Location = new System.Drawing.Point(0, 0);
            this.BackPanel.Name = "BackPanel";
            this.BackPanel.Size = new System.Drawing.Size(1290, 614);
            this.BackPanel.TabIndex = 27;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPrevious.FlatAppearance.BorderSize = 0;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.IconChar = FontAwesome.Sharp.IconChar.Backward;
            this.btnPrevious.IconColor = System.Drawing.Color.Black;
            this.btnPrevious.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPrevious.IconSize = 25;
            this.btnPrevious.Location = new System.Drawing.Point(608, 178);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(68, 29);
            this.btnPrevious.TabIndex = 32;
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.IconChar = FontAwesome.Sharp.IconChar.Forward;
            this.btnNext.IconColor = System.Drawing.Color.Black;
            this.btnNext.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNext.IconSize = 25;
            this.btnNext.Location = new System.Drawing.Point(756, 175);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(68, 34);
            this.btnNext.TabIndex = 31;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPlayPuse
            // 
            this.btnPlayPuse.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPlayPuse.BackColor = System.Drawing.Color.Transparent;
            this.btnPlayPuse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPlayPuse.FlatAppearance.BorderSize = 0;
            this.btnPlayPuse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayPuse.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayPuse.IconChar = FontAwesome.Sharp.IconChar.Play;
            this.btnPlayPuse.IconColor = System.Drawing.Color.Black;
            this.btnPlayPuse.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPlayPuse.IconSize = 25;
            this.btnPlayPuse.Location = new System.Drawing.Point(682, 175);
            this.btnPlayPuse.Name = "btnPlayPuse";
            this.btnPlayPuse.Size = new System.Drawing.Size(68, 34);
            this.btnPlayPuse.TabIndex = 30;
            this.btnPlayPuse.Text = " ";
            this.btnPlayPuse.UseVisualStyleBackColor = false;
            this.btnPlayPuse.Click += new System.EventHandler(this.btnPlayPuse_Click);
            // 
            // metroContextMenu1
            // 
            this.metroContextMenu1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.metroContextMenu1.Name = "metroContextMenu1";
            this.metroContextMenu1.Size = new System.Drawing.Size(61, 4);
            // 
            // informationLabel2
            // 
            this.informationLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.informationLabel2.AutoSize = true;
            this.informationLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.informationLabel2.Location = new System.Drawing.Point(774, 560);
            this.informationLabel2.Name = "informationLabel2";
            this.informationLabel2.Size = new System.Drawing.Size(407, 18);
            this.informationLabel2.TabIndex = 33;
            this.informationLabel2.Text = "Drop and Drag song from Folder panel to Song Name Panel.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 614);
            this.Controls.Add(this.metroProgressBar1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblTotalTime);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.trackBarVolume);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BackPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resso Music";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.BackPanel.ResumeLayout(false);
            this.BackPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Timer TrackTimer;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.TreeView treeViewFolders;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addOnlineSongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteOnlineSong;
        private System.Windows.Forms.TrackBar trackBarVolume;
        private System.Windows.Forms.Label lblTotalTime;
        private System.Windows.Forms.Label SoundMeter;
        private System.Windows.Forms.Label SongName;
        private System.Windows.Forms.Label informationLabel;
        private System.Windows.Forms.TextBox SearchSong;
        public System.Windows.Forms.ListView listViewSongs;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar1;
        private System.Windows.Forms.Panel wavePanel;
        private System.Windows.Forms.Panel BackPanel;
        private System.Windows.Forms.ToolStripMenuItem thameToolStripMenuItem;
        private FontAwesome.Sharp.IconButton btnPlayPuse;
        private FontAwesome.Sharp.IconButton btnNext;
        private FontAwesome.Sharp.IconButton btnPrevious;
        private System.Windows.Forms.ToolStripMenuItem bachThameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontStyleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem segoeUIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arialBlackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calibriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comicSansMSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem courierNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem georgiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem impactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lucidaConsoleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem microsoftSansSerifToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tahomaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timesNewRomanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trebuchetMSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verdanaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem weddingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wingdingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu1;
        private System.Windows.Forms.Label informationLabel2;
    }
}

