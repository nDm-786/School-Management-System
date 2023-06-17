using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDAOEL2NDM.Message_Queueing
{
    internal class OrderProcessor : IObservor
    {
        public void Update(Order order)
        {
            Console.WriteLine("Order having Order Id: {0} of Amount: {1} is successfully updated", order.OrderId, order.Amount);
        }

    }
}
