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
            int i, j;
            for (i = 1; i < 10; i++)
            {
                for (j = 1; j < 10; j++)
                {
                    if (j > i)
                        break;
                
                        Console.Write("{0}*{1}={2}\t", i, j, i * j);

                }
                Console.WriteLine();
                Console.ReadKey();
            }
        }
    }
}
