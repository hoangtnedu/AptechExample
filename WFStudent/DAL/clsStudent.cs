using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace WFStudent.DAL
{
    class clsStudent : Interface.IStudent
    {
        SqlConnection Conn;
        SqlCommand Comm;
        SqlDataAdapter da;

        #region Properties


        string _studentID, _studentName, _studentAddress, _studentNote;
        /// <summary>
        /// StudentID là thuộc tính mã sinh viên
        /// </summary>
        public string StudentID
        {
            get { return _studentID; }
            set { _studentID = value; }
        }
        /// <summary>
        /// StudentName là thuộc tính tên sinh viên
        /// </summary>
        public string StudentName
        {
            get { return _studentName; }
            set { _studentName = value; }
        }
        /// <summary>
        /// AddressStudent là thuộc tính địa chỉ của sinh viên
        /// </summary>
        public string AddressStudent
        {
            get { return _studentAddress; }
            set { _studentAddress = value; }
        }
        public string Note
        {
            get { return _studentNote; }
            set { _studentNote = value; }
        }
        #endregion

        #region Methods
        public clsStudent() { }

        /// <summary>
        /// Add a new student in database
        /// </summary>
        /// <param name="StrConn">StrConn is SqlConnectionString</param>
        /// <returns></returns>
        public int AddNewStudent(string StrConn)
        {
            int check = 0;
            if (Conn == null || Conn.State == ConnectionState.Closed)
            {
                Conn = new SqlConnection(StrConn);
                Conn.Open();
            }
            Comm = new SqlCommand();
            Comm.Connection = Conn;
            Comm.CommandText = "spInsert2Student";
            Comm.CommandType = CommandType.StoredProcedure;
            Comm.Parameters.AddWithValue("@StudentId", StudentID);
            Comm.Parameters.AddWithValue("@StudentName",StudentName);
            Comm.Parameters.AddWithValue("@AddressStudent",AddressStudent);
            Comm.Parameters.AddWithValue("@Note",Note);
            try
            {
                Comm.ExecuteNonQuery();
                check = 0;
            }
            catch (Exception)
            {

                check = -1;
            }
            return check ;
        }
        /// <summary>
        /// Update a record
        /// </summary>
        /// <param name="StrConn">StrConn is SqlConnectionString</param>
        /// <returns></returns>
        public int UpdateStudent(string StrConn)
        {
            int check=0;         
            if (Conn == null || Conn.State == ConnectionState.Closed)
            {
                Conn = new SqlConnection(StrConn);
                Conn.Open();
            }
            Comm = new SqlCommand();
            Comm.Connection = Conn;
            Comm.CommandText = "spUpdateStudent";
            Comm.CommandType = CommandType.StoredProcedure;
            Comm.Parameters.AddWithValue("@StudentId", StudentID);
            Comm.Parameters.AddWithValue("@StudentName", StudentName);
            Comm.Parameters.AddWithValue("@AddressStudent", AddressStudent);
            Comm.Parameters.AddWithValue("@Note", Note);
            Comm.Parameters.AddWithValue("@Note", Note);
            try
            {
                Comm.ExecuteNonQuery();
                check = 0;
            }
            catch (Exception)
            {

                check = -1;
            }
            return check;
            
        }
        public  int DeleteStudent(string StrConn)
        {
            int check = 0;
            return check;
        }
        #endregion

    }
}
