using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.Generic.Exceptions
{
    public class IBANAlreadyExistingException: ArgumentException
    {
        public IBANAlreadyExistingException()
            : base("IBANs should be unique")
        {

        }
    }
}
