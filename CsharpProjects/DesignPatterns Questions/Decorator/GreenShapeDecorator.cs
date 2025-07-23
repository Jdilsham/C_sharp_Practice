using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class GreenShapeDecorator : ShapeDecorator
    {
        public GreenShapeDecorator(Shape shape) : base(shape) { }

        public override void Draw()
        {
            _shape.Draw(); // Draw the shape first
            SetGreenBorder(); // Add green border functionality
        }

        private void SetGreenBorder()
        {
            Console.WriteLine("Setting green border.");
        }
    }
}
