using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets; //TCPClient en TCPServer verbinden
using System.Net; //IPadressen gebruiken
using System.IO; // Berichten versturen en ontvangen

namespace frmTCPIPServer
{
    public partial class frmTCPIPServer : Form
    {
        public frmTCPIPServer()
        {
            InitializeComponent();
        }
    }
}
