using ProxyPattern;
using System;
using System.Linq.Expressions;

public class Client
{
    static void Main(string[] args)
    {
        InternetAccess internet = new ProxyInternetAccess();

        try
        {
            internet.Connect("Jani.com");
            internet.Connect("janitha.com");
        }
        catch (Exception e) 
        { 
            Console.WriteLine(e.Message);    
        }
    }
}