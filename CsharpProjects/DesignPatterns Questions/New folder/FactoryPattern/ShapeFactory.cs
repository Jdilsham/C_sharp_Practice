using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class ShapeFactory
    {
        public Shape getShape(string shape)
        {
            if (string.IsNullOrEmpty(shape))
            {
                return null;
            }

            string ShapeUpper = shape.ToUpper();

            if(ShapeUpper == "CIRCLE")
            {
                return new Circle();
            }

            if(ShapeUpper == "RECTANGLE")
            {
                return new Rectangle();
            }

            if(ShapeUpper == "SQUARE")
            {
                return new Square();
            }

            return null;
        }
    }
}
