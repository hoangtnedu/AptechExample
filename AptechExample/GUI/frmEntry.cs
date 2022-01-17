using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AptechExample.GUI
{
    public partial class frmEntry : Form
    {
        public frmEntry()
        {
            InitializeComponent();


        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtHovaTen.Text!="")
            {
                txtHovaTen.BackColor = Color.White;
                frmShowInfor frm = new frmShowInfor(txtHovaTen);
                frm.ShowDialog();
            }
            else
            {
                txtHovaTen.Focus();
                txtHovaTen.BackColor = Color.Red;
            }
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //PictureBox
            pbImg.Image = Image.FromFile(@"C:\Users\HoangTN\Desktop\chandung.jpg");
           
        }

        private void btnAddListView_Click(object sender, EventArgs e)
        {
            lvExample.Items.Add(txtAddListItem.Text);
        }
        void AddNodeTreeView()
        {
            TreeNode node = new TreeNode("Luật học");
            node.Nodes.Add("Luật quốc tế.");
            node.Nodes.Add("Luật dân sự");
            node.Nodes.Add("Luật hình sự");
            treeExample.Nodes.Add(node);
        }

        private void btnAddNode_Click(object sender, EventArgs e)
        {
            AddNodeTreeView();
        }

   
    }
}
