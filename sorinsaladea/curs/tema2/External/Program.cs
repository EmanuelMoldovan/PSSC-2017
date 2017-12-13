using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace External
{
    public class Program:IExternalItem
    {
        public int GetExternalData()
        {
            return 12;
        }
    }
}
