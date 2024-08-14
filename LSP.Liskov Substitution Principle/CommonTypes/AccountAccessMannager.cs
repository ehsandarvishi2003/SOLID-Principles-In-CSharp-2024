using LSP.Liskov_Substitution_Principle.Bad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.Liskov_Substitution_Principle.CommonTypes
{
    class AccountAccessMannager
    {
        public AccountAccessMannager()
        {
            
        }
        public void GetMentorFromAccounts(List<AccountAccess> accounts)
        {
            foreach (var account in accounts)
            {
                account.GetMentorAccessDetails();
            }
        }
    }
}
