using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.Liskov_Substitution_Principle.Bad
{
    public class PlatinumAccount : AccountAccess
    {
        public override List<string> GetArticlesAccessDetails()
        {
            return new List<string>() { "Article One", "Article Two" };
        }
        public override List<string> GetCoursesAccessDetails()
        {
            return new List<string>() { "Course A", "Course B" };
        }
        public override List<string> GetMentorAccessDetails()
        {
            return new List<string>() { "Ali", "Ehsan" };
        }
    }
}
