using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDAOEL2NDM.Affiliate_Program
{
    internal class AffiliateProgram
    {
        public void ProvideAffiliatePortals(User affiliate)
        {
            Console.WriteLine("Portal for Affiliate with Name: {0} and Id: {1}.\nThis portal belongs to a random Service Providor which can help in marketing a certain product", affiliate.Name, affiliate.UserId);
        }

        public void ProvideMarketingData(User affiliate)
        {
            // Provide the affiliate with marketing data
        }

    }
}
