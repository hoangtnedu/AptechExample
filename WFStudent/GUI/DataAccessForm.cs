using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WFStudent.GUI
{
    public partial class DataAccessForm : Form
    {
        public string StrConn { get; set; }
        public DataAccessForm()
        {
            InitializeComponent();
        }

        private void btnAccesstoDatabase_Click(object sender, EventArgs e)
        {
            string strCon = @"Data Source=DESKTOP-H68FGFI\SQLSERVER; Initial Catalog =Student;Integrated Security = True";
            SqlConnection Conn = new SqlConnection();
            Conn.ConnectionString = strCon;
            try
            {
                Conn.Open();
                lblStatus.Text = "Connection Seccessfull";
                lblStatus.BackColor = Color.Yellow;
            }
            catch (Exception)
            {
                lblStatus.Text = "Connection Fail";
                lblStatus.BackColor = Color.Yellow;
            }
        }

        private void btnAccessbyLogin_Click(object sender, EventArgs e)
        {
            string strCon = "Data Source=" + txtServerName.Text+";";
            strCon += "Initial Catalog=" + txtDatabaseName.Text+";";
            strCon += "User ID=" + txtLogin.Text + ";";
            strCon += "Password=" + txtPassword.Text + ";";
            SqlConnection Conn = new SqlConnection();
            Conn.ConnectionString = strCon;
            try
            {
                Conn.Open();
                StrConn = strCon;
                lblStatus.Text = "Connection Successfull";
                lblStatus.BackColor = Color.Yellow;
            }
            catch (Exception)
            {
                lblStatus.Text = "Connection Fail";
                lblStatus.BackColor = Color.Yellow;
            }
        }
    }
}
