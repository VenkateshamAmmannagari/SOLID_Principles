﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Interface.Segregation
{
    internal interface ISprint
    {
        void CreateTask();
        void AssignTask();
        void WorkOnTask();
    }
}
