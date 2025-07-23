using Decorator;
using System;

class Program
{
    static void Main(string[] args)
    {
        // Create concrete shapes
        Shape circle = new Circle();
        Shape rectangle = new Rectangle();

        // Decorate shapes
        Shape redCircle = new RedShapeDecorator(circle);
        Shape greenRectangle = new GreenShapeDecorator(rectangle);

        // Draw the decorated shapes
        Console.WriteLine("Circle with Red Border:");
        redCircle.Draw();

        Console.WriteLine("\nRectangle with Green Border:");
        greenRectangle.Draw();
    }
}
