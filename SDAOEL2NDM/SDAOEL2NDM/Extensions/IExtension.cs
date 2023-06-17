using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDAOEL2NDM.Extensions
{
    internal interface IExtension
    {
        void ExposeEndpoints();
        void UsePublicData();
    }
}
