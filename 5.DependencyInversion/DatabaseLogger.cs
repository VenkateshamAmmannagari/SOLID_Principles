using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.DependencyInversion
{
    internal class DatabaseLogger //:Ilog
    {
        public void Log(string message)
        {
            Console.WriteLine("Called the Log method from DatabaseLogger class");
            LogToDatabase(message);
        }
        public void LogToDatabase(string message)
        {
            Console.WriteLine($"Method : LogToDatabase, log message : {message}");
        }
    }
}
