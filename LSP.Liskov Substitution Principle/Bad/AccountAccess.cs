using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.Liskov_Substitution_Principle.Bad
{
    public abstract class AccountAccess
    {
        public abstract List<string> GetArticlesAccessDetails();
        public abstract List<string> GetCoursesAccessDetails();
        public abstract List<string> GetMentorAccessDetails();
    }
}
