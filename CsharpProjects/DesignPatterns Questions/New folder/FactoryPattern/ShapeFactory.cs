using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class ShapeFactory
    {
        public Shape getShape(string shapeType)
        {
            if (string.IsNullOrEmpty(shapeType))
            {
                return null;
            }

            string shapeUpper = shapeType.ToUpper();

            if(shapeUpper == "Circle")
            {
                return new Circle();
            }

            if(shapeUpper == "RECTANFLE")
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
