using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.BUS
{
    class DoanThangClass:PointClass
    {
        //float _x1, _y1;
        //public float X1 { get { return _x1; } set { _x1 = value; } }
        //public float X2 { get { return _y1; } set { _y1 = value; } }
        PointClass p;
        public PointClass P { get { return p; } set { p = value; } }
        public float Distance()
        {
            return DistanceTo(P);
        }
        public DoanThangClass()
        {           
        }
        public DoanThangClass(PointClass p1, PointClass p2)
        {
            this.X = p1.X;
            this.Y = p1.Y;
            P = p2;
        }
    }
}
