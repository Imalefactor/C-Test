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
            Employee OneEmployee = new Employee("李四", 30, "计算机系", 2000);
            OneEmployee.Display();
            Console.ReadKey();
        }
    }
}
