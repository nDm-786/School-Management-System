using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDAOEL2NDM.Message_Queueing
{
    internal interface IObservor
    {
        void Update(Order order);
    }
}
