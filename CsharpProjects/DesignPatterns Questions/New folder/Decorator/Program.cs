using System;
using Decorator;

class program
{
    public static void Main(string[] args)
    {
        Shape Circle = new Circle();
        Shape Rect = new Rectangle();

        Circle.Draw();
    }
}