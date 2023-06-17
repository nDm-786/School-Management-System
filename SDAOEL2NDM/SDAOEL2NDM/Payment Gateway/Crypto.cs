using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDAOEL2NDM.Payment_Gateway
{
    internal class Crypto
    {
        public void ProcessCryptoPayment(int amount)
        {
            Console.WriteLine("Payment of Amount : \"Rs.{0}\" done using CryptoGateway", amount);
        }

    }
}
