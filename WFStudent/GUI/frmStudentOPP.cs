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
        DataTable dt = new DataTable();
        DataTable dt1 = new DataTable();
        
        DAL.clsStudent student;
        public frmStudentOPP()
        {
            InitializeComponent();
        }

        public frmStudentOPP(string strConn)
        {
            InitializeComponent();
            student = new DAL.clsStudent();
            StrConn = strConn;
            load();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {            
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
            dt= student.SelectAllStudent(StrConn);
            dgvStudent.DataSource = dt;

            LoadDataBiding();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dt = student.SelectStudent(StrConn, txtSearch.Text);
            dgvStudent.DataSource =dt ;
            LoadDataBiding();
        }

        void LoadDataBiding()
        {
            txtNote.DataBindings.Clear();
            txtStudentAddress.DataBindings.Clear();
            txtStudentName.DataBindings.Clear();
            txtStudentAddress.DataBindings.Clear();
            txtStudentID.DataBindings.Clear();
            txtNote.DataBindings.Add("Text", dt, "Note");
            txtStudentID.DataBindings.Add("Text", dt, "StudentID");
            txtStudentName.DataBindings.Add("Text",dt,"StudentName");
            txtStudentAddress.DataBindings.Add("Text",dt,"AddressStudent");
        }

        private void dgvStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //int i = dgvStudent.CurrentCell.RowIndex;
            //txtNote.Text = dgvStudent.Rows[i].Cells["Note"].Value.ToString();
            //txtStudentAddress.Text = dgvStudent.Rows[i].Cells["StudentAddress"].Value.ToString();
        }

        private void dgvStudent_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int i = dgvStudent.CurrentCell.RowIndex;
            string[] a = { dgvStudent.Rows[i].Cells["StudentID"].Value.ToString(),
            dgvStudent.Rows[i].Cells["StudentName"].Value.ToString()};
            //txtNote.Text = dgvStudent.Rows[i].Cells["Note"].Value.ToString();
            //txtStudentAddress.Text = dgvStudent.Rows[i].Cells["StudentAddress"].Value.ToString();
            GUI.JumFormStudent frm = new JumFormStudent(a);
            frm.ShowDialog();
        }
        //void LoadDataBiding1()
        //{
        //    txtNote.DataBindings.Clear();
        //    txtStudentAddress.DataBindings.Clear();
        //    txtStudentName.DataBindings.Clear();
        //    txtStudentAddress.DataBindings.Clear();
        //    txtNote.DataBindings.Add("Text", dt1, "Note");
        //    txtStudentID.DataBindings.Add("Text", dt1, "StudentID");
        //    txtStudentName.DataBindings.Add("Text", dt1, "StudentName");
        //    txtStudentAddress.DataBindings.Add("Text", dt1, "AddressStudent");
        //}
    }
}
