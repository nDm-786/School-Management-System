using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDAOEL2NDM.Payment_Gateway
{
    internal interface IPaymentGateway
    {
        void ProcessPayment(int amount);
    }
}
