using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4.GUI
{
    public partial class GiaiPTbac1 : Form
    {
        public GiaiPTbac1()
        {
            InitializeComponent();
        }

        private void btnGiaiPT_Click(object sender, EventArgs e)
        {
            BUS.PhuongTrinhBac1 pt = new BUS.PhuongTrinhBac1();
            pt.a = float.Parse(txta.Text);
            pt.b = float.Parse(txtb.Text);            
            lblLoiGiai.Text = pt.LoiGiaiPTB1();
        }
    }
}
