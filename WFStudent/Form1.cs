using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFStudent
{
    public partial class Form1 : Form
    {
        string strConectionString;
        public Form1()
        {
            InitializeComponent();
        }
        private void databaseAccessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI.DataAccessForm frm = new GUI.DataAccessForm();
            frm.ShowDialog();
            strConectionString = frm.StrConn;
            frm.ShowDialog();
        }

        private void studentInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI.frmStudent frm = new GUI.frmStudent(strConectionString);
            frm.ShowDialog();
        }

        private void studentOOPInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI.frmStudentOPP frm = new GUI.frmStudentOPP(strConectionString);
            frm.ShowDialog();
        }
    }
}
