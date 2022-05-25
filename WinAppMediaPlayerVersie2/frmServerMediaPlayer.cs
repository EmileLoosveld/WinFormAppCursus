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
//extra bibliotheken Server
using System.Net;
using System.Net.Sockets;

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
            // TODO: This line of code loads data into the 'dataMediaPlayerDataSet.PlayList' table. You can move, or remove it, as needed.
            this.playListTableAdapter.Fill(this.dataMediaPlayerDataSet.PlayList);
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
            comboBoxLaden();
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
                string padmap = Path.Combine(System.IO.Path.GetDirectoryName(Application.ExecutablePath), "muziek");
                if (!System.IO.Directory.Exists(padmap))
                {
                    System.IO.Directory.CreateDirectory(padmap);
                }
                //bestand kopiëren naar map muziek             
                System.IO.File.Copy(padsong, padmap + "\\" + titel + ".mp3");
                //toevoegen aan lijst
                lstAlleSongs.Items.Add(titel);
                if (client != null && client.Connected) Writer.WriteLine("SONGLISTADD" + titel);

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
            //doorsturen naar Client als verbonden
            if(client != null && client.Connected)Writer.WriteLine("PLAYLISTADD" + lstAlleSongs.SelectedItem.ToString());
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
            //doorsturen naar Client
            if (client!=null && client.Connected) Writer.WriteLine("PLAYLISTREMOVE" + song);
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
        #region Server
        TcpListener listener;
        TcpClient client;
        StreamWriter Writer;
        StreamReader Reader;
        private void chkbStartStopServer_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbStartStopServer.Checked)//knop ingedrukt
            {
                //controle Ip-adres
                IPAddress ipadres;
                int poortNr;
                if (!IPAddress.TryParse(mtxtIPadres.Text.Replace(" ", ""), out ipadres))
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
                    chkbStartStopServer.Text = "Stop Server";
                    tssTCPServer.Text = "TCP/IP Server gestart";tssTCPServer.ForeColor = Color.Green;
                }
                catch
                {
                    txtMelding.AppendText("Server kan niet gestart worden," +
                        "controleeer IPAdres en Poortnummer!\r\n");
                    chkbStartStopServer.Checked = false;
                }
            }
            else //server stoppen
            {
                if (client != null && client.Connected)
                {//eerst client stopbericht sturen
                    Writer.WriteLine("Disconnect");
                    bgWorkerOntvang.CancelAsync();
                }
                try//server stoppen
                {
                    if (listener != null)
                    {
                        if (client != null && client.Connected) client.Close();
                        listener.Stop();
                    }
                    chkbStartStopServer.Text = "Start Server";
                    txtMelding.AppendText("Server gestopt!\r\n");
                    tssTCPServer.Text = "TCP/IP Server gestopt"; tssTCPServer.ForeColor = Color.Red;
                }
                catch
                {
                    txtMelding.AppendText("Server kan niet gestopt worden.\r\n");
                }
            }
        }

        private void bgWorkerListener_DoWork(object sender, DoWorkEventArgs e)
        {
            client = listener.AcceptTcpClient();//1 client aanvaarden
        }

        private void bgWorkerListener_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //listener stop met wachten als client verbonden is
            //of als hij gestopt werd -> dan client niet starten
            if (client != null && client.Connected)
            {
                //communicatie met client opzetten
                Reader = new StreamReader(client.GetStream());
                Writer = new StreamWriter(client.GetStream());
                Writer.AutoFlush = true;
                bgWorkerOntvang.WorkerSupportsCancellation = true;
                bgWorkerOntvang.RunWorkerAsync();//start ontvangen data
                btnVerbreek.Enabled = true;
                txtMelding.AppendText("Client verbonden!\r\n");
                splitContainer1.Panel2.Enabled = true;
                tssClient.Text = "Client verbonden"; tssClient.ForeColor = Color.Green;

            }
        }

        private void bgWorkerOntvang_DoWork(object sender, DoWorkEventArgs e)
        {
            foreach (string song in lstAlleSongs.Items)
            {
                Writer.WriteLine("SONGLISTADD" + song.ToString());
            }
            foreach (string song in lstPlaylistSongs.Items)
            {
                Writer.WriteLine("PLAYLISTADD" + song.ToString());
            }
            while (client.Connected)
            {
                string bericht;
                try
                {
                    bericht = Reader.ReadLine();
                    if (bericht == "Disconnect") break;
                    else if (bericht.Contains("PLAYLISTADD"))
                    {
                        bericht = bericht.Replace("PLAYLISTADD", "");
                        if (!lstPlaylistSongs.Items.Contains(bericht))
                        {
                            int zoeksong = lstAlleSongs.Items.IndexOf(bericht);
                            if (zoeksong != -1)
                            {
                                lstPlaylistSongs.Invoke(new MethodInvoker(delegate () { lstPlaylistSongs.Items.Add(lstAlleSongs.Items[zoeksong]); }));
                                //toevoegen aan PlayList
                                string padsong = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(Application.ExecutablePath), "muziek") + "\\" + lstAlleSongs.Items[zoeksong].ToString() + ".mp3";
                                Player.currentPlaylist.appendItem(Player.newMedia(padsong));
                            }
                        }
                    }
                    else if (bericht.Contains("PLAYLISTREMOVE"))
                    {
                        bericht = bericht.Replace("PLAYLISTREMOVE", "");
                        if (lstPlaylistSongs.Items.Contains(bericht))
                        {
                            int zoeksong = lstPlaylistSongs.Items.IndexOf(bericht);
                            if (zoeksong != -1)
                            {
                                lstPlaylistSongs.Invoke(new MethodInvoker(delegate () { lstPlaylistSongs.Items.RemoveAt(zoeksong); }));
                                //verwijderen uit PlayList
                                WMPLib.IWMPMedia listItem = Player.currentPlaylist.get_Item(zoeksong);
                                Player.currentPlaylist.removeItem(listItem);

                            }
                        }
                    }
                    else if (bericht == "STOPPLAY")
                    {
                        Player.controls.stop();
                    }
                    else if (bericht == "PLAY")
                    {
                        Player.controls.play();
                    }
                    else
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
            txtMelding.AppendText("Verbinding met Client is verbroken!\r\n");
            btnVerbreek.Enabled = false;
            splitContainer1.Panel2.Enabled = false;
            tssClient.Text = "Client niet verbonden";tssClient.ForeColor = Color.Red;
            //bgWorkerlistener opnieuw starten als server nog gestart is
            if (chkbStartStopServer.Checked)
                bgWorkerListener.RunWorkerAsync();
        }

        private void btnVerbreek_Click(object sender, EventArgs e)
        {
            Writer.Write("Disconnect");
            client.Close();
        }
        private void btnZend_Click(object sender, EventArgs e)
        {
            try
            {
                Writer.WriteLine("SERVER >>>" + txtZend.Text);
                txtOntvang.AppendText("SERVER>>>" + txtZend.Text + "\r\n");
            }
            catch
            {
                txtMelding.AppendText("Berichten zenden mislukt\r\n");
            }
        }

        #endregion
        #region Database
        private void comboBoxLaden()
        {
            cmbPlayList.Items.Clear();
            this.playListTableAdapter.Fill(this.dataMediaPlayerDataSet.PlayList);
            foreach (DataRow rij in this.dataMediaPlayerDataSet.PlayList)
            {
                if (!cmbPlayList.Items.Contains(rij["PlayListNaam"].ToString()))
                    cmbPlayList.Items.Add(rij["PlayListNaam"].ToString());
            }
        }
        private void cmbPlayList_TextChanged(object sender, EventArgs e)
        {
            if (cmbPlayList.Text != "")
            {
                this.playListTableAdapter.FillByPlayListNaam(this.dataMediaPlayerDataSet.PlayList, cmbPlayList.Text);
                playListDataGridView.Visible = true;
                playListDataGridView.Enabled = true;
                playListBindingNavigator.Enabled = true;
                bindingNavigatorDeleteItem.Enabled = true;
            }
            else
            {
                playListDataGridView.Visible = false;
                playListBindingNavigator.Enabled = false;
            }
        }
        private void btnVoegSongsToeAanDatabase_Click(object sender, EventArgs e)
        {
            if (!(cmbPlayList.Text == String.Empty))
            {
                List<string> lied = playListDataGridView.Rows.OfType<DataGridViewRow>().Select(x => x.Cells[2].Value.ToString()).ToList();
                foreach (string playlistSong in lstPlaylistSongs.Items)
                {
                    if (!lied.Contains(playlistSong))
                        this.playListTableAdapter.InsertQuery(cmbPlayList.Text, playlistSong.ToString(), Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "muziek") + "\\" + playlistSong.ToString() + ".mp3");
                }
                comboBoxLaden();
                this.playListTableAdapter.FillByPlayListNaam(this.dataMediaPlayerDataSet.PlayList, cmbPlayList.Text);

            }
            else
            {
                MessageBox.Show("Vul een naam in in de combobox!");
            }
            bindingNavigatorDeleteItem.Enabled = true;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if(lstPlaylistSongs.Items.Count != 0)
            {
                for (int count = 0; count != lstPlaylistSongs.Items.Count - 1; count++)
                {
                    string song = lstPlaylistSongs.Items[count].ToString();
                    //verwijderen uit Playlist
                    WMPLib.IWMPMedia listItem = Player.currentPlaylist.get_Item(count);
                    Player.currentPlaylist.removeItem(listItem);
                    //doorsturen naar Client
                }
                if (client != null && client.Connected) Writer.WriteLine("PLAYLISTCLEAR");

            }
            lstPlaylistSongs.Items.Clear();
            List<string> lied = playListDataGridView.Rows.OfType<DataGridViewRow>().Select(x => x.Cells[2].Value.ToString()).ToList();
            bool foutmelding = false;
            foreach (string song in lied)
            {
                if (lstAlleSongs.Items.Contains(song))
                {
                    lstPlaylistSongs.Items.Add(song);
                    string padsong = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "muziek") + "\\" + song.ToString() + ".mp3";
                    Player.currentPlaylist.appendItem(Player.newMedia(padsong));
                    //doorsturen naar Client als verbonden
                    if (client != null && client.Connected) Writer.WriteLine("PLAYLISTADD" + song.ToString());
                }
                else
                    foutmelding = true;
            }
            if (foutmelding == true)
                MessageBox.Show("één of meerdere songs zijn niet aangewezig in de songlist! Deze zijn niet toegevoegd aan de playlist!");
        }
        #endregion

        private void playListBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.playListBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataMediaPlayerDataSet);

        }

       

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.playListBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataMediaPlayerDataSet);
            if (playListDataGridView.Rows.Count == 0)
            {
                comboBoxLaden();
                playListDataGridView.Visible = false;
                cmbPlayList.Text = String.Empty;
            }
        }
    }
}
