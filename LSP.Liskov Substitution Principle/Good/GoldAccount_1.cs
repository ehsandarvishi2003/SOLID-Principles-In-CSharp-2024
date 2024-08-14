using LSP.Liskov_Substitution_Principle.Good.AccountTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.Liskov_Substitution_Principle.Good
{
    public class GoldAccount_1 : PaidAccountAccess
    {
        public override List<string> GetArticlesAccessDetails() ////Because original "GetArticlesAccessDetails" is abstract
        {
            return new List<string>() { "Article One", "Article Two" };
        }

        public override List<string> GetCoursesAccessDetails() //Because original "GetCourseAccessDetails" is abstract
        {
            return new List<string>() { "Article A", "Article B" };
        }
    }
}
