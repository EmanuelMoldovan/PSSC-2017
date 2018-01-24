using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Gradina
{
    public class NotEnoughFlowersException : SystemException
    {
        public NotEnoughFlowersException(string message)
            : base(message)
        {
        }
    }

}
