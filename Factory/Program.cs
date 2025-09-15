using System;
using Factory;

public class Program
{
    public static void Main(string[] args)
    {
        ShapeFactory factory = new ShapeFactory();

        Console.WriteLine("Circle or Rectangle ?");
        string shape = Console.ReadLine();

        Shape type = factory.getShape(shape);

        if (type != null)
        {
            type.Draw();
        }
        else
        {
            Console.WriteLine("Incorrect");
        }
    }
}