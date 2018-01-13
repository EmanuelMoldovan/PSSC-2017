using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.Generic.Exceptions
{

    public class AccountNotFoundException : ArgumentException
    {
        public AccountNotFoundException()
            : base("Account not found in the DB")
        {

        }
    }
}
