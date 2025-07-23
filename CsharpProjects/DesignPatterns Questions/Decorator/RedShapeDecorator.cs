using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class RedShapeDecorator : ShapeDecorator
    {
        public RedShapeDecorator(Shape shape) : base(shape) { }

        public override void Draw()
        {
            _shape.Draw(); // Draw the shape first
            SetRedBorder(); // Add red border functionality
        }

        private void SetRedBorder()
        {
            Console.WriteLine("Setting red border.");
        }
    }

}
