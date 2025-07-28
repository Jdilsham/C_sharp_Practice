using System;
using Singaleton;

public class program
{
    public static void Main(string[] args)
    {
        DatabaseConnection d1 = DatabaseConnection.Instance;
        DatabaseConnection d2 = DatabaseConnection.Instance;

        if(ReferenceEquals(d1, d2))
        {
            Console.WriteLine("Same Connection");
        }
        else
        {
            Console.WriteLine("Differnt Connection");
        

        d1.Connect();
        d2.Disconnect();
    }
} 