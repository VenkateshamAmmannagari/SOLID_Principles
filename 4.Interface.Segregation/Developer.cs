using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Interface.Segregation
{
    internal class Developer : ISprint
    {
        public void AssignTask()
        {
            throw new NotImplementedException();
        }

        public void CreateTask()
        {
            throw new NotImplementedException();
        }

        public void WorkOnTask()
        {
            Console.WriteLine("Work on task");
        }
    }
}
