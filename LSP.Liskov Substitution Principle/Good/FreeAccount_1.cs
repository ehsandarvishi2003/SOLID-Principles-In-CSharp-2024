using LSP.Liskov_Substitution_Principle.Good.AccountTypes;
using LSP.Liskov_Substitution_Principle.Good.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.Liskov_Substitution_Principle.Good
{
    public class FreeAccount_1: IArticle
    {
        public List<string> GetArticlesAccessDetails()
        {
            return new List<string>() { "Article One", "Article Two" };
        }
    }
}
