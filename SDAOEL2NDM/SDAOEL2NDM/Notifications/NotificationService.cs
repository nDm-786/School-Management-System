using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDAOEL2NDM.Notifications
{
    internal class NotificationService : INotificationService
    {
        public void ScheduleNewsletterEmail(User user, string content)
        {
            // It sends a newsletter email to the user
            Console.WriteLine("Notification having Message \"{0}\" sent to {1} with Id {2} via Email", content, user.Name, user.UserId);
        }

        public void ScheduleTextNotification(User user, string message)
        {
            // It sends a text notification to the user
            Console.WriteLine("Notification having Message \"{0}\" sent to {1} with Id {2} via Text", message, user.Name, user.UserId);
        }

        public void ScheduleInAppNotification(User user, string message)
        {
            // It sends an in-app notification to the user
            Console.WriteLine("Notification having Message \"{0}\" sent to {1} with Id {2} via InAPP Notification", message, user.Name, user.UserId);
        }
    }
}
