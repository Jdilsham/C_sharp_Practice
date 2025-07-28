using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class GreenShapeDecorator : ShapeDecorator
    {
        public GreenShapeDecorator(IShape shape) : base(shape) { }

        public override void Draw()
        {
            _shape.Draw();
            SetGreenBorder();
        }

        private void SetGreenBorder()
        {
            Console.WriteLine("Setting green Border...");
        }
    }
}
