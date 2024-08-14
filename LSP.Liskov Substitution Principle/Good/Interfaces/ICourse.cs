using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.Liskov_Substitution_Principle.Good.Interfaces
{
    interface ICourse
    {
        List<string> GetCoursesAccessDetails();
    }
}
