
namespace WinAppMediaPlayerVersie2
{
    partial class frmServerMediaPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmServerMediaPlayer));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssMediaPlayer = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssTCPServer = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssClient = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabMediaPlayer = new System.Windows.Forms.TabPage();
            this.splitContMediaPlayer = new System.Windows.Forms.SplitContainer();
            this.pnlPlaylist = new System.Windows.Forms.Panel();
            this.lstPlaylistSongs = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.pnlKnoppen = new System.Windows.Forms.Panel();
            this.btnVerwijderPlayList = new System.Windows.Forms.Button();
            this.btnVoegToePlayList = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pnlAlleSongs = new System.Windows.Forms.Panel();
            this.lstAlleSongs = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStopPlay = new System.Windows.Forms.Button();
            this.btnStartPlay = new System.Windows.Forms.Button();
            this.btnVoegSongToe = new System.Windows.Forms.Button();
            this.tabServer = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtMelding = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOntvang = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtZend = new System.Windows.Forms.TextBox();
            this.btnZend = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlServerInstelling = new System.Windows.Forms.Panel();
            this.mtxtPoortnr = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mtxtIPadres = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkbStartStopServer = new System.Windows.Forms.CheckBox();
            this.btnVerbreek = new System.Windows.Forms.Button();
            this.tabPlaylist = new System.Windows.Forms.TabPage();
            this.pnlDatabase = new System.Windows.Forms.Panel();
            this.playListDataGridView = new System.Windows.Forms.DataGridView();
            this.pnlDatabaseKnoppen = new System.Windows.Forms.Panel();
            this.btnLadenPlayListUitDatabase = new System.Windows.Forms.Button();
            this.btnVoegSongsToeAanDatabase = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbPlayList = new System.Windows.Forms.ComboBox();
            this.ofdZoekSong = new System.Windows.Forms.OpenFileDialog();
            this.bgWorkerListener = new System.ComponentModel.BackgroundWorker();
            this.bgWorkerOntvang = new System.ComponentModel.BackgroundWorker();
            this.playListBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.playListBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.playListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataMediaPlayerDataSet = new WinAppMediaPlayerVersie2.DataMediaPlayerDataSet();
            this.playListTableAdapter = new WinAppMediaPlayerVersie2.DataMediaPlayerDataSetTableAdapters.PlayListTableAdapter();
            this.tableAdapterManager = new WinAppMediaPlayerVersie2.DataMediaPlayerDataSetTableAdapters.TableAdapterManager();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabMediaPlayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContMediaPlayer)).BeginInit();
            this.splitContMediaPlayer.Panel1.SuspendLayout();
            this.splitContMediaPlayer.Panel2.SuspendLayout();
            this.splitContMediaPlayer.SuspendLayout();
            this.pnlPlaylist.SuspendLayout();
            this.pnlKnoppen.SuspendLayout();
            this.pnlAlleSongs.SuspendLayout();
            this.tabServer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.pnlServerInstelling.SuspendLayout();
            this.tabPlaylist.SuspendLayout();
            this.pnlDatabase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playListDataGridView)).BeginInit();
            this.pnlDatabaseKnoppen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playListBindingNavigator)).BeginInit();
            this.playListBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataMediaPlayerDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssMediaPlayer,
            this.toolStripStatusLabel1,
            this.tssTCPServer,
            this.toolStripStatusLabel3,
            this.tssClient});
            this.statusStrip1.Location = new System.Drawing.Point(0, 423);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(542, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssMediaPlayer
            // 
            this.tssMediaPlayer.ForeColor = System.Drawing.Color.Red;
            this.tssMediaPlayer.Name = "tssMediaPlayer";
            this.tssMediaPlayer.Size = new System.Drawing.Size(115, 17);
            this.tssMediaPlayer.Text = "Mediaplayer gestopt";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(12, 17);
            this.toolStripStatusLabel1.Text = "-";
            // 
            // tssTCPServer
            // 
            this.tssTCPServer.ForeColor = System.Drawing.Color.Red;
            this.tssTCPServer.Name = "tssTCPServer";
            this.tssTCPServer.Size = new System.Drawing.Size(120, 17);
            this.tssTCPServer.Text = "TCP/IP Server gestopt";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(12, 17);
            this.toolStripStatusLabel3.Text = "-";
            // 
            // tssClient
            // 
            this.tssClient.ForeColor = System.Drawing.Color.Red;
            this.tssClient.Name = "tssClient";
            this.tssClient.Size = new System.Drawing.Size(121, 17);
            this.tssClient.Text = "Client niet verbonden";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabMediaPlayer);
            this.tabControl1.Controls.Add(this.tabServer);
            this.tabControl1.Controls.Add(this.tabPlaylist);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(542, 423);
            this.tabControl1.TabIndex = 1;
            // 
            // tabMediaPlayer
            // 
            this.tabMediaPlayer.Controls.Add(this.splitContMediaPlayer);
            this.tabMediaPlayer.Location = new System.Drawing.Point(4, 22);
            this.tabMediaPlayer.Margin = new System.Windows.Forms.Padding(2);
            this.tabMediaPlayer.Name = "tabMediaPlayer";
            this.tabMediaPlayer.Padding = new System.Windows.Forms.Padding(2);
            this.tabMediaPlayer.Size = new System.Drawing.Size(534, 397);
            this.tabMediaPlayer.TabIndex = 0;
            this.tabMediaPlayer.Text = "MediaPlayer";
            this.tabMediaPlayer.UseVisualStyleBackColor = true;
            // 
            // splitContMediaPlayer
            // 
            this.splitContMediaPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContMediaPlayer.Location = new System.Drawing.Point(2, 2);
            this.splitContMediaPlayer.Margin = new System.Windows.Forms.Padding(2);
            this.splitContMediaPlayer.Name = "splitContMediaPlayer";
            this.splitContMediaPlayer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContMediaPlayer.Panel1
            // 
            this.splitContMediaPlayer.Panel1.Controls.Add(this.pnlPlaylist);
            this.splitContMediaPlayer.Panel1.Controls.Add(this.splitter2);
            this.splitContMediaPlayer.Panel1.Controls.Add(this.pnlKnoppen);
            this.splitContMediaPlayer.Panel1.Controls.Add(this.splitter1);
            this.splitContMediaPlayer.Panel1.Controls.Add(this.pnlAlleSongs);
            // 
            // splitContMediaPlayer.Panel2
            // 
            this.splitContMediaPlayer.Panel2.Controls.Add(this.btnStopPlay);
            this.splitContMediaPlayer.Panel2.Controls.Add(this.btnStartPlay);
            this.splitContMediaPlayer.Panel2.Controls.Add(this.btnVoegSongToe);
            this.splitContMediaPlayer.Panel2MinSize = 125;
            this.splitContMediaPlayer.Size = new System.Drawing.Size(530, 393);
            this.splitContMediaPlayer.SplitterDistance = 265;
            this.splitContMediaPlayer.SplitterWidth = 3;
            this.splitContMediaPlayer.TabIndex = 1;
            // 
            // pnlPlaylist
            // 
            this.pnlPlaylist.Controls.Add(this.lstPlaylistSongs);
            this.pnlPlaylist.Controls.Add(this.label2);
            this.pnlPlaylist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPlaylist.Location = new System.Drawing.Point(484, 0);
            this.pnlPlaylist.Margin = new System.Windows.Forms.Padding(2);
            this.pnlPlaylist.Name = "pnlPlaylist";
            this.pnlPlaylist.Size = new System.Drawing.Size(46, 265);
            this.pnlPlaylist.TabIndex = 4;
            // 
            // lstPlaylistSongs
            // 
            this.lstPlaylistSongs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstPlaylistSongs.FormattingEnabled = true;
            this.lstPlaylistSongs.Location = new System.Drawing.Point(0, 13);
            this.lstPlaylistSongs.Margin = new System.Windows.Forms.Padding(2);
            this.lstPlaylistSongs.Name = "lstPlaylistSongs";
            this.lstPlaylistSongs.Size = new System.Drawing.Size(46, 252);
            this.lstPlaylistSongs.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Playlist:";
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(476, 0);
            this.splitter2.Margin = new System.Windows.Forms.Padding(2);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(8, 265);
            this.splitter2.TabIndex = 3;
            this.splitter2.TabStop = false;
            // 
            // pnlKnoppen
            // 
            this.pnlKnoppen.BackColor = System.Drawing.SystemColors.Control;
            this.pnlKnoppen.Controls.Add(this.btnVerwijderPlayList);
            this.pnlKnoppen.Controls.Add(this.btnVoegToePlayList);
            this.pnlKnoppen.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlKnoppen.Location = new System.Drawing.Point(420, 0);
            this.pnlKnoppen.Margin = new System.Windows.Forms.Padding(2);
            this.pnlKnoppen.Name = "pnlKnoppen";
            this.pnlKnoppen.Size = new System.Drawing.Size(56, 265);
            this.pnlKnoppen.TabIndex = 2;
            // 
            // btnVerwijderPlayList
            // 
            this.btnVerwijderPlayList.Location = new System.Drawing.Point(8, 49);
            this.btnVerwijderPlayList.Margin = new System.Windows.Forms.Padding(2);
            this.btnVerwijderPlayList.Name = "btnVerwijderPlayList";
            this.btnVerwijderPlayList.Size = new System.Drawing.Size(40, 29);
            this.btnVerwijderPlayList.TabIndex = 1;
            this.btnVerwijderPlayList.Text = "<<";
            this.btnVerwijderPlayList.UseVisualStyleBackColor = true;
            this.btnVerwijderPlayList.Click += new System.EventHandler(this.btnVerwijderPlayList_Click);
            // 
            // btnVoegToePlayList
            // 
            this.btnVoegToePlayList.Location = new System.Drawing.Point(8, 15);
            this.btnVoegToePlayList.Margin = new System.Windows.Forms.Padding(2);
            this.btnVoegToePlayList.Name = "btnVoegToePlayList";
            this.btnVoegToePlayList.Size = new System.Drawing.Size(40, 29);
            this.btnVoegToePlayList.TabIndex = 0;
            this.btnVoegToePlayList.Text = ">>";
            this.btnVoegToePlayList.UseVisualStyleBackColor = true;
            this.btnVoegToePlayList.Click += new System.EventHandler(this.btnVoegToePlayList_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(412, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(2);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(8, 265);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // pnlAlleSongs
            // 
            this.pnlAlleSongs.Controls.Add(this.lstAlleSongs);
            this.pnlAlleSongs.Controls.Add(this.label1);
            this.pnlAlleSongs.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlAlleSongs.Location = new System.Drawing.Point(0, 0);
            this.pnlAlleSongs.Margin = new System.Windows.Forms.Padding(2);
            this.pnlAlleSongs.Name = "pnlAlleSongs";
            this.pnlAlleSongs.Size = new System.Drawing.Size(412, 265);
            this.pnlAlleSongs.TabIndex = 0;
            // 
            // lstAlleSongs
            // 
            this.lstAlleSongs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstAlleSongs.FormattingEnabled = true;
            this.lstAlleSongs.Location = new System.Drawing.Point(0, 13);
            this.lstAlleSongs.Margin = new System.Windows.Forms.Padding(2);
            this.lstAlleSongs.Name = "lstAlleSongs";
            this.lstAlleSongs.Size = new System.Drawing.Size(412, 252);
            this.lstAlleSongs.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alle Songs:";
            // 
            // btnStopPlay
            // 
            this.btnStopPlay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStopPlay.Location = new System.Drawing.Point(134, 61);
            this.btnStopPlay.Margin = new System.Windows.Forms.Padding(2);
            this.btnStopPlay.Name = "btnStopPlay";
            this.btnStopPlay.Size = new System.Drawing.Size(396, 64);
            this.btnStopPlay.TabIndex = 2;
            this.btnStopPlay.Text = "Playlist stoppen";
            this.btnStopPlay.UseVisualStyleBackColor = true;
            this.btnStopPlay.Click += new System.EventHandler(this.btnStopPlay_Click);
            // 
            // btnStartPlay
            // 
            this.btnStartPlay.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStartPlay.Location = new System.Drawing.Point(134, 0);
            this.btnStartPlay.Margin = new System.Windows.Forms.Padding(2);
            this.btnStartPlay.Name = "btnStartPlay";
            this.btnStartPlay.Size = new System.Drawing.Size(396, 61);
            this.btnStartPlay.TabIndex = 1;
            this.btnStartPlay.Text = "Playlist afspelen";
            this.btnStartPlay.UseVisualStyleBackColor = true;
            this.btnStartPlay.Click += new System.EventHandler(this.btnStartPlay_Click);
            // 
            // btnVoegSongToe
            // 
            this.btnVoegSongToe.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnVoegSongToe.Location = new System.Drawing.Point(0, 0);
            this.btnVoegSongToe.Margin = new System.Windows.Forms.Padding(2);
            this.btnVoegSongToe.Name = "btnVoegSongToe";
            this.btnVoegSongToe.Size = new System.Drawing.Size(134, 125);
            this.btnVoegSongToe.TabIndex = 0;
            this.btnVoegSongToe.Text = "Song zoeken ...";
            this.btnVoegSongToe.UseVisualStyleBackColor = true;
            this.btnVoegSongToe.Click += new System.EventHandler(this.btnVoegSongToe_Click);
            // 
            // tabServer
            // 
            this.tabServer.Controls.Add(this.splitContainer1);
            this.tabServer.Controls.Add(this.pnlServerInstelling);
            this.tabServer.Location = new System.Drawing.Point(4, 22);
            this.tabServer.Margin = new System.Windows.Forms.Padding(2);
            this.tabServer.Name = "tabServer";
            this.tabServer.Padding = new System.Windows.Forms.Padding(2);
            this.tabServer.Size = new System.Drawing.Size(534, 397);
            this.tabServer.TabIndex = 1;
            this.tabServer.Text = "TCP/IP Server";
            this.tabServer.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(2, 81);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtMelding);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtOntvang);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.txtZend);
            this.splitContainer1.Panel2.Controls.Add(this.btnZend);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Enabled = false;
            this.splitContainer1.Size = new System.Drawing.Size(530, 314);
            this.splitContainer1.SplitterDistance = 176;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 1;
            // 
            // txtMelding
            // 
            this.txtMelding.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMelding.Enabled = false;
            this.txtMelding.Location = new System.Drawing.Point(0, 13);
            this.txtMelding.Multiline = true;
            this.txtMelding.Name = "txtMelding";
            this.txtMelding.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMelding.Size = new System.Drawing.Size(176, 301);
            this.txtMelding.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Meldingen door Server:";
            // 
            // txtOntvang
            // 
            this.txtOntvang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOntvang.Enabled = false;
            this.txtOntvang.Location = new System.Drawing.Point(0, 13);
            this.txtOntvang.Multiline = true;
            this.txtOntvang.Name = "txtOntvang";
            this.txtOntvang.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOntvang.Size = new System.Drawing.Size(351, 244);
            this.txtOntvang.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label7.Location = new System.Drawing.Point(0, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "bericht:";
            // 
            // txtZend
            // 
            this.txtZend.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtZend.Location = new System.Drawing.Point(0, 270);
            this.txtZend.Name = "txtZend";
            this.txtZend.Size = new System.Drawing.Size(351, 20);
            this.txtZend.TabIndex = 28;
            // 
            // btnZend
            // 
            this.btnZend.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnZend.Location = new System.Drawing.Point(0, 290);
            this.btnZend.Name = "btnZend";
            this.btnZend.Size = new System.Drawing.Size(351, 24);
            this.btnZend.TabIndex = 27;
            this.btnZend.Text = "Zend bericht naar naar Client";
            this.btnZend.UseVisualStyleBackColor = true;
            this.btnZend.Click += new System.EventHandler(this.btnZend_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(188, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Communicatie tussen Server en Client:";
            // 
            // pnlServerInstelling
            // 
            this.pnlServerInstelling.Controls.Add(this.mtxtPoortnr);
            this.pnlServerInstelling.Controls.Add(this.label5);
            this.pnlServerInstelling.Controls.Add(this.mtxtIPadres);
            this.pnlServerInstelling.Controls.Add(this.label3);
            this.pnlServerInstelling.Controls.Add(this.chkbStartStopServer);
            this.pnlServerInstelling.Controls.Add(this.btnVerbreek);
            this.pnlServerInstelling.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlServerInstelling.Location = new System.Drawing.Point(2, 2);
            this.pnlServerInstelling.Margin = new System.Windows.Forms.Padding(2);
            this.pnlServerInstelling.Name = "pnlServerInstelling";
            this.pnlServerInstelling.Size = new System.Drawing.Size(530, 79);
            this.pnlServerInstelling.TabIndex = 0;
            // 
            // mtxtPoortnr
            // 
            this.mtxtPoortnr.Dock = System.Windows.Forms.DockStyle.Top;
            this.mtxtPoortnr.Location = new System.Drawing.Point(0, 46);
            this.mtxtPoortnr.Margin = new System.Windows.Forms.Padding(2);
            this.mtxtPoortnr.Mask = "99000";
            this.mtxtPoortnr.Name = "mtxtPoortnr";
            this.mtxtPoortnr.Size = new System.Drawing.Size(253, 20);
            this.mtxtPoortnr.TabIndex = 45;
            this.mtxtPoortnr.Text = "50000";
            this.mtxtPoortnr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Location = new System.Drawing.Point(0, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Poortnr:";
            // 
            // mtxtIPadres
            // 
            this.mtxtIPadres.Dock = System.Windows.Forms.DockStyle.Top;
            this.mtxtIPadres.Location = new System.Drawing.Point(0, 13);
            this.mtxtIPadres.Margin = new System.Windows.Forms.Padding(2);
            this.mtxtIPadres.Mask = "990,990,990,990";
            this.mtxtIPadres.Name = "mtxtIPadres";
            this.mtxtIPadres.Size = new System.Drawing.Size(253, 20);
            this.mtxtIPadres.TabIndex = 43;
            this.mtxtIPadres.Text = "127000000001";
            this.mtxtIPadres.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "IPadres:";
            // 
            // chkbStartStopServer
            // 
            this.chkbStartStopServer.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkbStartStopServer.Dock = System.Windows.Forms.DockStyle.Right;
            this.chkbStartStopServer.Location = new System.Drawing.Point(253, 0);
            this.chkbStartStopServer.Margin = new System.Windows.Forms.Padding(2);
            this.chkbStartStopServer.Name = "chkbStartStopServer";
            this.chkbStartStopServer.Size = new System.Drawing.Size(94, 79);
            this.chkbStartStopServer.TabIndex = 38;
            this.chkbStartStopServer.Text = "Start de Server";
            this.chkbStartStopServer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkbStartStopServer.UseVisualStyleBackColor = true;
            this.chkbStartStopServer.CheckedChanged += new System.EventHandler(this.chkbStartStopServer_CheckedChanged);
            // 
            // btnVerbreek
            // 
            this.btnVerbreek.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnVerbreek.Enabled = false;
            this.btnVerbreek.Location = new System.Drawing.Point(347, 0);
            this.btnVerbreek.Margin = new System.Windows.Forms.Padding(2);
            this.btnVerbreek.Name = "btnVerbreek";
            this.btnVerbreek.Size = new System.Drawing.Size(183, 79);
            this.btnVerbreek.TabIndex = 3;
            this.btnVerbreek.Text = "Verbreek verbinding met de Client";
            this.btnVerbreek.UseVisualStyleBackColor = true;
            this.btnVerbreek.Click += new System.EventHandler(this.btnVerbreek_Click);
            // 
            // tabPlaylist
            // 
            this.tabPlaylist.Controls.Add(this.pnlDatabase);
            this.tabPlaylist.Controls.Add(this.pnlDatabaseKnoppen);
            this.tabPlaylist.Location = new System.Drawing.Point(4, 22);
            this.tabPlaylist.Margin = new System.Windows.Forms.Padding(2);
            this.tabPlaylist.Name = "tabPlaylist";
            this.tabPlaylist.Size = new System.Drawing.Size(534, 397);
            this.tabPlaylist.TabIndex = 2;
            this.tabPlaylist.Text = "PlayLijsten database";
            this.tabPlaylist.UseVisualStyleBackColor = true;
            // 
            // pnlDatabase
            // 
            this.pnlDatabase.AutoScroll = true;
            this.pnlDatabase.Controls.Add(this.playListDataGridView);
            this.pnlDatabase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDatabase.Location = new System.Drawing.Point(0, 217);
            this.pnlDatabase.Name = "pnlDatabase";
            this.pnlDatabase.Size = new System.Drawing.Size(534, 180);
            this.pnlDatabase.TabIndex = 1;
            // 
            // playListDataGridView
            // 
            this.playListDataGridView.AllowUserToAddRows = false;
            this.playListDataGridView.AllowUserToDeleteRows = false;
            this.playListDataGridView.AutoGenerateColumns = false;
            this.playListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.playListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.playListDataGridView.DataSource = this.playListBindingSource;
            this.playListDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playListDataGridView.Location = new System.Drawing.Point(0, 0);
            this.playListDataGridView.Name = "playListDataGridView";
            this.playListDataGridView.ReadOnly = true;
            this.playListDataGridView.Size = new System.Drawing.Size(534, 180);
            this.playListDataGridView.TabIndex = 0;
            this.playListDataGridView.Visible = false;
            // 
            // pnlDatabaseKnoppen
            // 
            this.pnlDatabaseKnoppen.Controls.Add(this.btnLadenPlayListUitDatabase);
            this.pnlDatabaseKnoppen.Controls.Add(this.btnVoegSongsToeAanDatabase);
            this.pnlDatabaseKnoppen.Controls.Add(this.label8);
            this.pnlDatabaseKnoppen.Controls.Add(this.cmbPlayList);
            this.pnlDatabaseKnoppen.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDatabaseKnoppen.Location = new System.Drawing.Point(0, 0);
            this.pnlDatabaseKnoppen.Name = "pnlDatabaseKnoppen";
            this.pnlDatabaseKnoppen.Size = new System.Drawing.Size(534, 217);
            this.pnlDatabaseKnoppen.TabIndex = 0;
            // 
            // btnLadenPlayListUitDatabase
            // 
            this.btnLadenPlayListUitDatabase.Location = new System.Drawing.Point(255, 110);
            this.btnLadenPlayListUitDatabase.Name = "btnLadenPlayListUitDatabase";
            this.btnLadenPlayListUitDatabase.Size = new System.Drawing.Size(276, 100);
            this.btnLadenPlayListUitDatabase.TabIndex = 6;
            this.btnLadenPlayListUitDatabase.Text = "Laad de geselecteerde PlayList uit de database naar de Playlist van de Mediaplaye" +
    "r";
            this.btnLadenPlayListUitDatabase.UseVisualStyleBackColor = true;
            this.btnLadenPlayListUitDatabase.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnVoegSongsToeAanDatabase
            // 
            this.btnVoegSongsToeAanDatabase.Location = new System.Drawing.Point(255, 4);
            this.btnVoegSongsToeAanDatabase.Name = "btnVoegSongsToeAanDatabase";
            this.btnVoegSongsToeAanDatabase.Size = new System.Drawing.Size(276, 100);
            this.btnVoegSongsToeAanDatabase.TabIndex = 5;
            this.btnVoegSongsToeAanDatabase.Text = "Voeg de huidige Songs uit de Playlist van de MediaPlayer toe aan deze PlayList in" +
    " de Database";
            this.btnVoegSongsToeAanDatabase.UseVisualStyleBackColor = true;
            this.btnVoegSongsToeAanDatabase.Click += new System.EventHandler(this.btnVoegSongsToeAanDatabase_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "PlayListen:";
            // 
            // cmbPlayList
            // 
            this.cmbPlayList.FormattingEnabled = true;
            this.cmbPlayList.Location = new System.Drawing.Point(3, 25);
            this.cmbPlayList.Name = "cmbPlayList";
            this.cmbPlayList.Size = new System.Drawing.Size(246, 21);
            this.cmbPlayList.TabIndex = 3;
            this.cmbPlayList.TextChanged += new System.EventHandler(this.cmbPlayList_TextChanged);
            // 
            // ofdZoekSong
            // 
            this.ofdZoekSong.Filter = "\"mp3-bestand\"|*.mp3|\"mp4-bestand\"|*.mp4|\"wav-bestand\"|*.wav";
            this.ofdZoekSong.Title = "Song toevoegen";
            // 
            // bgWorkerListener
            // 
            this.bgWorkerListener.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorkerListener_DoWork);
            this.bgWorkerListener.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorkerListener_RunWorkerCompleted);
            // 
            // bgWorkerOntvang
            // 
            this.bgWorkerOntvang.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorkerOntvang_DoWork);
            this.bgWorkerOntvang.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorkerOntvang_RunWorkerCompleted);
            // 
            // playListBindingNavigator
            // 
            this.playListBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.playListBindingNavigator.BindingSource = this.playListBindingSource;
            this.playListBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.playListBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.playListBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.playListBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.playListBindingNavigatorSaveItem});
            this.playListBindingNavigator.Location = new System.Drawing.Point(0, 398);
            this.playListBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.playListBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.playListBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.playListBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.playListBindingNavigator.Name = "playListBindingNavigator";
            this.playListBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.playListBindingNavigator.Size = new System.Drawing.Size(542, 25);
            this.playListBindingNavigator.TabIndex = 2;
            this.playListBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Enabled = false;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // playListBindingNavigatorSaveItem
            // 
            this.playListBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.playListBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("playListBindingNavigatorSaveItem.Image")));
            this.playListBindingNavigatorSaveItem.Name = "playListBindingNavigatorSaveItem";
            this.playListBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.playListBindingNavigatorSaveItem.Text = "Save Data";
            this.playListBindingNavigatorSaveItem.Click += new System.EventHandler(this.playListBindingNavigatorSaveItem_Click);
            // 
            // playListBindingSource
            // 
            this.playListBindingSource.DataMember = "PlayList";
            this.playListBindingSource.DataSource = this.dataMediaPlayerDataSet;
            // 
            // dataMediaPlayerDataSet
            // 
            this.dataMediaPlayerDataSet.DataSetName = "DataMediaPlayerDataSet";
            this.dataMediaPlayerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // playListTableAdapter
            // 
            this.playListTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PlayListTableAdapter = this.playListTableAdapter;
            this.tableAdapterManager.UpdateOrder = WinAppMediaPlayerVersie2.DataMediaPlayerDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PlayListNaam";
            this.dataGridViewTextBoxColumn2.HeaderText = "PlayListNaam";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Song";
            this.dataGridViewTextBoxColumn3.HeaderText = "Song";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Pad";
            this.dataGridViewTextBoxColumn4.HeaderText = "Pad";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // frmServerMediaPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 445);
            this.Controls.Add(this.playListBindingNavigator);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmServerMediaPlayer";
            this.Text = "MediaPlayer - Server";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmServerMediaPlayer_Load);
            this.Shown += new System.EventHandler(this.frmServerMediaPlayer_Shown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabMediaPlayer.ResumeLayout(false);
            this.splitContMediaPlayer.Panel1.ResumeLayout(false);
            this.splitContMediaPlayer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContMediaPlayer)).EndInit();
            this.splitContMediaPlayer.ResumeLayout(false);
            this.pnlPlaylist.ResumeLayout(false);
            this.pnlPlaylist.PerformLayout();
            this.pnlKnoppen.ResumeLayout(false);
            this.pnlAlleSongs.ResumeLayout(false);
            this.pnlAlleSongs.PerformLayout();
            this.tabServer.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.pnlServerInstelling.ResumeLayout(false);
            this.pnlServerInstelling.PerformLayout();
            this.tabPlaylist.ResumeLayout(false);
            this.pnlDatabase.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.playListDataGridView)).EndInit();
            this.pnlDatabaseKnoppen.ResumeLayout(false);
            this.pnlDatabaseKnoppen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playListBindingNavigator)).EndInit();
            this.playListBindingNavigator.ResumeLayout(false);
            this.playListBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataMediaPlayerDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabMediaPlayer;
        private System.Windows.Forms.TabPage tabServer;
        private System.Windows.Forms.TabPage tabPlaylist;
        private System.Windows.Forms.SplitContainer splitContMediaPlayer;
        private System.Windows.Forms.Panel pnlPlaylist;
        private System.Windows.Forms.ListBox lstPlaylistSongs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Panel pnlKnoppen;
        private System.Windows.Forms.Button btnVerwijderPlayList;
        private System.Windows.Forms.Button btnVoegToePlayList;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel pnlAlleSongs;
        private System.Windows.Forms.ListBox lstAlleSongs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStopPlay;
        private System.Windows.Forms.Button btnStartPlay;
        private System.Windows.Forms.Button btnVoegSongToe;
        private System.Windows.Forms.OpenFileDialog ofdZoekSong;
        private System.Windows.Forms.ToolStripStatusLabel tssMediaPlayer;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tssTCPServer;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel tssClient;
        private System.ComponentModel.BackgroundWorker bgWorkerListener;
        private System.Windows.Forms.Panel pnlServerInstelling;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txtMelding;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOntvang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtZend;
        private System.Windows.Forms.Button btnZend;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkbStartStopServer;
        private System.Windows.Forms.Button btnVerbreek;
        private System.ComponentModel.BackgroundWorker bgWorkerOntvang;
        private System.Windows.Forms.MaskedTextBox mtxtPoortnr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mtxtIPadres;
        private System.Windows.Forms.Panel pnlDatabase;
        private System.Windows.Forms.Panel pnlDatabaseKnoppen;
        private DataMediaPlayerDataSet dataMediaPlayerDataSet;
        private System.Windows.Forms.BindingSource playListBindingSource;
        private DataMediaPlayerDataSetTableAdapters.PlayListTableAdapter playListTableAdapter;
        private DataMediaPlayerDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator playListBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton playListBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView playListDataGridView;
        private System.Windows.Forms.Button btnLadenPlayListUitDatabase;
        private System.Windows.Forms.Button btnVoegSongsToeAanDatabase;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbPlayList;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}

