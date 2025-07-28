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


    }
}
