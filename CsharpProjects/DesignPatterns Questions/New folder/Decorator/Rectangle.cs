using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing Rectangle...");
        }
    }
}
