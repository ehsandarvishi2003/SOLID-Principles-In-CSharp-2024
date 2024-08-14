using LSP.Liskov_Substitution_Principle.CommonTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.Liskov_Substitution_Principle.Bad
{
    public static class TestAccountAccess
    {
        static void GetAccountAccess()
        {
            AccountAccessMannager accountAccess = new AccountAccessMannager();

            List<AccountAccess> accounts = new List<AccountAccess>();
            accounts.Add(new FreeAccount());
            accounts.Add(new GoldAccount());
            accounts.Add(new PlatinumAccount());

            accountAccess.GetMentorFromAccounts(accounts);
        }
    }
}
