using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryClient.cs
{
    class CnpDuplicat : Exception
    {
        private String Cnp;

        public CnpDuplicat(String cnp)
        {
            Cnp = cnp;
        }

        public override string ToString()
        {
            return Cnp + " exista!";
        }
    }
}
