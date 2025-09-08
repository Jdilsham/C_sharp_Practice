using System;
using StatePattern;

public class Program
{
    public static void Main(string[] args)
    {
        MobilePhone phone = new MobilePhone(new Silent());
        phone.Alert();

        phone.SetState(new Ringing());
        phone.Alert();

        phone.SetState(new Silent());
        phone.Alert();
    }
}