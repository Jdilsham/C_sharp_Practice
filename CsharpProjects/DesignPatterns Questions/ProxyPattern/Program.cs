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
            internet.Connect("jani.com");
        }
    }
}