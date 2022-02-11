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
using System.Net.Sockets;
using System.Net;

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
        #region TCP/IP
        TcpListener listener;
        TcpClient client;
        StreamReader Reader;
        StreamWriter Writer;

        private void chkbStartStopServer_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbStartStopServer.Checked)
            {
                //Controle IP-adres
                IPAddress ipadres;
                int poortNr;
                if (!IPAddress.TryParse(mtxtIPadres.Text.Replace(" ", " "), out ipadres))
                {
                    txtMelding.AppendText("Ongeldig IPAdres!\r\n");
                    mtxtIPadres.Focus();
                    return;
                }
                if (!int.TryParse(mtxtPoortnr.Text, out poortNr))
                {
                    txtMelding.AppendText("Ongeldig poortnummer!\r\n");
                    mtxtPoortnr.Focus();
                    return;
                }
                //listener opzetten
                try
                {
                    listener = new TcpListener(ipadres, poortNr);
                    listener.Start();
                    //backgroundworker starten
                    bgWorkerListener.WorkerSupportsCancellation = true;
                    bgWorkerListener.RunWorkerAsync();
                    txtMelding.AppendText("Server opgestart!\r\n");
                    chkbStartStopServer.Text = "Stop server";
                }
                catch
                {
                    txtMelding.AppendText("Server kan niet gestart worden," + "controleer IPAdres en Poortnummer!\r\n");
                    chkbStartStopServer.Checked = false;
                }
                tssTCPServer.Text = "TCP/IP Server gestart";
                tssTCPServer.ForeColor = Color.Green;
            }
            else //server stoppen
            {
                if (client != null && client.Connected)
                {
                    Writer.WriteLine("Disconnect");
                    bgWorkerOntvang.CancelAsync();
                }
                try //server stoppen
                {
                    if (listener != null)
                    {
                        if (client != null && client.Connected) client.Close();
                        listener.Stop();
                    }
                    chkbStartStopServer.Text = "Start Server";
                    txtMelding.AppendText("Server gestopt!\r\n");
                    tssTCPServer.Text = "TCP/IP Server gestopt";
                    tssTCPServer.ForeColor = Color.Red;
                }
                catch
                {
                    txtMelding.AppendText("Server kan niet gestopt worden.\r\n");
                }
            }
        }

        private void bgWorkerOntvang_DoWork(object sender, DoWorkEventArgs e)
        {
            while (client.Connected)
            {
                string bericht;
                try
                {
                    bericht = Reader.ReadLine();
                    if (bericht == "Disconnect") break;
                    this.txtOntvang.Invoke(new MethodInvoker(
                        delegate ()
                        {
                            txtOntvang.AppendText(bericht + "\r\n");
                        }));
                }
                catch
                {
                    this.txtMelding.Invoke(new MethodInvoker(
                        delegate ()
                        {
                            txtMelding.AppendText("Kan bericht niet ontvangen.\r\n");
                        }));
                }
            }
        }

        private void bgWorkerOntvang_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Writer.Close();
            Reader.Close();
            client.Close();
            txtMelding.AppendText("Verbinding met client is verbroken!\r\n");
            btnVerbreek.Enabled = false;
            //bgworkerlistener opnieuw starten als server nog niet gestart is.
            if (chkbStartStopServer.Checked)
                bgWorkerListener.RunWorkerAsync();
            btnZend.Enabled = false;
            tssClient.Text = "Client niet verbonden";
            tssClient.ForeColor = Color.Red;
        }

        private void btnVerbreek_Click(object sender, EventArgs e)
        {
            Writer.WriteLine("Disconnect");
            client.Close();
        }

        private void bgWorkerListener_DoWork(object sender, DoWorkEventArgs e)
        {
            client = listener.AcceptTcpClient(); //1 client aanvaarden
        }

        private void bgWorkerListener_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //listener stop met wachten als client verbonden is
            //of als hij gestopt werd -> dan client niet starten
            if (client != null && client.Connected)
            {
                //Communicatie met client opzetten
                Reader = new StreamReader(client.GetStream());
                Writer = new StreamWriter(client.GetStream());
                Writer.AutoFlush = true;
                bgWorkerOntvang.WorkerSupportsCancellation = true;
                bgWorkerOntvang.RunWorkerAsync(); //start ontvangen data
                btnVerbreek.Enabled = true;
                txtMelding.AppendText("Client verbonden!\r\n");
                btnZend.Enabled = true;
                tssClient.Text = "Client verbonden";
                tssClient.ForeColor = Color.Green;
                //Sturen data van de song & playlist
                Writer.WriteLine("SONGLISTADD");
                foreach (string song in lstAlleSongs.Items)
                    Writer.Write(song);
                //Writer.WriteLine("SONGLISTADD" + lstAlleSongs.Items[0]);
                //Writer.WriteLine("PLAYLISTADD" + lstPlaylistSongs.Items[0]);
            }
        }

        #endregion

        private void btnZend_Click(object sender, EventArgs e)
        {
            try
            {
                Writer.WriteLine("SERVER >>> " + txtZend.Text);
                txtOntvang.AppendText("SERVER >>> " + txtZend.Text + "\r\n");
            }
            catch
            {
                txtMelding.AppendText("Bericht zenden mislukt\r\n");
            }
        }
    }
}
