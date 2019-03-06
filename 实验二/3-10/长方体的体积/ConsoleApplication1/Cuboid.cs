using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Cuboid
    {
        public double Length;
        public double Width;
        public double Height;
        public double Volume()
        {
            double Vol;
            Vol = Length * Width * Height;
            return Vol;
        }
        
    }
}

