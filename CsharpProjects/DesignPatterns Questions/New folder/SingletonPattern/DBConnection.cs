using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    internal class DBConnection
    {
        private static DBConnection instance;

        private DBConnection() { }

        public static DBConnection getInstance()
        {
            if (instance == null)
            {
                instance = new DBConnection();
            }
            return instance;
        }

        public void Connect()
        {
            Console.WriteLine("Connected");
        }

        public void Disconnect()
        {
            Console.WriteLine("Diconnected");
        }
    }
}
