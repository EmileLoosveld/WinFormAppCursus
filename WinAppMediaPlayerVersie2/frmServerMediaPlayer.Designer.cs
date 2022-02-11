﻿
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
            this.tabPlaylist = new System.Windows.Forms.TabPage();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tssMediaPlayer = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssTCPServer = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssClient = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
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
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssMediaPlayer,
            this.toolStripStatusLabel4,
            this.tssTCPServer,
            this.toolStripStatusLabel5,
            this.tssClient});
            this.statusStrip1.Location = new System.Drawing.Point(0, 553);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1049, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabMediaPlayer);
            this.tabControl1.Controls.Add(this.tabServer);
            this.tabControl1.Controls.Add(this.tabPlaylist);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1049, 553);
            this.tabControl1.TabIndex = 1;
            // 
            // tabMediaPlayer
            // 
            this.tabMediaPlayer.Controls.Add(this.splitContMediaPlayer);
            this.tabMediaPlayer.Location = new System.Drawing.Point(4, 22);
            this.tabMediaPlayer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabMediaPlayer.Name = "tabMediaPlayer";
            this.tabMediaPlayer.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabMediaPlayer.Size = new System.Drawing.Size(1041, 527);
            this.tabMediaPlayer.TabIndex = 0;
            this.tabMediaPlayer.Text = "MediaPlayer";
            this.tabMediaPlayer.UseVisualStyleBackColor = true;
            // 
            // splitContMediaPlayer
            // 
            this.splitContMediaPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContMediaPlayer.Location = new System.Drawing.Point(2, 2);
            this.splitContMediaPlayer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.splitContMediaPlayer.Size = new System.Drawing.Size(1037, 523);
            this.splitContMediaPlayer.SplitterDistance = 401;
            this.splitContMediaPlayer.SplitterWidth = 3;
            this.splitContMediaPlayer.TabIndex = 1;
            // 
            // pnlPlaylist
            // 
            this.pnlPlaylist.Controls.Add(this.lstPlaylistSongs);
            this.pnlPlaylist.Controls.Add(this.label2);
            this.pnlPlaylist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPlaylist.Location = new System.Drawing.Point(418, 0);
            this.pnlPlaylist.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlPlaylist.Name = "pnlPlaylist";
            this.pnlPlaylist.Size = new System.Drawing.Size(619, 401);
            this.pnlPlaylist.TabIndex = 4;
            // 
            // lstPlaylistSongs
            // 
            this.lstPlaylistSongs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstPlaylistSongs.FormattingEnabled = true;
            this.lstPlaylistSongs.Location = new System.Drawing.Point(0, 13);
            this.lstPlaylistSongs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstPlaylistSongs.Name = "lstPlaylistSongs";
            this.lstPlaylistSongs.Size = new System.Drawing.Size(619, 388);
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
            this.splitter2.Location = new System.Drawing.Point(412, 0);
            this.splitter2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(6, 401);
            this.splitter2.TabIndex = 3;
            this.splitter2.TabStop = false;
            // 
            // pnlKnoppen
            // 
            this.pnlKnoppen.BackColor = System.Drawing.SystemColors.Control;
            this.pnlKnoppen.Controls.Add(this.btnVerwijderPlayList);
            this.pnlKnoppen.Controls.Add(this.btnVoegToePlayList);
            this.pnlKnoppen.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlKnoppen.Location = new System.Drawing.Point(360, 0);
            this.pnlKnoppen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlKnoppen.Name = "pnlKnoppen";
            this.pnlKnoppen.Size = new System.Drawing.Size(52, 401);
            this.pnlKnoppen.TabIndex = 2;
            // 
            // btnVerwijderPlayList
            // 
            this.btnVerwijderPlayList.Location = new System.Drawing.Point(8, 49);
            this.btnVerwijderPlayList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVerwijderPlayList.Name = "btnVerwijderPlayList";
            this.btnVerwijderPlayList.Size = new System.Drawing.Size(40, 29);
            this.btnVerwijderPlayList.TabIndex = 1;
            this.btnVerwijderPlayList.Tag = "<<";
            this.btnVerwijderPlayList.Text = "<<";
            this.btnVerwijderPlayList.UseVisualStyleBackColor = true;
            this.btnVerwijderPlayList.Click += new System.EventHandler(this.btnVerwijderPlayList_Click);
            // 
            // btnVoegToePlayList
            // 
            this.btnVoegToePlayList.Location = new System.Drawing.Point(8, 15);
            this.btnVoegToePlayList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVoegToePlayList.Name = "btnVoegToePlayList";
            this.btnVoegToePlayList.Size = new System.Drawing.Size(40, 29);
            this.btnVoegToePlayList.TabIndex = 0;
            this.btnVoegToePlayList.Tag = ">>";
            this.btnVoegToePlayList.Text = ">>";
            this.btnVoegToePlayList.UseVisualStyleBackColor = true;
            this.btnVoegToePlayList.Click += new System.EventHandler(this.btnVerwijderPlayList_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(354, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(6, 401);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // pnlAlleSongs
            // 
            this.pnlAlleSongs.Controls.Add(this.lstAlleSongs);
            this.pnlAlleSongs.Controls.Add(this.label1);
            this.pnlAlleSongs.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlAlleSongs.Location = new System.Drawing.Point(0, 0);
            this.pnlAlleSongs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlAlleSongs.Name = "pnlAlleSongs";
            this.pnlAlleSongs.Size = new System.Drawing.Size(354, 401);
            this.pnlAlleSongs.TabIndex = 0;
            // 
            // lstAlleSongs
            // 
            this.lstAlleSongs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstAlleSongs.FormattingEnabled = true;
            this.lstAlleSongs.Location = new System.Drawing.Point(0, 13);
            this.lstAlleSongs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstAlleSongs.Name = "lstAlleSongs";
            this.lstAlleSongs.Size = new System.Drawing.Size(354, 388);
            this.lstAlleSongs.TabIndex = 1;
            this.lstAlleSongs.SelectedIndexChanged += new System.EventHandler(this.lstAlleSongs_SelectedIndexChanged);
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
            this.btnStopPlay.Location = new System.Drawing.Point(134, 67);
            this.btnStopPlay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStopPlay.Name = "btnStopPlay";
            this.btnStopPlay.Size = new System.Drawing.Size(903, 52);
            this.btnStopPlay.TabIndex = 2;
            this.btnStopPlay.Text = "Playlist stoppen";
            this.btnStopPlay.UseVisualStyleBackColor = true;
            this.btnStopPlay.Click += new System.EventHandler(this.btnStopPlay_Click);
            // 
            // btnStartPlay
            // 
            this.btnStartPlay.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStartPlay.Location = new System.Drawing.Point(134, 0);
            this.btnStartPlay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStartPlay.Name = "btnStartPlay";
            this.btnStartPlay.Size = new System.Drawing.Size(903, 67);
            this.btnStartPlay.TabIndex = 1;
            this.btnStartPlay.Text = "Playlist afspelen";
            this.btnStartPlay.UseVisualStyleBackColor = true;
            this.btnStartPlay.Click += new System.EventHandler(this.btnStartPlay_Click);
            // 
            // btnVoegSongToe
            // 
            this.btnVoegSongToe.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnVoegSongToe.Location = new System.Drawing.Point(0, 0);
            this.btnVoegSongToe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVoegSongToe.Name = "btnVoegSongToe";
            this.btnVoegSongToe.Size = new System.Drawing.Size(134, 119);
            this.btnVoegSongToe.TabIndex = 0;
            this.btnVoegSongToe.Text = "Song zoeken ...";
            this.btnVoegSongToe.UseVisualStyleBackColor = true;
            this.btnVoegSongToe.Click += new System.EventHandler(this.btnVoegSongToe_Click);
            // 
            // tabServer
            // 
            this.tabServer.Location = new System.Drawing.Point(4, 22);
            this.tabServer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabServer.Name = "tabServer";
            this.tabServer.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabServer.Size = new System.Drawing.Size(1183, 620);
            this.tabServer.TabIndex = 1;
            this.tabServer.Text = "TCP/IP Server";
            this.tabServer.UseVisualStyleBackColor = true;
            // 
            // tabPlaylist
            // 
            this.tabPlaylist.Location = new System.Drawing.Point(4, 22);
            this.tabPlaylist.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPlaylist.Name = "tabPlaylist";
            this.tabPlaylist.Size = new System.Drawing.Size(1183, 620);
            this.tabPlaylist.TabIndex = 2;
            this.tabPlaylist.Text = "PlayLijsten database";
            this.tabPlaylist.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "mp3";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "mp3 files (*.mp3)|*.mp3|mp4 files (*.mp4)|*.mp4|mov files (*.mov)|*.mov";
            // 
            // tssMediaPlayer
            // 
            this.tssMediaPlayer.ForeColor = System.Drawing.Color.Red;
            this.tssMediaPlayer.Name = "tssMediaPlayer";
            this.tssMediaPlayer.Size = new System.Drawing.Size(115, 17);
            this.tssMediaPlayer.Text = "Mediaplayer gestopt";
            // 
            // tssTCPServer
            // 
            this.tssTCPServer.ForeColor = System.Drawing.Color.Red;
            this.tssTCPServer.Name = "tssTCPServer";
            this.tssTCPServer.Size = new System.Drawing.Size(120, 17);
            this.tssTCPServer.Text = "TCP/IP Server gestopt";
            // 
            // tssClient
            // 
            this.tssClient.ForeColor = System.Drawing.Color.Red;
            this.tssClient.Name = "tssClient";
            this.tssClient.Size = new System.Drawing.Size(121, 17);
            this.tssClient.Text = "Client niet verbonden";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(12, 17);
            this.toolStripStatusLabel4.Text = "-";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(12, 17);
            this.toolStripStatusLabel5.Text = "-";
            // 
            // frmServerMediaPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 575);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripStatusLabel tssMediaPlayer;
        private System.Windows.Forms.ToolStripStatusLabel tssTCPServer;
        private System.Windows.Forms.ToolStripStatusLabel tssClient;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
    }
}

