using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    internal class Rect : Shape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing Rectangle...");
        }
    }
}
