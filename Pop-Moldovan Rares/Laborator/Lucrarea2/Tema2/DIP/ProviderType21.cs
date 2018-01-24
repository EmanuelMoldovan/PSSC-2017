using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.DIP.Correct
{
    class ProviderType21 : IProvider
    {
        public int Provide()
        {
            throw new NotImplementedException();
        }
    }
}
