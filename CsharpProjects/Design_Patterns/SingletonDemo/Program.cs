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
            /*Singleton fromEmployee = Singleton.GetInstance;
            fromEmployee.PrintDetails("From Employee");

            Singleton fromStudent = Singleton.GetInstance;
            fromStudent.PrintDetails("From Student");
            Console.ReadLine();
            */


            //Getinstance in paralal
            //This violate the singleton principles
            Parallel.Invoke(
                    () => PrintEmployeeDetails(),
                    () => PrintStudentDetails()
            );
           

            Console.ReadLine();
        }

        private static void PrintEmployeeDetails()
        {
            Singleton fromEmployee = Singleton.GetInstance;
            fromEmployee.PrintDetails("From Employee");
        }

        private static void PrintStudentDetails()
        {
            Singleton fromStudent = Singleton.GetInstance;
            fromStudent.PrintDetails("From Student");
        }
    }
}
