using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator2
{
    public class Rectangle : Shape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing Rectangle...");
        }
    }
}
