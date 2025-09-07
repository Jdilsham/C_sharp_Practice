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
    }
}
