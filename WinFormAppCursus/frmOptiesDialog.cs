using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormAppCursus
{
    public partial class frmOptiesDialog : Form
    {
        public Color VoorgrondKleur { get; set }
        public Color AchtergrondKleur { get; set }
        public frmOptiesDialog()
        {
            InitializeComponent();
        }
        
    }
}
