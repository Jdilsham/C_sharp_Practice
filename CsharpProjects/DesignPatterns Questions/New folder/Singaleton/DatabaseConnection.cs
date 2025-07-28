using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singaleton
{
    public class DatabaseConnection
    {
        private static DatabaseConnection instance;

        public DatabaseConnection()
        {
            Console.WriteLine("Databasae Connection Established...");
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

        public void Connect()
        {
            Console.WriteLine("Connected to the Database");
        }

        public void Disconnect() {
            Console.WriteLine("Database Disconnected");
        }
    }
}
