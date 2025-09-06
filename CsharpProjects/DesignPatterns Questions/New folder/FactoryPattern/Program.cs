using System;
using FactoryPattern;

public class Program
{
    public static void Main(string[] args)
    {
        ShapeFactory factory = new ShapeFactory();

        Console.WriteLine("What Shape do you want ? (Circle, Rectangle, Square)");
        string type = Console.ReadLine();

        Shape shapetype = factory.getShape(type);

        if(shapetype != null)
        {
            shapetype.Draw();
        }
        else
        {
            Console.WriteLine("Invalid");
        }
    }
}