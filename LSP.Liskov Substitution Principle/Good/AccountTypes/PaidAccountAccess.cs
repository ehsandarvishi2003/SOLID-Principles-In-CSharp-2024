using LSP.Liskov_Substitution_Principle.Good.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.Liskov_Substitution_Principle.Good.AccountTypes
{
    public abstract class PaidAccountAccess : FreeAccountAccess , ICourse
    {
        public abstract List<string> GetCoursesAccessDetails();
    }
}
