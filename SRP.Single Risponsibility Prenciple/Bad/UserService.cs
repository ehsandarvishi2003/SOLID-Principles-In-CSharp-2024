using SRP.Single_Risponsibility_Prenciple.CommonTypes;
using System.ComponentModel.DataAnnotations;

namespace SRP.Single_Risponsibility_Prenciple.Bad
{
    public class UserService
    {
        public User RegisterUser(string nome, string email)
        {
            if (!ValidateEmail(email))
                throw new ValidationException($"{nameof(email)} It's not an email");

            DbContext dbContext = new DbContext();

            var user = new User(nome, email);

            var response = dbContext.Insert(user);

            if (response)
                SendEmail(new MailMessages(user.Email, $"Welcome, ${user.Name}"));

            return user;
        }

        public bool ValidateEmail(string email)
        {
            return email.Contains('@');
        }

        public bool SendEmail(MailMessages msg)
        {
            return MailServiceClient.Send(msg);
        }
    }
}
