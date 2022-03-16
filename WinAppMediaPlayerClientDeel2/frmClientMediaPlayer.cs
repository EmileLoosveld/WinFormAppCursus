using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            //Controle IP-adres
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
            //verbinding met de server
            try
            {
                client = new TcpClient();
                client.Connect(ipadres, poortNr);
                if (client != null && client.Connected)
                {
                    Writer = new StreamWriter(client.GetStream());
                    Reader = new StreamReader(client.GetStream());
                    Writer.AutoFlush = true;
                    bgWorkerOntvang.WorkerSupportsCancellation = true;
                    bgWorkerOntvang.RunWorkerAsync(); //Start ontvangen data
                    btnZoekServer.Enabled = false;
                    btnVerbreek.Enabled = true;
                    splitContainer1.Panel2.Enabled = true;
                    pnlMediaPlayer.Enabled = true;
                    tssClient.Text = "Client verbonden";
                    tssClient.ForeColor = Color.Green;
                }
            }
            catch (Exception)
            {
                txtMelding.AppendText("Kan geen verbinding maken!\r\n");
            }
        }
        bool songlistadd = false, playlistremove = false, playlistadd = false;
        private void bgWorkerOntvang_DoWork(object sender, DoWorkEventArgs e)
        {
            while (client != null && client.Connected)
            {
                string bericht;

                try
                {
                    bericht = Reader.ReadLine();
                    if (bericht == "COMMANDEND")
                    {
                        songlistadd = false;
                        playlistremove = false;
                        playlistadd = false;
                    }

                    if (bericht == "Disconnect") break;
                    this.txtCommunicatie.Invoke(new MethodInvoker(
                        delegate ()
                        {
                            txtCommunicatie.AppendText(bericht + "\r\n");
                        }));
                    if (songlistadd == true)
                    {
                        this.txtCommunicatie.Invoke(new MethodInvoker(
                        delegate ()
                        {
                            lstSong.Items.Add(bericht);
                        }));
                    }
                    if (playlistremove == true)
                    {
                        this.txtCommunicatie.Invoke(new MethodInvoker(
                        delegate ()
                        {
                            lstSongPlayList.Items.Remove(bericht);
                        }));
                    }
                    if (playlistadd == true)
                    {
                        this.txtCommunicatie.Invoke(new MethodInvoker(
                        delegate ()
                        {
                            lstSongPlayList.Items.Add(bericht);
                        }));
                    }
                    if (bericht == "SONGLISTADD")
                    {
                        songlistadd = true;
                    }
                    if (bericht == "PLAYLISTADD")
                    {
                        playlistadd = true;
                    }
                    if (bericht == "PLAYLISTREMOVE")
                    {
                        playlistremove = true;
                    }


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
            txtMelding.AppendText("Verbinding met server werd verbroken. \r\n");
            btnVerbreek.Enabled = false;
            btnZoekServer.Enabled = true;
            splitContainer1.Panel2.Enabled = false;
            pnlMediaPlayer.Enabled = false;
            tssClient.Text = "Client niet verbonden";
            tssClient.ForeColor = Color.Red;
        }

        private void btnZend_Click(object sender, EventArgs e)
        {
            try
            {
                if (client != null && client.Connected)
                {
                    Writer.WriteLine("CLIENT  >>> " + txtBericht.Text);
                    txtCommunicatie.AppendText("CLIENT  >>> " + txtBericht.Text + "\r\n");

                }
            }
            catch
            {
                txtMelding.AppendText("Bericht zenden mislukt");
            }
        }

        private void btnVerbreek_Click(object sender, EventArgs e)
        {
            try
            {
                Writer.WriteLine("Disconnect");
                bgWorkerOntvang.CancelAsync();
                client.Close();
                txtMelding.AppendText("Verbinding verborken door Client!\r\n");
            }
            catch
            {
                txtMelding.AppendText("Verbinding verbreken doro Client mislukt");
            }
        }

        private void frmClientMediaPlayer_Load(object sender, EventArgs e)
        {

        }

        private void btnVoegToePlayList_Click(object sender, EventArgs e)
        {
            if (lstSong.SelectedIndex != -1)
            {
                if (lstSongPlayList.Items.Contains(lstSong.SelectedItem))
                {

                }
                else
                {
                    lstSongPlayList.Items.Add(lstSong.SelectedItem);

                }

                try
                {
                    if (client != null && client.Connected)
                    {
                        Writer.WriteLine("PLAYLISTADD");
                        Writer.WriteLine(lstSong.SelectedItem);
                        Writer.WriteLine("COMMANDEND");

                    }
                }
                catch
                {
                    txtMelding.AppendText("Bericht zenden mislukt");
                }
            }
        }

        private void btnVerwijderPlayList_Click(object sender, EventArgs e)
        {
            if (lstSongPlayList.SelectedIndex != -1)
            {

                try
                {
                    if (client != null && client.Connected)
                    {

                        Writer.WriteLine("PLAYLISTREMOVE");
                        Writer.WriteLine(lstSongPlayList.SelectedItem);
                        Writer.WriteLine("COMMANDEND");
                        lstSongPlayList.Items.Remove(lstSongPlayList.SelectedItem);
                    }
                }
                catch
                {
                    txtMelding.AppendText("Bericht zenden mislukt");
                }
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            try
            {
                if (client != null && client.Connected)
                {
                    Writer.WriteLine("PLAY");
                    txtCommunicatie.AppendText("PLAY" + "\r\n");

                }
            }
            catch
            {
                txtMelding.AppendText("Bericht zenden mislukt");
            }
        }

        private void btnStopPlay_Click(object sender, EventArgs e)
        {
            try
            {
                if (client != null && client.Connected)
                {
                    Writer.WriteLine("STOP");
                    txtCommunicatie.AppendText("STOP" + "\r\n");
                }
            }
            catch
            {
                txtMelding.AppendText("Bericht zenden mislukt");
            }
        }
    }
}
