using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//namespaces nodig voor TCP/IP communicatie
using System.IO;
using System.Net.Sockets;
using System.Net;

namespace WinAppMediaPlayerClientVersie2
{
    public partial class frmClientMediaPlayer : Form
    {
        TcpClient client;
        StreamReader Reader;
        StreamWriter Writer;
        public frmClientMediaPlayer()
        {
            InitializeComponent();
        }

        private void btnZoekServer_Click(object sender, EventArgs e)
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
            //verbinding maken met server
            try
            {
                client = new TcpClient();
                client.Connect(ipadres, poortNr);
                if (client.Connected)
                {
                    Writer = new StreamWriter(client.GetStream());
                    Reader = new StreamReader(client.GetStream());
                    Writer.AutoFlush = true;
                    bgWorkerOntvang.WorkerSupportsCancellation = true;
                    bgWorkerOntvang.RunWorkerAsync();//start ontvangen data
                    btnZoekServer.Enabled = false;
                    btnVerbreek.Enabled = true;
                    splitContainer1.Panel2.Enabled = true;
                    pnlMediaPlayer.Enabled = true;
                    txtMelding.AppendText("Verbinding met Server!\r\n");
                    tssClient.Text = "Client verbonden"; tssClient.ForeColor = Color.Green;
                }
            }
            catch (Exception)
            {
                txtMelding.AppendText("Client kan geen verbinding maken!\r\n");
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
                    if (bericht == null) continue;
                    if (bericht == "Disconnect") break;
                    else if (bericht.Contains("SONGLISTADD"))
                    {
                        bericht = bericht.Replace("SONGLISTADD", "");
                        if (!this.lstSong.Items.Contains(bericht)) this.lstSong.Invoke(new MethodInvoker(delegate () { this.lstSong.Items.Add(bericht); }));
                    }
                    else if (bericht.Contains("PLAYLISTADD"))
                    {
                        bericht = bericht.Replace("PLAYLISTADD", "");
                        if (!this.lstSongPlayList.Items.Contains(bericht)) this.lstSongPlayList.Invoke(new MethodInvoker(delegate () { this.lstSongPlayList.Items.Add(bericht); }));
                    }
                    else if (bericht.Contains("PLAYLISTREMOVE"))
                    {
                        bericht = bericht.Replace("PLAYLISTREMOVE", "");
                        if (this.lstSongPlayList.Items.Contains(bericht))
                        {
                            int selectie = lstSongPlayList.Items.IndexOf(bericht);
                            this.lstSongPlayList.Invoke(new MethodInvoker(delegate () { this.lstSongPlayList.Items.RemoveAt(selectie); }));
                        }

                    }
                    else if (bericht.Contains("PLAYLISTCLEAR"))
                    {
                        this.lstSongPlayList.Invoke(new MethodInvoker(delegate () { lstSongPlayList.Items.Clear(); }));

                    }
                    else
                        this.txtCommunicatie.Invoke(new MethodInvoker(
                        delegate ()
                        {
                            txtCommunicatie.AppendText(bericht + "\r\n");
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
            txtMelding.AppendText("Verbinding met Server werd verbroken.\r\n");
            btnVerbreek.Enabled = false;
            btnZoekServer.Enabled = true;
            lstSong.Items.Clear();
            lstSongPlayList.Items.Clear();
            splitContainer1.Panel2.Enabled = false;
            pnlMediaPlayer.Enabled = false;
            tssClient.Text = "Client niet verbonden"; tssClient.ForeColor = Color.Red;
        }

        private void btnVerbreek_Click(object sender, EventArgs e)
        {
            try
            {
                Writer.WriteLine("Disconnect");
                bgWorkerOntvang.CancelAsync();
                client.Close();
                txtMelding.AppendText("Verbinding verbroken door Client!\r\n");              
            }
            catch
            {
                txtMelding.AppendText("Verbinding verbreken door Client mislukt!\r\n");
            }
        }

        private void btnZend_Click(object sender, EventArgs e)
        {
            try
            {
                Writer.WriteLine("CLIENT >>>" + txtBericht.Text);
                txtCommunicatie.AppendText("CLIENT >>>" + txtBericht.Text + "\r\n");
            }
            catch
            {
                txtMelding.AppendText("Bericht zenden mislukt");
            }
        }

        private void btnVoegToePlayList_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstSong.SelectedIndex == -1) return; //niets geselecteerd
                if (lstSongPlayList.Items.Contains(lstSong.SelectedItem.ToString())) { MessageBox.Show("Deze song bestaat al!"); return; }
                lstSongPlayList.Items.Add(lstSong.SelectedItem);
                Writer.WriteLine("PLAYLISTADD" + lstSong.SelectedItem.ToString());
            }
            catch (Exception)
            {

            }
        }

        private void btnVerwijderPlayList_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstSongPlayList.SelectedIndex == -1) return;// niets geselecteerd
                Writer.WriteLine("PLAYLISTREMOVE" + lstSongPlayList.SelectedItem.ToString());
                lstSongPlayList.Items.RemoveAt(lstSongPlayList.SelectedIndex);
            }
            catch (Exception)
            {

            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            try
            {
                Writer.WriteLine("PLAY");
            }
            catch (Exception)
            {

            }
        }

        private void btnStopPlay_Click(object sender, EventArgs e)
        {
            try
            {

                Writer.WriteLine("STOPPLAY");

            }
            catch (Exception)
            {

            }
        }

        private void frmClientMediaPlayer_Load(object sender, EventArgs e)
        {

        }
    }
}
