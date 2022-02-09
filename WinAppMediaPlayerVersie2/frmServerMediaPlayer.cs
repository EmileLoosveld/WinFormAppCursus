using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using System.IO;

namespace WinAppMediaPlayerVersie2
{
    public partial class frmServerMediaPlayer : Form
    {
        WindowsMediaPlayer Player = new WindowsMediaPlayer();
        public frmServerMediaPlayer()
        {
            InitializeComponent();
        }
        private void frmServerMediaPlayer_Load(object sender, EventArgs e)
        {
            string pad = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "muziek");
            if (!Directory.Exists(pad))
                Directory.CreateDirectory(pad);

            foreach (string file in Directory.GetFiles(pad))
            {
                if (Path.GetExtension(file) == ".mp3")
                {
                    lstAlleSongs.Items.Add(Path.GetFileName(file));
                }
            }
            //afspeellijst aanmaken
            Player.currentPlaylist = Player.newPlaylist("Klas", "");
        }

        private void frmServerMediaPlayer_Shown(object sender, EventArgs e)
        {
            pnlAlleSongs.Width = (splitContMediaPlayer.Panel1.Width - pnlKnoppen.Width) / 2;
        }

        private void btnStartPlay_Click(object sender, EventArgs e)
        {
            string pad = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "muziek", lstPlaylistSongs.SelectedItem.ToString());
            this.Text = pad;
            Player.URL = pad;
        }

        private void btnStopPlay_Click(object sender, EventArgs e)
        {
            Player.controls.stop();
        }

        private void btnVoegSongToe_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string pad = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "muziek");
                if (!Directory.Exists(pad))
                    Directory.CreateDirectory(pad);
                if (lstAlleSongs.Items.Contains(Path.GetFileName(openFileDialog1.FileName)) == false)
                {
                    lstAlleSongs.Items.Add(Path.GetFileName(openFileDialog1.FileName));
                    File.Copy(openFileDialog1.FileName, pad + "\\" +Path.GetFileName(openFileDialog1.FileName));
                }
            }
        }

        private void btnVerwijderPlayList_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (lstAlleSongs.SelectedIndex > -1 || lstPlaylistSongs.SelectedIndex > -1)
            {
                switch (btn.Tag.ToString())
                {
                    case "<<":
                        lstAlleSongs.Items.Add(lstPlaylistSongs.SelectedItem);
                        lstPlaylistSongs.Items.Remove(lstPlaylistSongs.SelectedItem);
                        break;
                    case ">>":
                        lstPlaylistSongs.Items.Add(lstAlleSongs.SelectedItem);
                        lstAlleSongs.Items.Remove(lstAlleSongs.SelectedItem);
                        break;
                }
            }
        }
    }
}
