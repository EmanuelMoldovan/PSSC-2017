using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.Generic.Exceptions
{
    public class ArgumentNumbersException : ArgumentException
    {
        public ArgumentNumbersException(string message) : base(message)
        {

        }
    }
}
