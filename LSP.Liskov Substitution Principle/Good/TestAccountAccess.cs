using LSP.Liskov_Substitution_Principle.Bad;
using LSP.Liskov_Substitution_Principle.CommonTypes;
using LSP.Liskov_Substitution_Principle.Good.AccountTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.Liskov_Substitution_Principle.Good
{
    public static class TestAccountAccess
    {
        static void GetAccountAccess()
        {
            AccountAccessMannager accountAccess = new AccountAccessMannager();

            //List<PaidAccountAccess> accounts = new List<PaidAccountAccess>();
            //accounts.Add(new FreeAccount());
            //accounts.Add(new GoldAccount());
            //accounts.Add(new PlatinumAccount());

            //accountAccess.GetMentorFromAccounts(accounts);

            //I don't know why i'm getting error
        }
    }
}
