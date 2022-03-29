using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenPasen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string poort;
        private void lstPoort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPoort.SelectedIndex == -1) return;
            poort = lstPoort.SelectedItem.ToString();
            if (poort == serial.PortName) return; //zelfde poort geselecteerd
            serial.Close();
            try
            {
                serial.PortName = poort;
                serial.Open();
                if (serial.IsOpen == true)
                {
                    this.Text = poort + "Aan";
                    //btnCloseSerial.Enabled = true;
                    //btnZoekPoorten.Enabled = false;
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstPoort.Items.Clear();
            string[] ports = System.IO.Ports.SerialPort.GetPortNames();
            foreach (string poort in ports)
                lstPoort.Items.Add(poort);
        }

        private void verbindingVerbreken_Click(object sender, EventArgs e)
        {
            serial.Close();
            lstPoort.SelectedIndex = -1;
            this.Text = poort + "Uit";
        }

        private void btnZoekPoorten_Click(object sender, EventArgs e)
        {
            lstPoort.Items.Clear();
            string[] ports = System.IO.Ports.SerialPort.GetPortNames();
            foreach (string poort in ports)
                lstPoort.Items.Add(poort);
        }

        private void serial_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {

        }

        private void serial_PinChanged(object sender, System.IO.Ports.SerialPinChangedEventArgs e)
        {
            try
            {
                if (e.EventType == System.IO.Ports.SerialPinChange.DsrChanged && serial.CtsHolding == false)      //lamp 1 geschakeld
                {
                    this.Invoke(new MethodInvoker(delegate ()
                        {
                            serial.DtrEnable = serial.DsrHolding;
                        }));
                }
                if (e.EventType == System.IO.Ports.SerialPinChange.CtsChanged && serial.DsrHolding == false)
                {
                    this.Invoke(new MethodInvoker(delegate ()
                    {
                        serial.DtrEnable = serial.CtsHolding;
                    }));
                }
                if (serial.CtsHolding == true && serial.DsrHolding == true)
                {
                    this.Invoke(new MethodInvoker(delegate ()
                    {
                        serial.RtsEnable = true;
                    }));
                }
                else
                {
                    this.Invoke(new MethodInvoker(delegate ()
                    {
                        serial.RtsEnable = false;
                    }));
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            serial.Close();
            lstPoort.SelectedIndex = -1;
        }
    }
}
