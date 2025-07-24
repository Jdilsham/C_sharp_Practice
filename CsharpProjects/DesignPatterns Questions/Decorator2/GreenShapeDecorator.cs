using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator2
{
    public class GreenShapeDecorator : ShapeDecorator
    {
        public GreenShapeDecorator(Shape shape) : base(shape) { }

        public override void Draw()
        {
            shape.Draw();
            SetGreenBorder();

        }

        public void SetGreenBorder()
        {
            Console.WriteLine("Setting Green Border...");
        }
        
    }
}
