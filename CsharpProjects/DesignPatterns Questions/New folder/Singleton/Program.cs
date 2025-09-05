using System;
using Singleton;

public class program
{
    public static void Main(string[] args)
    {
        DatabaseConnection d1 = DatabaseConnection.getInstance();
        DatabaseConnection d2 = DatabaseConnection.getInstance();

        if (ReferenceEquals(d1, d2))
        {
            Console.WriteLine("Same");
        }
        else
        {
            Console.WriteLine("Not same");
        }

        d1.Connect();
        d2.Disconnect();
    }
}