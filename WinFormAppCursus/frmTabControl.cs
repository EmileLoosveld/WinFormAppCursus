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
    public partial class frmTabControl : Form
    {
        public frmTabControl()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void btnIndex_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            switch(btn.Tag.ToString())
            {
                case "<": tabControl1.SelectedIndex--;
                    break;
                case ">": tabControl1.SelectedIndex++;
                    break;
            }
            btnVolgende.Enabled = (tabControl1.SelectedIndex < tabControl1.TabCount - 1);
            btnVorige.Enabled = (tabControl1.SelectedIndex > 0);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
