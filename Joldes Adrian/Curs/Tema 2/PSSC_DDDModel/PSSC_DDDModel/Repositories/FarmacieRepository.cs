using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PSSC_DDDModel.Modele.Farmacie;

namespace PSSC_DDDModel.Repositories
{
    class FarmacieRepository
    {

        private static List<Farmacia> farmacii = new List<Farmacia>();

        public FarmacieRepository()
        {

        }

        public void AdaugaFarmacie(Farmacia farmacie)
        {
            var result = farmacii.FirstOrDefault(f => f.Equals(farmacie));

            if (result != null) throw new DuplicateWaitObjectException();

            farmacii.Add(farmacie);
            Console.WriteLine("O noua farmacie a fost adaugata");
        }

        public void ActualizeazaFarmacie(Farmacia farmacia)
        {
            //persist changer to the database

            Console.WriteLine("Modificarile au fost salvate");
        }

        public Farmacia GasesteFarmaciaDupaNume(string nume)
        {
            return farmacii.FirstOrDefault(f => f.nume.Text == nume);
        }

    }
}
