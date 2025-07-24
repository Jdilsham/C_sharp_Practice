using Decorator2;
using System;

class Program
{
    static void Main(string[] args)
    {
        Shape c1 = new Circle();
        Shape r1 = new Rectangle();

        Shape redcircle = new RedShapeDecorator(c1);
        Shape greenrect = new GreenShapeDecorator(r1);

        Console.WriteLine("Red Circle...");
        redcircle.Draw();

        Console.WriteLine("Green Rectangle...");
        greenrect.Draw();
    }
}