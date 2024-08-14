using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.Single_Risponsibility_Prenciple.CommonTypes
{
    public class MailMessages
    {
        public MailMessages(string email, string mensagem)
        {
            Email = email;
            Mensagem = mensagem;
        }
        public string Email { get; set; }
        public string Mensagem { get; set; }
    }
}
