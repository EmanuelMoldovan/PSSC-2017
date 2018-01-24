using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;
using Modele.Generic;

namespace Modele.Depozit
{
   public  class DepozitFactory
    {
        public static readonly DepozitFactory Instance = new DepozitFactory();

        private DepozitFactory()
        {

        }

        public Depozit CreazaDepozit(int nrRaft)
        {
            Contract.Requires<ArgumentInvalidException>(
                    nrRaft >= 1 && nrRaft <= 50,
                    "Dati un numar intre 1 si 50");

            var depozit = new Depozit(nrRaft);
            return depozit;
        }
    }
}
