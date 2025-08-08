using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class ShapeDecorator : Shape
    {
        protected Shape _shape;

        public ShapeDecorator(Shape shape)
        {
            _shape = shape;
        }

        public virtual void Draw()
        {
            _shape.Draw();
        }

    }
}
