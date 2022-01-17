using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFStudent.Interface
{
    interface IStudent
    {
        //Khai thuộc tính và phương thức (thành viên của class)
        string StudentID { get; set; }
        string StudentName { get; set; }
        string AddressStudent { get; set; }
        string Note { get; set; }
        int AddNewStudent(string StrConn);
        int UpdateStudent(string StrConn);
        int DeleteStudent(string StrConn);

        //IStudent Search(string name);//1 sv

    }
}
