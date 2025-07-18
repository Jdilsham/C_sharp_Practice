using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory_pattern
{
    internal class Circle : Shape
    {
        public void draw()
        {
            Console.WriteLine("drawing a circle...");
        }
    }
}
