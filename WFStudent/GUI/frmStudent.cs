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
   
    public partial class frmStudent : Form
    {
        private string StrCon;
        SqlConnection Conn = new SqlConnection();
        public frmStudent()
        {
            InitializeComponent();
        }
        public frmStudent(string strCon)
        {
            InitializeComponent();
            StrCon = strCon;
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            if (Conn.State==ConnectionState.Closed||Conn==null)
            {
                Conn.ConnectionString = StrCon;
                Conn.Open();
            }
            SqlCommand sqlCom = new SqlCommand();
            sqlCom.CommandText = "spInsert2Student";
            sqlCom.Connection = Conn;
            sqlCom.CommandType = CommandType.StoredProcedure;
            sqlCom.Parameters.AddWithValue("@StudentID", txtStudentID.Text);
            sqlCom.Parameters.AddWithValue("@StudentName",txtStudentName.Text);
            sqlCom.Parameters.AddWithValue("@AddressStudent",txtStudentAddress.Text);
            sqlCom.Parameters.AddWithValue("@Note", txtNote.Text);
            try
            {
                sqlCom.ExecuteNonQuery();
                MessageBox.Show("Add new student successfully");
            }
            catch (Exception)
            {
                MessageBox.Show("Add new student fail");
            
            }
            LoadData();

        }

        void LoadData()
        {            
            if (Conn.State == ConnectionState.Closed||Conn==null)
            {
                Conn.ConnectionString = StrCon;
                Conn.Open();
            }
            SqlCommand sqlCom = new SqlCommand();
            sqlCom.CommandText = "spSelectAllStutent";
            sqlCom.Connection = Conn;
            sqlCom.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(sqlCom);
            System.Data.DataTable dt = new DataTable();
              da.Fill(dt);
            dgvStudent.DataSource = dt;
            
        }
    }
}
