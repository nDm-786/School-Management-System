using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDAOEL2NDM.Notifications
{
    internal interface INotificationService
    {
        void ScheduleNewsletterEmail(User user, string content);
        void ScheduleTextNotification(User user, string message);
        void ScheduleInAppNotification(User user, string message);
    }
}
