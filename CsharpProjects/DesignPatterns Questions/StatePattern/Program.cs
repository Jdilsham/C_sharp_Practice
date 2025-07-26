using StatePattern;
using System;

public class Client
{
    static void Main(string[] args)
    {
        MobilePhone phone = new MobilePhone(new SilentState());

        phone.Alert();

        phone.setState(new VibrationState());

        phone.Alert();

        phone.setState(new SilentState());

        phone.Alert();
    }
}