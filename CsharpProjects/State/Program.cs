using System;
using State;

public class Program
{
    public static void Main(string[] args)
    {
        MobilePhone phone = new MobilePhone(new Ring());
        phone.PhoneAlert();


        phone.setState(new Silent());
        phone.PhoneAlert();
    }
}