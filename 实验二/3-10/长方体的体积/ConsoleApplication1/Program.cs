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
            Cuboid cuboid = new Cuboid();
            cuboid.Length = 3.50;
            cuboid.Width = 2.40;
            cuboid.Height = 5.50;
            System.Console.WriteLine("长方体的体积为：{0}", cuboid.Volume());
            Console.ReadKey();
        }
    }
}
