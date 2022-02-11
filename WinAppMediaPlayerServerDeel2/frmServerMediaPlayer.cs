using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//extra bibliotheken MediaPlayer
using WMPLib;
using System.IO;

namespace WinAppMediaPlayerVersie2
{
    public partial class frmServerMediaPlayer : Form
    {
        public frmServerMediaPlayer()
        {
            InitializeComponent();
        }

        private void frmServerMediaPlayer_Shown(object sender, EventArgs e)
        {
            pnlAlleSongs.Width = (splitContMediaPlayer.Panel1.Width - pnlKnoppen.Width) / 2;
        }

        private void frmServerMediaPlayer_Load(object sender, EventArgs e)
        {
            //huidige muziek laden
            string pad = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(Application.ExecutablePath), "Muziek");
            if (!System.IO.Directory.Exists(pad))
            {
                System.IO.Directory.CreateDirectory(pad);
            }
            //alle bestanden in map Muziek overlopen
            foreach (string file in Directory.GetFiles(pad))
            {
                // voeg toe aan resultaat als mp3 extensie (alle bestanden krijgen deze extensie als we ze naar deze map kopiëren
                if (Path.GetExtension(file) == ".mp3")
                {
                    lstAlleSongs.Items.Add(Path.GetFileNameWithoutExtension(file));
                }
            }
            //afspeellijst aanmaken
            Player.currentPlaylist = Player.newPlaylist("Klas", "");
        }
        #region MediaPlayer

        WindowsMediaPlayer Player = new WindowsMediaPlayer();
        

        private void btnVoegSongToe_Click(object sender, EventArgs e)
        {
            if(ofdZoekSong.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string titel = Path.GetFileNameWithoutExtension(ofdZoekSong.FileName), padsong = ofdZoekSong.FileName;
                if (!File.Exists(padsong)) { MessageBox.Show("Dit bestand kan niet gevonden worden!"); return; }
                if (lstAlleSongs.Items.Contains(titel)) { MessageBox.Show("Deze song staat al in de lijst!"); return; }
                string padmap = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(Application.ExecutablePath), "muziek");
                if (!System.IO.Directory.Exists(padmap))
                {
                    System.IO.Directory.CreateDirectory(padmap);
                }
                //bestand kopiëren naar map muziek             
                System.IO.File.Copy(padsong, padmap + "\\" + titel + ".mp3");
                //toevoegen aan lijst
                lstAlleSongs.Items.Add(titel);
            }
        }

        private void btnVoegToePlayList_Click(object sender, EventArgs e)
        {
            if (lstAlleSongs.SelectedIndex == -1) return; //niets geselecteerd
            if (lstPlaylistSongs.Items.Contains(lstAlleSongs.SelectedItem.ToString())) { MessageBox.Show("Deze song bestaat al!"); return; }
            lstPlaylistSongs.Items.Add(lstAlleSongs.SelectedItem);
            //toevoegen aan PlayList
            string padsong = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(Application.ExecutablePath), "muziek") + "\\" + lstAlleSongs.SelectedItem.ToString() + ".mp3";
            Player.currentPlaylist.appendItem(Player.newMedia(padsong));
        }

        private void btnVerwijderPlayList_Click(object sender, EventArgs e)
        {
            if (lstPlaylistSongs.SelectedIndex == -1 ) return;// niets geselecteerd
            int selectie = lstPlaylistSongs.SelectedIndex;
            string song = lstPlaylistSongs.Items[selectie].ToString();
            lstPlaylistSongs.Items.RemoveAt(selectie);
            //verwijderen uit Playlist
            WMPLib.IWMPMedia listItem = Player.currentPlaylist.get_Item(selectie);
            Player.currentPlaylist.removeItem(listItem);
            if(Player.currentPlaylist.count ==0 ) 
            {
                tssMediaPlayer.Text = "Mediaplayer gestopt";
                tssMediaPlayer.ForeColor = Color.Red;
            }
        }

        private void btnStartPlay_Click(object sender, EventArgs e)
        {
            Player.controls.play();
            tssMediaPlayer.Text = "Mediaplayer speelt muziek";
            tssMediaPlayer.ForeColor = Color.Green;
        }

        private void btnStopPlay_Click(object sender, EventArgs e)
        {
            Player.controls.stop();
            tssMediaPlayer.Text = "Mediaplayer gestopt";
            tssMediaPlayer.ForeColor = Color.Red;
        }
        #endregion
    }
}
