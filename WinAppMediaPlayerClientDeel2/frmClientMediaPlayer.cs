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
                if (client.Connected)
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

        private void bgWorkerOntvang_DoWork(object sender, DoWorkEventArgs e)
        {
            while (client.Connected)
            {
                string bericht;
                try
                {
                    bericht = Reader.ReadLine();
                    if (bericht == "Disconnect") break;
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
                Writer.WriteLine("CLIENT  >>> " + txtBericht.Text);
                txtCommunicatie.AppendText("CLIENT  >>> " + txtBericht.Text + "\r\n");
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
    }
}
