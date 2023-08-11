using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Interface.Segregation
{
    internal class ScrumMaster : ISprint
    {
        public void AssignTask()
        {
            Console.Write("Assign Task");
        }

        public void CreateTask()
        {
            Console.Write("Create Task");
        }

        public void WorkOnTask()
        {
            throw new NotImplementedException();
        }
    }
}
