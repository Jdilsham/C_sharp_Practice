using System;
using Decorator;

class program
{
    public static void Main(string[] args)
    {
        Shape Circle = new Circle();
        Shape Rect = new Rectangle();

        Circle.Draw();
        Rect.Draw();

        Shape redCircle = new RedShapeDecorator(Circle);
        redCircle.Draw();

        Shape redRect = new RedShapeDecorator(Rect);
        redRect.Draw();
    }
}