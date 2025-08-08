using System;
using Decorator;

public class Program
{
    public static void Main(string[] args)
    {
        Shape c = new Circle();
        Shape r = new Rectangle();

        c.Draw();
        r.Draw();

        Shape c1 = new RedShapeDecorator(c);
        Shape r1 = new RedShapeDecorator(r);

        c1.Draw();
        r1.Draw();
    }
}