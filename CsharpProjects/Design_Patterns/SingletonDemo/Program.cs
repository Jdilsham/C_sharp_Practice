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
            Singleton fromEmployee = Singleton.GetInstance;
            fromEmployee.PrintDetails("From Employee");

            Singleton fromStudent = Singleton.GetInstance;
            fromStudent.PrintDetails("From Student");
            Console.ReadLine();
        }
    }
}
