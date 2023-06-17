using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDAOEL2NDM.Payment_Gateway
{
    internal class JazzCashAdapter : IPaymentGateway
    {
        private JazzCash JazzcashGateway;

        public JazzCashAdapter(JazzCash JazzcashGateway)
        {
            this.JazzcashGateway = JazzcashGateway;
        }

        public void ProcessPayment(int amount)
        {
            // Call the appropriate methods on the JazzcashGateway
            JazzcashGateway.ProcessJazzcashPayment(amount);
        }
    }
}
