using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.Generic
{
    public class ArgumentInvalidException : ArgumentException
    {
        public ArgumentInvalidException(string message)
            : base(message)
        {

        }
    }
}