using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.BUS
{
    class LeanrClass
    {
        List<BUS.StudentClass> studentClasses = new List<StudentClass>();
        string subject;
        int credit;
        public string Subject { get { return subject; } set { subject = value; } }
        public int Credit { get { return credit;}set { credit = value; } }
        public LeanrClass()
        {
            studentClasses = null;
            Subject = "No Subject";
            Credit = 0;
        }
        
    }
}
