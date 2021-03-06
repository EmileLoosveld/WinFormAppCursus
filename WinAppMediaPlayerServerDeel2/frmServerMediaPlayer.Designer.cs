
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
            this.ofdZoekSong = new System.Windows.Forms.OpenFileDialog();
            this.bgWorkerListener = new System.ComponentModel.BackgroundWorker();
            this.bgWorkerOntvang = new System.ComponentModel.BackgroundWorker();
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 509);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(928, 22);
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
            this.tabControl1.Size = new System.Drawing.Size(928, 509);
            this.tabControl1.TabIndex = 1;
            // 
            // tabMediaPlayer
            // 
            this.tabMediaPlayer.Controls.Add(this.splitContMediaPlayer);
            this.tabMediaPlayer.Location = new System.Drawing.Point(4, 22);
            this.tabMediaPlayer.Margin = new System.Windows.Forms.Padding(2);
            this.tabMediaPlayer.Name = "tabMediaPlayer";
            this.tabMediaPlayer.Padding = new System.Windows.Forms.Padding(2);
            this.tabMediaPlayer.Size = new System.Drawing.Size(920, 483);
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
            this.splitContMediaPlayer.Size = new System.Drawing.Size(916, 479);
            this.splitContMediaPlayer.SplitterDistance = 351;
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
            this.pnlPlaylist.Size = new System.Drawing.Size(432, 351);
            this.pnlPlaylist.TabIndex = 4;
            // 
            // lstPlaylistSongs
            // 
            this.lstPlaylistSongs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstPlaylistSongs.FormattingEnabled = true;
            this.lstPlaylistSongs.Location = new System.Drawing.Point(0, 13);
            this.lstPlaylistSongs.Margin = new System.Windows.Forms.Padding(2);
            this.lstPlaylistSongs.Name = "lstPlaylistSongs";
            this.lstPlaylistSongs.Size = new System.Drawing.Size(432, 338);
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
            this.splitter2.Size = new System.Drawing.Size(8, 351);
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
            this.pnlKnoppen.Size = new System.Drawing.Size(56, 351);
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
            this.splitter1.Size = new System.Drawing.Size(8, 351);
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
            this.pnlAlleSongs.Size = new System.Drawing.Size(412, 351);
            this.pnlAlleSongs.TabIndex = 0;
            // 
            // lstAlleSongs
            // 
            this.lstAlleSongs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstAlleSongs.FormattingEnabled = true;
            this.lstAlleSongs.Location = new System.Drawing.Point(0, 13);
            this.lstAlleSongs.Margin = new System.Windows.Forms.Padding(2);
            this.lstAlleSongs.Name = "lstAlleSongs";
            this.lstAlleSongs.Size = new System.Drawing.Size(412, 338);
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
            this.btnStopPlay.Size = new System.Drawing.Size(782, 64);
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
            this.btnStartPlay.Size = new System.Drawing.Size(782, 61);
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
            this.tabServer.Size = new System.Drawing.Size(920, 483);
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
            this.splitContainer1.Size = new System.Drawing.Size(916, 400);
            this.splitContainer1.SplitterDistance = 305;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 1;
            // 
            // txtMelding
            // 
            this.txtMelding.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMelding.Location = new System.Drawing.Point(0, 13);
            this.txtMelding.Multiline = true;
            this.txtMelding.Name = "txtMelding";
            this.txtMelding.ReadOnly = true;
            this.txtMelding.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMelding.Size = new System.Drawing.Size(305, 387);
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
            this.txtOntvang.Location = new System.Drawing.Point(0, 13);
            this.txtOntvang.Multiline = true;
            this.txtOntvang.Name = "txtOntvang";
            this.txtOntvang.ReadOnly = true;
            this.txtOntvang.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOntvang.Size = new System.Drawing.Size(608, 330);
            this.txtOntvang.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label7.Location = new System.Drawing.Point(0, 343);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "bericht:";
            // 
            // txtZend
            // 
            this.txtZend.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtZend.Location = new System.Drawing.Point(0, 356);
            this.txtZend.Name = "txtZend";
            this.txtZend.Size = new System.Drawing.Size(608, 20);
            this.txtZend.TabIndex = 28;
            // 
            // btnZend
            // 
            this.btnZend.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnZend.Enabled = false;
            this.btnZend.Location = new System.Drawing.Point(0, 376);
            this.btnZend.Name = "btnZend";
            this.btnZend.Size = new System.Drawing.Size(608, 24);
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
            this.pnlServerInstelling.Size = new System.Drawing.Size(916, 79);
            this.pnlServerInstelling.TabIndex = 0;
            // 
            // mtxtPoortnr
            // 
            this.mtxtPoortnr.Dock = System.Windows.Forms.DockStyle.Top;
            this.mtxtPoortnr.Location = new System.Drawing.Point(0, 46);
            this.mtxtPoortnr.Margin = new System.Windows.Forms.Padding(2);
            this.mtxtPoortnr.Mask = "99000";
            this.mtxtPoortnr.Name = "mtxtPoortnr";
            this.mtxtPoortnr.Size = new System.Drawing.Size(639, 20);
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
            this.mtxtIPadres.Size = new System.Drawing.Size(639, 20);
            this.mtxtIPadres.TabIndex = 43;
            this.mtxtIPadres.Text = "127000000001";
            this.mtxtIPadres.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxtIPadres.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtxtIPadres_MaskInputRejected);
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
            this.chkbStartStopServer.Location = new System.Drawing.Point(639, 0);
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
            this.btnVerbreek.Location = new System.Drawing.Point(733, 0);
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
            this.tabPlaylist.Location = new System.Drawing.Point(4, 22);
            this.tabPlaylist.Margin = new System.Windows.Forms.Padding(2);
            this.tabPlaylist.Name = "tabPlaylist";
            this.tabPlaylist.Size = new System.Drawing.Size(920, 483);
            this.tabPlaylist.TabIndex = 2;
            this.tabPlaylist.Text = "PlayLijsten database";
            this.tabPlaylist.UseVisualStyleBackColor = true;
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
            // frmServerMediaPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 531);
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
        private System.Windows.Forms.MaskedTextBox mtxtPoortnr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mtxtIPadres;
        private System.ComponentModel.BackgroundWorker bgWorkerOntvang;
    }
}

