using System;
using Decorator;

public class program
{
    public static void Main(string[] args)
    {
        IShape circle = new Circle();
        IShape rect = new Rectangle();

        IShape redCircle = new RedShapeDecorator(circle);
        IShape greenRect = new GreenShapeDecorator(rect);

        redCircle.Draw();

        greenRect.Draw();
    }
}