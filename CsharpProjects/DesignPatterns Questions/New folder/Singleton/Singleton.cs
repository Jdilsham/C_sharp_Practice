using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class DatabaseConnection
    {
        private static DatabaseConnection instance;

        private DatabaseConnection() { }

        public static DatabaseConnection getInstance()
        {
            if(instance == null)
            {
                instance = new DatabaseConnection();
            }

            return instance;
        }

        public void Connect()
        {
            Console.WriteLine("Connected");
        }
        public void Disconnect()
        {
            Console.WriteLine("Disconnected");
        }
    }
}
