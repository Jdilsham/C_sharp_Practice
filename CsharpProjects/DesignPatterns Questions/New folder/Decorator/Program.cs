using System;
using Decorator;

public class Program
{
    public static void Main(string[] args)
    {
        Shape c = new Circle();
        Shape r = new Rectangle();

        c.Draw();
    }
}