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
    public partial class frmDoanThang : Form
    {
        float x1, x2, y1, y2;
        public frmDoanThang()
        {
            InitializeComponent();
        }
        void convert()
        {
            x1 = float.Parse(txtX1.Text);
            x2 = float.Parse(txtX2.Text);
            y1 = float.Parse(txtY1.Text);
            y2 = float.Parse(txtX2.Text);
        }
        private void btnKC_Click(object sender, EventArgs e)
        {
            BUS.PointClass p = new BUS.PointClass();
            p.X = x1; p.Y = y1;
            BUS.PointClass p1 = new BUS.PointClass();
            p1.X = x2; p1.Y = y2;
            BUS.DoanThangClass doan = new BUS.DoanThangClass(p, p1);
            lblKetqua.Text = "Distance beetween A (" + txtX1.Text + "," + txtY1.Text + ")" +
                "B(" + txtX2.Text + ", " + txtY2.Text + ")= " + doan.Distance().ToString();
        }
    }
}
