﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class Circle : Shape
    {
        public void Draw() 
        {
            Console.WriteLine("Drawing a Circle...");
        }
    }
}
