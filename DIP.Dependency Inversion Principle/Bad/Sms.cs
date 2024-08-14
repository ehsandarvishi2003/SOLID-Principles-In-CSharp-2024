using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP.Dependency_Inversion_Principle.Bad
{
    public class Sms
    {
        public void Send(string message)
        {
            // ... send message
        }
    }
}
