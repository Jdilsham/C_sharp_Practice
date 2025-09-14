using System;
using ProxyPattern;

public class Program
{
    public static void Main(string[] args)
    {
        InternetAccess internet = new Proxy();

        try
        {
            internet.Connect("janitha.com");
            internet.Connect("jani.com");

        }catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }
}