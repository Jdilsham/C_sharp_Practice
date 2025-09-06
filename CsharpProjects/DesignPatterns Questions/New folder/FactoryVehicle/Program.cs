using System;
using FactoryVehicle;

public class Program
{
    public static void Main(string[] args)
    {
        VehicleFactory factory = new VehicleFactory();

        Console.WriteLine("What you need? (car, Byke or Rickshow)");
        string vType = Console.ReadLine();


        IVehicle Vehicle = factory.getvehicle(vType);

        if(Vehicle != null)
        {
            string type = Vehicle.VehicleType();
            int wheel = Vehicle.NumberOfWheel();

            Console.WriteLine($"vehicle Type: {type} No of Wheel: {wheel}");
        }
        else
        {
            Console.WriteLine("Invalid");
        }
    }
}