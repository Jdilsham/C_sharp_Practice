using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class greenShapeDecorator : ShapeDecorator
    {
        public greenShapeDecorator(Shape shape) : base(shape) { }

        public override void Draw()
        {
            base.Draw();
            setGreenBorder();
        }

        private void setGreenBorder()
        {
            Console.WriteLine("Setting green border...");
        }
    }
}
