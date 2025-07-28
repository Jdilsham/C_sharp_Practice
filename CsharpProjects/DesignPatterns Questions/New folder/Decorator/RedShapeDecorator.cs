using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class RedShapeDecorator : ShapeDecorator
    {
        public RedShapeDecorator(IShape shape) : base(shape) { }

        public override void Draw()
        {
            _shape.Draw();
            SetShapeBorder();
        }

        private void SetShapeBorder()
        {
            Console.WriteLine("Setting Red Border...");
        }
    }
}
