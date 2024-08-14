using SRP.Single_Risponsibility_Prenciple.CommonTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SRP.Single_Risponsibility_Prenciple.Good
{
    public class MailService
    {
        private MailClient _client;

        public MailService(MailClient client)
        {
            _client = client;
        }

        public bool ValidateEmail(string email)
        {
            return email.Contains('@');
        }

        public bool SendMail(MailMessages message)
        {
            return _client.Send(message);
        }
    }
}
