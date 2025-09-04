using System;
using Factory;

public class Program
{
    public static void Main(string[] args)
    {
        Factory factory = new Factory();

        Console.WriteLine("What Shape do you want? ");
        string shapetype = Console.ReadLine();

        Shape shape = factory.getShape(shapetype);

        if (shape != null)
        {
            shape.Draw();
        }
        else
        {
            Console.WriteLine("Invalid!");
        }

    }
}