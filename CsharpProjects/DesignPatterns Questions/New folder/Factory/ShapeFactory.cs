using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class ShapeFactory 
    {
        public IShape GetShape(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return null;
            }
            if (name.Equals("CIRCLE", StringComparison.OrdinalIgnoreCase))
            {
                return new Circle();
            }

            if (name.Equals("SUQARE", StringComparison.OrdinalIgnoreCase))
            {
                return new Square();
            }

            if (name.Equals("RECTANGLE", StringComparison.OrdinalIgnoreCase))
            {
                return new Rectangle();
            }

            return null;
        }
    }
}
