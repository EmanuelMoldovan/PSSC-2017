using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XunitExample
{
    public class ExternalFunctionality : IExternalItem
    {
        public int GetSomeExternalStuff()
        {
            // some external calls
            return 1000;
        }
    }
}
