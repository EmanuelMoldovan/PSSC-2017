using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.Generic.Exceptions
{
 

    public class InsufficientFundsException : ArgumentException
    {
        public InsufficientFundsException()
            : base("Sold insuficient pt aceasta tranzactie")
        {

        }
    }
}
