using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFStudent.GUI
{
    public partial class JumFormStudent : Form
    {
        string[] strValues;
        public JumFormStudent()
        {
            InitializeComponent();
        }
        public JumFormStudent(string []str)
        {
            InitializeComponent();
            strValues = str;
        }

        private void JumFormStudent_Load(object sender, EventArgs e)
        {
            txtStudentID.Text = strValues[0];
            txtStudentName.Text = strValues[1];
        }
    }
}
