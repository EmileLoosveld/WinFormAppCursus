using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht_bluetooth
{
    public partial class frmHoofd : Form
    {
        public frmHoofd()
        {
            InitializeComponent();
        }

        private void btnZoekPoorten_Click(object sender, EventArgs e)
        {
            lstPoort.Items.Clear();
            string[] ports = System.IO.Ports.SerialPort.GetPortNames();
            foreach (string poort in ports)
                lstPoort.Items.Add(poort);
        }

        private void lstPoort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPoort.SelectedIndex == -1) return;
            string poort = lstPoort.SelectedItem.ToString();
            if (poort == serial.PortName) return; //zelfde poort geselecteerd
            serial.Close();
            try
            {
                serial.PortName = poort;
                serial.Open();
                if (serial.IsOpen == true)
                {
                    txttekst.AppendText("Nieuwe poort geopend:" + poort + "\r\n");
                    btnCloseSerial.Enabled = true;
                    btnZoekPoorten.Enabled = false;
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void serial_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            try
            {
                string data = serial.ReadExisting();
                if (data == "disconnect\n")
                {
                    serial.Close();
                    lstPoort.SelectedIndex = -1;
                    btnZoekPoorten.Enabled = true;
                    btnCloseSerial.Enabled = false;
                    lstPoort.SelectedIndex = -1;
                }
                else
                {
                    //You need to use the Invoke Method and pass the delegate and data
                    this.txttekst.Invoke(new MethodInvoker(delegate () {
                        txttekst.AppendText(data);
                    }));
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtInvullen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                serial.WriteLine("Ander: " + txtInvullen.Text + "\r\n");
                txttekst.AppendText("Ik: " + txtInvullen.Text + "\r\n");
                txtInvullen.Clear();
            }
        }

        private void frmHoofd_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serial.IsOpen) serial.Close();
        }

        private void btnCloseSerial_Click(object sender, EventArgs e)
        {
            serial.WriteLine("disconnect");
            serial.Close();
            lstPoort.SelectedIndex = -1;
            btnZoekPoorten.Enabled = true;
            btnCloseSerial.Enabled = false;
            lstPoort.SelectedIndex = -1;
        }

        private void frmHoofd_Load(object sender, EventArgs e)
        {

        }
    }
}
