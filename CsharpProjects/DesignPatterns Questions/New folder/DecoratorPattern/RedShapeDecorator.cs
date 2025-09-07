using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    internal class RedShapeDecorator : ShapeDecorator
    { 
        public RedShapeDecorator(Shape shape) : base(shape) { }

        public override void Draw()
        {
            base.Draw();
            setRedBorder();
        }

        private void setRedBorder()
        {
            Console.WriteLine("Red Border");
        }
    }
}
