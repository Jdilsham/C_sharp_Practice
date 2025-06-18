using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Singleton s1 = new Singleton();
            s1.PrintDetails("This is First Message");
        }
    }
}
