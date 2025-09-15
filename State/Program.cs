using System;
using State;

public class Program
{
    public static void Main(string[] args)
    {
        MobilePhone phone = new MobilePhone(new Ring());
        phone.Alert();

        phone.setState(new Silent());
        phone.Alert();

    }
}