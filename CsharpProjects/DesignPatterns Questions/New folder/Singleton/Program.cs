using System;
using Singleton;

public class Program
{
    public static void Main(string[] args)
    {
        DBConnection d1 = DBConnection.getInstance();
        DBConnection d2 = DBConnection.getInstance();

        if (ReferenceEquals(d1, d2))
        {
            Console.WriteLine("Same");
        }

        d1.Connect();
        d2.Disconnect();

    }
}