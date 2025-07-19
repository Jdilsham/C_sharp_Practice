using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory_pattern
{
    internal class Rectangle : Shape
    {
        public void Draw()
        {
            Console.WriteLine("drawing a rectangle...");
        }
    }
}
