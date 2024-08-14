using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP.Dependency_Inversion_Principle.Good.Interface
{
    public interface IMessageType
    {
        void Send(string message);
    }
}
