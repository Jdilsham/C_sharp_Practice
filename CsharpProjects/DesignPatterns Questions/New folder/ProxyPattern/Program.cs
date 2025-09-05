using System;
using ProxyPattern;

public class program()
{
    public static void Main(string[] args)
    {
        InternetAccess internetAccess = new Proxy();

        try
        {
            internetAccess.Connect("Janitha.com");
            internetAccess.Connect("Dinu.com");
        }catch (Exception e)
        {
            Console.WriteLine(e.ToString());
        }
    }
}