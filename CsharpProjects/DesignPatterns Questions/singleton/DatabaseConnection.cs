using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleton
{
    internal class DatabaseConnection
    {
        private static DatabaseConnection instance;
        private DatabaseConnection() {
            Console.WriteLine("Database Connection Established.");
        }

        public static DatabaseConnection Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DatabaseConnection();
                }
                return instance;
            }
        }

        public void connect()
        {
            Console.WriteLine("Connecting to the database...");   
        }

        public void disconnect()
        {
            Console.WriteLine("Disconnecting database...");
        }
    }

}
