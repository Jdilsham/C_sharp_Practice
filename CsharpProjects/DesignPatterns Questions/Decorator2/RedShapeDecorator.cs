using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator2
{
    public class RedShapeDecorator : ShapeDecorator
    {
        public RedShapeDecorator(Shape shape) : base(shape) { }

        public override void Draw()
        {
            shape.Draw();
        }
        
        public void SetRedBorder()
        {
            Console.WriteLine("Setting Red Border...");
        }
    }
}
