using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFStudent.GUI
{
    public partial class frmStudentOPP : Form
    {
        string StrConn;
        
        DAL.clsStudent student;
        public frmStudentOPP()
        {
            InitializeComponent();
        }

        public frmStudentOPP(string strConn)
        {
            InitializeComponent();
            StrConn = strConn;
            load();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            student = new DAL.clsStudent();
            student.StudentID = txtStudentID.Text;
            student.StudentName = txtStudentName.Text;
            student.AddressStudent = txtStudentAddress.Text;
            student.Note = txtNote.Text;
           int i= student.AddNewStudent(StrConn);
            if (i==0)
            {
                MessageBox.Show("Add a new student to database successfully");
            }
            else
                MessageBox.Show("Not success");
            load();
        }

        void load()
        {
            System.Data.SqlClient.SqlConnection Conn = new SqlConnection();
            if (Conn == null||Conn.State == ConnectionState.Closed  )
            {
                Conn.ConnectionString = StrConn;
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
