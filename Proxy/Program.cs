using System;
using Proxy;

public class Program
{
    public static void Main(string[] args)
    {
        InternetAccess internetAccess = new Proxyy();

        try
        {
            internetAccess.Connect("Janitha.com");
            internetAccess.Connect("Jani.com");
        }catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }
}