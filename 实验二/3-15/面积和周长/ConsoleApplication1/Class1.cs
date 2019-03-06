using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Rectangle : IShape
    {
        public double Area(double x, double y)
        {
            return x*y;
        }
        public double Perimeter(double x, double y)
        {
            return (x + y) * 2;
        }
    }
}
