using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AptechExample
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void exp1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI.frmEntry frm = new GUI.frmEntry();
            frm.ShowDialog();
        }
    }
}
