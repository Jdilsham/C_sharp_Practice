using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDemo
{
    public static class Converter
    {
        public static double ToFahrenheit(double celcius)
        {
            return (celcius * 9 / 5) + 32;
        }

        public static double ToCelcius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
    }
}
