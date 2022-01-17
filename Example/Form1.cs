using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

        }


        void click()
        {
            if (txtHovaTen.Text != "")
            {
                txtHienThi.BackColor = Color.AliceBlue;
                txtHienThi.Text = txtHovaTen.Text;
            }
            else
                MessageBox.Show("Bạn phải nhập dữ liệu vào...", "Thông báo");
        }

        private void Click_Chuot(object sender, EventArgs e)
        {
            if (txtHovaTen.Text != "")
            {
                txtHienThi.BackColor = Color.AliceBlue;
                txtHienThi.Text = txtHovaTen.Text;
            }
            else
                MessageBox.Show("Bạn phải nhập dữ liệu vào...", "Thông báo");
        }

        private void TexChangeHovaTen(object sender, EventArgs e)
        {
            txtHienThi.Text = txtHovaTen.Text;
        }
    }
}
