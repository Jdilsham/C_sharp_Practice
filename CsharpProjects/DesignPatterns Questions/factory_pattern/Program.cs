using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory_pattern
{
    internal class FactoryDemo
    {
        public static void Main(string[] args)
        {

            Factory f1 = new Factory();

            Console.WriteLine("CIRCLE or RECTANGLE or SQUARE ?\n");
            string type = Console.ReadLine()

            Shape shape = f1.GetShape(type);

            if (shape != null)
            {
                shape.Draw();
            }
            else
            {
                Console.WriteLine("Invalid");
            }


        }
    }
}
