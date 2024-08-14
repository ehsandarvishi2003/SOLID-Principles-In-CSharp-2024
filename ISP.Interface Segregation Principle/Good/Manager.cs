using ISP.Interface_Segregation_Principle.Good.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP.Interface_Segregation_Principle.Good
{
    public class Manager : ILead
    {
        public void CreateTask()
        {
            //... create task
        }

        public void ReviewTask()
        {
            //... review task
        }

    }
}
