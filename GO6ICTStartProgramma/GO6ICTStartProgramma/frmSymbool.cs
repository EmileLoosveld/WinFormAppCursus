using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GO6ICTStartProgramma
{
    public partial class frmSymbool : Form
    {
        frmBasis frmBasis1;
        public frmSymbool(frmBasis frmBasis)
        {
            InitializeComponent();
            this.frmBasis1 = frmBasis;
        }

        private void frmSymbool_Load(object sender, EventArgs e)
        {

        }

        private void lstSymbool_SelectedValueChanged(object sender, EventArgs e)
        {
            frmBasis1.symbool = lstSymbool.SelectedItem.ToString();
        }
    }
}
