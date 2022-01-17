using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.BUS
{
    class PointClass
    {
        float _x;
        float _y;
        public float X { get { return _x; } set { _x = value; } }
        public float Y { get { return _y; } set { _y = value; } }
        /// <summary>
        /// Contructor
        /// </summary>
        public PointClass()
        {
            X = 0;Y = 0;
        }
        public float DistanceTo(PointClass p)
        {
            return (float)Math.Sqrt((this.X - p.X) * (this.X - p.X) + (
                this.Y - p.Y) * (this.Y - p.Y));
        }
    }
}
