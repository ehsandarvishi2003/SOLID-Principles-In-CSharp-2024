using SRP.Single_Risponsibility_Prenciple.CommonTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SRP.Single_Risponsibility_Prenciple.Good
{
    public class MailClient
    {
        public bool Send(MailMessages message)
        {
            return true;
        }
    }
}
