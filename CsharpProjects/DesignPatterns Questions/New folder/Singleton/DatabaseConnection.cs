using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class DatabaseConnection
    {
        private static DatabaseConnection instanse;

        private DatabaseConnection()
        {
            Console.WriteLine("Database Connection Established");
        }

        public static DatabaseConnection Instance
        {
            get
            {
                if (instanse == null)
                {
                    instanse = new DatabaseConnection();
                }
                return instanse;

            }
        }

        public void Connect()
        {
            Console.WriteLine("Database Connected!");
        }
        public void Disconnect()
        {
            Console.WriteLine("Database Disconnected!");
        }
    }
}
