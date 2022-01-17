using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AptechExample.BUS
{
    class B
    {
        A a;
        public A Kettap
        {
            get { return a; }
            set
            {
                a = value;
            }
        }

        public B()
        {

        }
    }
}
