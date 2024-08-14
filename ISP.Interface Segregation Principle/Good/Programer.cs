using ISP.Interface_Segregation_Principle.Good.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP.Interface_Segregation_Principle.Good
{
    public class Programmer : IProgrammer
    {
        public void WorkOnTask()
        {
            //... work on task
        }
    }
}
