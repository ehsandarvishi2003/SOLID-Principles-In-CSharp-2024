using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.Single_Risponsibility_Prenciple.CommonTypes
{
    public class User
    {
        public User(string nome, string email)
        {
            Name = nome;
            Email = email;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
