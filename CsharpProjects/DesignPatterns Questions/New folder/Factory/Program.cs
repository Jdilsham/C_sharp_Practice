using System;
using Factory;

public class program
{
    public static void Main(string[] args)
    {
        ShapeFactory f1 = new ShapeFactory();

        Console.WriteLine("Circle, Rectangle or Square ?");
        string type = Console.ReadLine();

        IShape shape = f1.GetShape(type);

        if (shape != null)
        {
            shape.Draw();
        }
        else{
            Console.WriteLine("Invalid");
        }
    }
}