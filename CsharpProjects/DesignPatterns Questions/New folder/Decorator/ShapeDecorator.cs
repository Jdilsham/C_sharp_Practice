using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class ShapeDecorator : IShape
    {
        protected IShape _shape;

        public ShapeDecorator(IShape shape)
        {
            _shape = shape;
        }

        public virtual void Draw()
        {
            _shape.Draw();
        }
    }
}
