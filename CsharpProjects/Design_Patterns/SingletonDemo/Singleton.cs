using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDemo
{
    public sealed class Singleton
    {
        private static int count = 0;
        private static readonly object obj = new object();
        private static Singleton instance = null;
        public static Singleton GetInstance
        {
            get
            {
                if (instance == null)//locke methode is very expencive, so we need it if instance is null only
                {
                    lock (obj) //only one thread can enter this code block at a given point of time, both employee and student are racing 
                               //with each other in multi-threded environment lock ensure that only one thread which arrives earlier succeeds to enter
                               //the code block and other will wait till the first one is completed
                    {
                        if (instance == null)
                        {
                            instance = new Singleton();
                        }
                    }
                }
                return instance;
            }
        }
        private Singleton()
        {
            count++;
            Console.WriteLine("Counter value: " + count.ToString());
        }

        public void PrintDetails(string message) { 
            Console.WriteLine(message);
        }
    }
}
