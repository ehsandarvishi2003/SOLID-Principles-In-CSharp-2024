using DIP.Dependency_Inversion_Principle.Good.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP.Dependency_Inversion_Principle.Good
{
    public class Notification
    {
        private IMessageType _messageType;

        public Notification(IMessageType messageType)
        {
            _messageType = messageType;
        }

        public void SendNotification(string message)
        {
            _messageType.Send(message);
        }
    }
}
