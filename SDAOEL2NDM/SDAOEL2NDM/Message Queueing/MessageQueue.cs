using SDAOEL2NDM.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDAOEL2NDM.Message_Queueing
{
    internal class MessageQueue : IMessageQueue
    {
        private List<IObservor> observors;
        private Queue<Order> orderQueue;

        public MessageQueue()
        {
            observors = new List<IObservor>();
            orderQueue = new Queue<Order>();
        }

        public void EnqueueOrder(Order order)
        {
            orderQueue.Enqueue(order);
            Notifyobservors(order);
        }

        public void Subscribe(IObservor observor)
        {
            observors.Add(observor);
        }

        public void Unsubscribe(IObservor observor)
        {
            observors.Remove(observor);
        }

        private void Notifyobservors(Order order)
        {
            foreach (var observor in observors)
            {
                observor.Update(order);
            }
        }

    }
}
