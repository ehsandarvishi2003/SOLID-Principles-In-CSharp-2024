using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP.Interface_Segregation_Principle.Bad.Interfaces
{
    interface ILead
    {
        void CreateTask();

        void ReviewTask();

        void WorkOnTask();
    }
}
