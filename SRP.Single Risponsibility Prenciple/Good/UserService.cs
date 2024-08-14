using SRP.Single_Risponsibility_Prenciple.CommonTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SRP.Single_Risponsibility_Prenciple.Good
{
    public class UserService
    {
        private MailService _mailServiceClient;
        private DbContext _dbContext;

        public UserService(MailService mailClient, DbContext dbContext)
        {
            _mailServiceClient = mailClient;
            _dbContext = dbContext;
        }

        //The logic of implementing the services is written outside the class,  
        //which means that this class is only responsible for Garber registration
        //and has nothing to do with validation and email sending.

        public User RegisterUser(string nome, string email)
        {
            if (!_mailServiceClient.ValidateEmail(email))
                throw new ValidationException($"{nameof(email)} não é um e-mail");

            var user = new User(nome, email);

            var response = _dbContext.Insert(user);

            if (response)
                _mailServiceClient.SendMail(new MailMessages(user.Email, $"Welcome, ${user.Name}"));

            return user;
        }
    }
}
