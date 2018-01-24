using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.Generic
{
    public class IBANFormatNotOKException: ArgumentException
    {
        public IBANFormatNotOKException(string parameterName)
            : base("IBAN Format(L=letter, D=digit): LLDDLLLL + 16*D", parameterName)
        {

        }
    }
}
