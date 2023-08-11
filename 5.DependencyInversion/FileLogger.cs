using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.DependencyInversion
{
    internal class FileLogger //:Ilog
    {
        public void Log(string message)
        {
            Console.WriteLine("Called the Log method from FileLogger class");
            LogToFile(message);
        }
        public void LogToFile(string message)
        {
            Console.WriteLine($"Method : LogToFile, log message : {message}");
        }
    }
}
