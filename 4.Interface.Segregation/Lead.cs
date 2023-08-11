using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Interface.Segregation
{
    internal class Lead : ISprint
    {
        public void CreateTask()
        {
            Console.WriteLine("Create Task");
        }

        public void AssignTask()
        {
            Console.WriteLine("Assign Task");
        }

        public void WorkOnTask()
        {
            Console.WriteLine("Work on Task");
        }
    }
}
