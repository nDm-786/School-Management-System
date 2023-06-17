using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDAOEL2NDM.Affiliate_Program
{
    internal interface IAffiliateProgram
    {
        void ProvideAffiliatePortals(User affiliate);
        void ProvideMarketingData(User affiliate);
    }
}
