using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.BUS
{
    class PhuongTrinhBac1 : IPTB1
    {
        float _a, _b;
        public float a
        {
            get { return _a; }
            set { _a = value; }
        }
        public float b
        {
            get { return _b; }
            set { _b = value; }
        }
        public string LoiGiaiPTB1()
        {
            if (a > 0) return
            " Nghiệm của PT là " + (- b / a).ToString();
            return " Phương trình vô nghiệm";      
        }
        public PhuongTrinhBac1()
        {

        }
        public PhuongTrinhBac1(float x, float y)
        {
            a = x;b = y;
        }

    }
}
