using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDAOEL2NDM.Payment_Gateway
{
    internal class CryptoAdapter : IPaymentGateway
    {
        private Crypto cryptoGateway;

        public CryptoAdapter(Crypto cryptoGateway)
        {
            this.cryptoGateway = cryptoGateway;
        }

        public void ProcessPayment(int amount)
        {
            // Call the appropriate methods on the CryptoGateway
            cryptoGateway.ProcessCryptoPayment(amount);
        }

    }
}
