using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    internal class ShapeFactory
    {
        public Shape getShape(string shapeType)
        {
            if (string.IsNullOrEmpty(shapeType))
            {
                return null;
            }

            string shape = shapeType.ToUpper();

            if (shape == "CIRCLE")
            {
                return new Circle();
            }
            
            if (shape == "SQUARE")
            {
                return new Square();
            }

            if (shape == "RECTANGLE")
            {
                return new Rectangle();
            }

            return null;

        }
    }
}
