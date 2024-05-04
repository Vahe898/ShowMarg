using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowMarg
{
    internal struct PointInMarge
    {
        public double X { get; set; }
        public double Y { get; set; }

        public PointInMarge(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
}
