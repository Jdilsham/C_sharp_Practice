using System;
using ProxyPattern;

public class Program
{
    public static void Main(string[] args)
    {
        InternetAccess internet = new ProxyInternetAccess();

        try
        {
            internet.Connect("janitha.com");
            internet.Connect("jani.com");
        }catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}