using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.BUS
{
    class StudentClass
    {
        string _id, _name, _address, _note;
        public string ID { get { return _id; } set { _id = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public string Address { get { return _address; }set { _address = value; } }
        public string Note { get { return _note; }set { _note = value; } }
        public StudentClass()
        { 
        }
        public StudentClass(string id, string name, string address, string note)
        {
            ID = id;Name = name;Address = address;Note = note;
        }
        public void InsertToDatabase(System.Data.SqlClient.SqlConnection conn)
        {

        }
    }
}
