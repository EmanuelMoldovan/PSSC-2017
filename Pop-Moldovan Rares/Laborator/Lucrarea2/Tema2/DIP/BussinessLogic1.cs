using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.DIP.Correct
{
    class BussinessLogic1
    {
        public void ComputeBussinessLogic(List<IProvider> providers)
        {
            int stuff = 0;

            // collect data from all providers
            foreach(IProvider provider in providers)
            {
                stuff += provider.Provide();
            }

            // bussiness logic
        }
    }
}
