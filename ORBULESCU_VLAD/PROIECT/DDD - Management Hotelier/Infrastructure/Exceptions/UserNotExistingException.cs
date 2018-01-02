using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Exceptions
{
    class UserNotExistingException : Exception
    {
        public UserNotExistingException() { }

        public override string ToString()
        {
            return "Credentialele sunt gresite, incercati din nou sau creati un cont!";
        }
    }
}
