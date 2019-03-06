using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            double x = 200;
            double y = 300;
            Console.WriteLine("矩形的面积为：{0}", rect.Area(x, y));
            Console.WriteLine("矩形的周长为：{0}", rect.Perimeter(x, y));
            Console.ReadKey();
        }
    }
}
