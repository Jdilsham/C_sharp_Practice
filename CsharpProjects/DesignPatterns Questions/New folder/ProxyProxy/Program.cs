using System;
using ProxyProxy;

public class Program
{
    public static void Main(string[] args)
    {
        InternetAccess internetAccess = new Proxy();

        try
        {
            internetAccess.Connect("Janitha");
            internetAccess.Connect("Jani");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
        }
    }
}