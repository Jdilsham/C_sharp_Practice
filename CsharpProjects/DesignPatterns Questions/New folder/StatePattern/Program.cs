using System;
using StatePattern;

public class program
{
    public static void Main(string[] args)
    {
        MoblePhone phone = new MoblePhone(new Vibrate());

        phone.Alert();

        phone.setState(new Silent());

        phone.Alert();

        phone.setState(new Vibrate());

        phone.Alert();
    }
}