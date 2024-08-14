using DIP.Dependency_Inversion_Principle.CommonTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP.Dependency_Inversion_Principle.Good
{
    public class Notify
    {
        public void NotifyMessage(string message, EnumMessageType type)
        {
            Notification notification = null;

            if (TryGetNotificationStrategy(type, ref notification))
            {
                notification.SendNotification(message);
            }

            notification.SendNotification(message);
        }

        private bool TryGetNotificationStrategy(EnumMessageType type, ref Notification notification)
        {
            switch (type)
            {
                case EnumMessageType.Email:
                    notification = new Notification(new Email());
                    break;
                case EnumMessageType.Whatsapp:
                    notification = new Notification(new Whatsapp());
                    break;
                case EnumMessageType.Sms:
                    notification = new Notification(new Sms());
                    break;
                default:
                    notification = new Notification(new Email());
                    break;
            }

            return notification != null;

            //This parameter is also passed to the method, but using the "ref" keyword. 
            //This means that the notification parameter is passed to the method by reference, 
            //so if the method modifies this parameter, the changes will be applied to the original value passed to the method. 
            //Therefore, the method can modify the Notification object, and these changes will be visible outside the method after it executes.
        }
    }
}
