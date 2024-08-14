using DIP.Dependency_Inversion_Principle.Good.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP.Dependency_Inversion_Principle.Good
{
    public class Whatsapp : IMessageType
    {
        public void Send(string message)
        {
            // ... send message
        }
    }
}
