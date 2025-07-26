using ProxyPattern;
using System;

public class Client
{
    static void Main(string[] args)
    {
        InternertAccess internert = new ProxyInternetAccess();

        try
        {
            internert.Connect("janitha.com");
            internert.Connect("dil.com");
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}