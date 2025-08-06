using System;
using Singleton;

public class Program
{
    public static void Main(string[] args)
    {
        DatabaseConnection d1 = DatabaseConnection.Instance;
        DatabaseConnection d2 = DatabaseConnection.Instance;

        if(ReferenceEquals(d1, d2))
        {
            Console.WriteLine("Both Instance are the same instance!");
        }
        else
        {
            Console.WriteLine("Instance are different!");
        }

        d1.Connect();
        d2.Disconnect()
    }

}