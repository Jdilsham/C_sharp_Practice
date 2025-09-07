using System;
using DecoratorPattern;

public class Program
{
    public static void Main(string[] args)
    {
        Shape c1 = new Circle();
        Shape r1 = new Rectangle();

        c1.Draw();
        r1.Draw();

        Shape redc1 = new RedShapeDecorator(c1);
        Shape redr1 = new RedShapeDecorator(r1);

        redc1.Draw();
        redr1.Draw();
    }
}
