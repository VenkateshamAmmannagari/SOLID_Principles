using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.DependencyInversion
{
    internal class ProductService
    {
        private readonly FileLogger _fileLogger = new FileLogger();
        private readonly DatabaseLogger _databaseLogger = new DatabaseLogger();
        //private readonly Ilog _log;

        //public ProductService(Ilog log)
        //{
        //        _log = log;
        //}

        //public void Log(string message)
        //{
        //    _log.Log(message);
        //}
        public void LogToFile(string message) => _fileLogger.Log(message);
        public void LogToDatabase(string message) => _databaseLogger.Log(message);
    }
}
