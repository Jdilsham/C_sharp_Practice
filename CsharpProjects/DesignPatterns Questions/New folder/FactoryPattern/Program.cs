using System;
using System.Reflection.Metadata;
using FactoryPattern;

public class program
{
    public static void Main(String[] args)
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