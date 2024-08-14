using ISP.Interface_Segregation_Principle.Bad.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP.Interface_Segregation_Principle.Bad
{
    public class Manager : ILead
    {
        public void CreateTask()
        {
            // .. create task
        }

        public void ReviewTask()
        {
            // ... review task
        }

        public void WorkOnTask()
        {
            throw new Exception("Manager can't work on Task");
        }
    }
}
