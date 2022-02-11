using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.Sockets;
using System.Net;

namespace WinFormsAppTCPIPServer
{
    public partial class frmTCPIPServer : Form
    {
        TcpListener listener;
        TcpClient client;
        StreamReader Reader;
        StreamWriter Writer;
        public frmTCPIPServer()
        {
            InitializeComponent();
        }

        private void chkStartServer_CheckedChanged(object sender, EventArgs e)
        {
            if (chkStartServer.Checked)
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
                    chkStartServer.Text = "Stop server";
                }
                catch
                {
                    txtMelding.AppendText("Server kan niet gestart worden," + "controleer IPAdres en Poortnummer!\r\n");
                    chkStartServer.Checked = false;
                }
            }
            else //server stoppen
            {
                if(client!=null && client.Connected)
                {
                    Writer.WriteLine("Disconnect");
                    bgWorkerOntvang.CancelAsync();
                }
                try //server stoppen
                {
                    if(listener!=null)
                    {
                        if (client != null && client.Connected) client.Close();
                        listener.Stop();
                    }
                    chkStartServer.Text = "Start Server";
                    txtMelding.AppendText("Server gestopt!\r\n");
                }
                catch
                {
                    txtMelding.AppendText("Server kan niet gestopt worden.\r\n");
                }
            }
        }

        private void bgWorkerListener_DoWork(object sender, DoWorkEventArgs e)
        {
            client = listener.AcceptTcpClient(); //1 client aanvaarden
        }

        private void bgWorkerListener_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //listener stop met wachten als client verbonden is
            //of als hij gestopt werd -> dan client niet starten
            if(client!=null  && client.Connected)
            {
                //Communicatie met client opzetten
                Reader = new StreamReader(client.GetStream());
                Writer = new StreamWriter(client.GetStream());
                Writer.AutoFlush = true;
                bgWorkerOntvang.WorkerSupportsCancellation = true;
                bgWorkerOntvang.RunWorkerAsync(); //start ontvangen data
                btnVerbreek.Enabled = true;
                txtMelding.AppendText("Client verbonden!\r\n");
                splitContainer1.Panel2.Enabled = true;
            }
        }

        private void bgWorkerOntvang_DoWork(object sender, DoWorkEventArgs e)
        {
            while(client.Connected)
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
            Writer.Close();
            Reader.Close();
            client.Close();
            txtMelding.AppendText("Verbinding met client is verbroken!\r\n");
            btnVerbreek.Enabled = false;
            splitContainer1.Panel2.Enabled = false;
            //bgworkerlistener opnieuw starten als server nog niet gestart is.
            if (chkStartServer.Checked)
                bgWorkerListener.RunWorkerAsync();
        }

        private void btnZend_Click(object sender, EventArgs e)
        {
            try
            {
                Writer.WriteLine("SERVER >>>" + txtBericht.Text);
                txtCommunicatie.AppendText("SERVER >>>" + txtBericht.Text + "\r\n");
            }
            catch
            {
                txtMelding.AppendText("Bericht zenden mislukt\r\n");
            }
        }

        private void btnVerbreek_Click(object sender, EventArgs e)
        {
            Writer.WriteLine("Disconnect");
            client.Close();
        }

        private void mtxtIPadres_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
