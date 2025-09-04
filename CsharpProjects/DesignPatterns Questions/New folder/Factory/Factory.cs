using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class FactoryShape
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

            if(shapeUpper == "RECTANGLE")
            {
                return new Rectangle();
            }

            if(shapeUpper == "SQUARE")
            {
                return new Square();
            }

            return null;
        }
    }
}
