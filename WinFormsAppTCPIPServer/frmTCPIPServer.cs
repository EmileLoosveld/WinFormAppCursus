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


    }
}
