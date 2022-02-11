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
        public List<string> lstPad = new List<string>();
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
                    lstPad.Add(file);
                    lstAlleSongs.Items.Add(Path.GetFileNameWithoutExtension(file));
                }
            }
            //afspeellijst aanmaken
            Player.currentPlaylist = Player.newPlaylist("Klas", pad);
        }

        private void frmServerMediaPlayer_Shown(object sender, EventArgs e)
        {
            pnlAlleSongs.Width = (splitContMediaPlayer.Panel1.Width - pnlKnoppen.Width) / 2;
        }

        private void btnStartPlay_Click(object sender, EventArgs e)
        {
            Player.controls.play();
            tssMediaPlayer.Text = "Mediaplayer speelt af";
            tssMediaPlayer.ForeColor = Color.Green;
        }

        private void btnStopPlay_Click(object sender, EventArgs e)
        {
            Player.controls.stop();
            tssMediaPlayer.Text = "Mediaplayer gestopt";
            tssMediaPlayer.ForeColor = Color.Red;
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
                    lstAlleSongs.Items.Add(Path.GetFileNameWithoutExtension(openFileDialog1.FileName));
                    File.Copy(openFileDialog1.FileName, pad + "\\" +Path.GetFileName(openFileDialog1.FileName));
                    lstPad.Add(openFileDialog1.FileName);
                }
            }
        }

        private void btnVerwijderPlayList_Click(object sender, EventArgs e)
        {
            string pad = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "muziek");
            Button btn = sender as Button;
            if (lstAlleSongs.SelectedIndex > -1 || lstPlaylistSongs.SelectedIndex > -1)
            {
                switch (btn.Tag.ToString())
                {
                    case "<<":
                        if (lstPlaylistSongs.SelectedIndex == -1) return; //niets geselecteerd
                        int selectie = lstPlaylistSongs.SelectedIndex;
                        lstPlaylistSongs.Items.Remove(lstPlaylistSongs.SelectedItem);
                        //verwijderen uit Playlist
                        WMPLib.IWMPMedia listItem = Player.currentPlaylist.get_Item(selectie);
                        Player.currentPlaylist.removeItem(listItem);
                        if (lstPlaylistSongs.Items.Count < 1)
                        {
                            Player.controls.stop();
                            tssMediaPlayer.Text = "Mediaplayer gestopt";
                            tssMediaPlayer.ForeColor = Color.Red;
                        }
                        break;
                    case ">>":
                        if (lstAlleSongs.SelectedIndex == -1) return;
                        if (lstPlaylistSongs.Items.Contains(lstAlleSongs.SelectedItem.ToString())) { MessageBox.Show("Deze song bestaat al!"); return; }
                        lstPlaylistSongs.Items.Add(lstAlleSongs.SelectedItem);
                        //toevoegen aan PlayList
                        string padnaam = pad + "\\" + lstAlleSongs.Text + ".mp3";
                        Player.currentPlaylist.appendItem(Player.newMedia(padnaam));
                        //this.Text = padnaam;
                        break;
                }
            }
        }

        private void lstAlleSongs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
