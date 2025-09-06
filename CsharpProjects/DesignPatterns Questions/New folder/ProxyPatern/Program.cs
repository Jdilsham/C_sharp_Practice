using System;
using ProxyPatern;

public class Program
{
    public static void Main(string[] args)
    {
        InternetAccess internet = new Proxy();

        try
        {
            internet.Connect("Janitha.com");
            internet.Connect("Jani.com");

        }catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }

    }
}