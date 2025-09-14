using System;
using Factory;

public class Program
{
    public static void Main(string[] args)
    {
        ShapeFactory factory = new ShapeFactory();

        Console.WriteLine("Circle or Square ?");
        string input = Console.ReadLine();

        Shape shape = factory.getShape(input);

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