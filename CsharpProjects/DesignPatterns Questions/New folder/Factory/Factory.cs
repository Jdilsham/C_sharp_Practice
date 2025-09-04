using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    internal class Factory
    {
        public Shape getShape(string shape)
        {
            if (string.IsNullOrEmpty(shape))
            {
                return null;
            }

            string shapeUpper = shape.ToUpper();

            if(shapeUpper == "CIRCLE")
            {
                return new Circle();
            }

            if(shapeUpper == "Rect")
            {
                return new Rect();
            }

            if(shapeUpper == "SQUARE")
            {
                return new Square();
            }

            return null;
        }
    }
}
