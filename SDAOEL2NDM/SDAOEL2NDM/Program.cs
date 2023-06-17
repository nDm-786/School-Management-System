using SDAOEL2NDM.Affiliate_Program;
using SDAOEL2NDM.Extensions;
using SDAOEL2NDM.Message_Queueing;
using SDAOEL2NDM.Notifications;
using SDAOEL2NDM.Payment_Gateway;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDAOEL2NDM
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Simulate the Message Queueing module
            IMessageQueue messageQueue = new MessageQueue();
            IObserver orderProcessor = new OrderProcessor();
            messageQueue.Subscribe(orderProcessor);

            Order order1 = new Order();
            order1.OrderId = 101;
            order1.Amount = 1024;
            IPaymentGateway paymentGateway1 = new JazzCashAdapter(new JazzCash());
            paymentGateway1.ProcessPayment(1024);messageQueue.EnqueueOrder(order1);
            Order order2 = new Order();
            
           
            order2.OrderId = 102;
            order2.Amount = 2890;
            IPaymentGateway paymentGateway2 = new CryptoAdapter(new Crypto());
            paymentGateway2.ProcessPayment(2890);
            messageQueue.EnqueueOrder(order2);
            

            // Simulate the Notifications module
            INotificationService notificationService = new NotificationService();
            User user1 = new User();
            user1.Name = "Muhammad Nadeem";
            user1.UserId = 1001;
            User user2 = new User();
            user2.Name = "Shahzeb";
            user2.UserId = 1002;
            string content = "Payment Successful";
            string message = content;
            notificationService.ScheduleNewsletterEmail(user1, content);
            notificationService.ScheduleTextNotification(user1, message);
            notificationService.ScheduleNewsletterEmail(user2, content);
            notificationService.ScheduleTextNotification(user2, message);

            // Simulate the Affiliate Program module
            IAffiliateProgram affiliateProgramService = new AffiliateProgram();
            User affiliate = new User();
            affiliate.Name = "Muhammad Zain";
            affiliate.UserId = 12;
            affiliateProgramService.ProvideAffiliatePortals(affiliate);

            Console.WriteLine("\nSimulating Extension Modules:");
            // Simulate the Extensions module
            IExtension extensionService = new Extension();
            extensionService.ExposeEndpoints();


        }
    }
}
