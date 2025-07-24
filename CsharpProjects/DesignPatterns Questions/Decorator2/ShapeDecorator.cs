using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator2
{
    public abstract class ShapeDecorator : Shape
    {
        protected Shape shape;

        public ShapeDecorator(Shape shape)
        {
            this.shape = shape;
        }

        public virtual void Draw()
        {
            shape.Draw();
        }
    }
}
