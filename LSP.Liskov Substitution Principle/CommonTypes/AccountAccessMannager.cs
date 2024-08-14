using LSP.Liskov_Substitution_Principle.Bad;

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
