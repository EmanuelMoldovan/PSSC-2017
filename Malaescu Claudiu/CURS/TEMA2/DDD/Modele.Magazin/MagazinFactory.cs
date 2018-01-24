using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;
using Modele.Generic;

namespace Modele.Magazin
{
   public  class MagazinFactory
    {
        public static readonly MagazinFactory Instance = new MagazinFactory();

        private MagazinFactory()
        {

        }

        public Magazin CreeazaMagazin(int nrRaft)
        {
            Contract.Requires<ArgumentInvalidException>(
                    nrRaft >= 1 && nrRaft <= 50,
                    "Dati un numar intre 1 si 50");

            var magazin = new Magazin(nrRaft);
            return magazin;
        }
    }
}
