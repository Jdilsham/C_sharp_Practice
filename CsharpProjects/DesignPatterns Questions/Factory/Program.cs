using System;
using Factory;

public class Program
{
    public static void Main(string[] args)
    {
        ShapeFactory factory = new ShapeFactory();

        Console.WriteLine("Circle, Rectangle or Square ?");
        string type = Console.ReadLine();

        Shape shape = factory.getShape(type);

        if (shape != null)
        {
            shape.Draw();
        }
        else
        {
            Console.WriteLine("Invalid");
        }
    }
}