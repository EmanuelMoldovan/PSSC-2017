using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modele.Generic;

namespace Repository.Banca
{
    class NrInregistrareBancaDuplicat : Exception
    {
        private NrInregistrareBanca NrInreg;
        public NrInregistrareBancaDuplicat(NrInregistrareBanca nr)
        {
            NrInreg = nr;   
        }

        public override string ToString()
        {
            return NrInreg.ToString() + " exista!";
        }
    }
}
