using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSSC_DDDModel.Modele.Farmacie
{
    class FarmacieFactory
    {
        public static readonly FarmacieFactory Instance = new FarmacieFactory();

        private FarmacieFactory()
        {

        }

        public Farmacia CreateFarmacia(string denumire)
        {
            return new Farmacia(denumire);
        }
    }
}
