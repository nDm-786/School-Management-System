using SDAOEL2NDM.Message_Queueing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDAOEL2NDM.Notifications
{
    internal interface IMessageQueue
    {
        void EnqueueOrder(Order order);
        void Subscribe(IObservor observor);
        void Unsubscribe(IObservor observor);

    }
}
