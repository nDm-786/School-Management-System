using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDAOEL2NDM.Payment_Gateway
{
    internal class EasyPaisaAdapter : IPaymentGateway
    {
        private EasyPaisa easypaisaGateway;

        public EasyPaisaAdapter(EasyPaisa easypaisaGateway)
        {
            this.easypaisaGateway = easypaisaGateway;
        }

        public void ProcessPayment(int amount)
        {
            // Call the appropriate methods on the EasypaisaGateway
            easypaisaGateway.ProcessEasypaisaPayment(amount);
        }
    }
}
