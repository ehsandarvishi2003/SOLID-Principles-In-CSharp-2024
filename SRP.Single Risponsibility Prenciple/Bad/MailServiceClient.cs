using SRP.Single_Risponsibility_Prenciple.CommonTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SRP.Single_Risponsibility_Prenciple.Bad
{
    public static class MailServiceClient
    {
        public static bool Send(MailMessages mail)
        {
            return true;
        }
    }
}
