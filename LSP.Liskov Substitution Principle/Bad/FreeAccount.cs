using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.Liskov_Substitution_Principle.Bad
{
    public class FreeAccount:AccountAccess
    {
        public override List<string> GetArticlesAccessDetails()
        {
            return new List<string>() { "Article One", "Article Two" };
        }
        public override List<string> GetCoursesAccessDetails()
        {
            throw new NotImplementedException();
        }
        public override List<string> GetMentorAccessDetails()
        {
            throw new NotImplementedException();
        }
    }
}
