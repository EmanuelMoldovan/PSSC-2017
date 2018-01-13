using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.Generic.Exceptions
{
    public class IBANLengthNotOKException: ArgumentException
    {
        public IBANLengthNotOKException(string parameterName)
            : base("IBAN lenght is 24 characters", parameterName)
        {

        }
    }
}
