using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PSSC_DDDModel.Modele.Farmacie;

namespace PSSC_DDDModel.Repositories
{
    class MedicamentRepository
    {
        private static List<Medicament> medicamente = new List<Medicament>();

        public MedicamentRepository()
        {

        }

        public void AdaugaMedicament(Medicament medicament)
        {
            var result = medicamente.FirstOrDefault(m => m.Equals(medicament));

            if (result != null) throw new DuplicateWaitObjectException();

            medicamente.Add(medicament);
            Console.WriteLine("Un nou medicament a fost adaugat");
        }

        public void ActualizeazaMedicament(Medicament medicament)
        {
            //persist changer to the database

            Console.WriteLine("Modificarile au fost salvate");
        }

        public Medicament GasesteMedicamentDupaNume(string denumire)
        {
            return medicamente.FirstOrDefault(m => m.denumire.Text == denumire);
        }
    }
}
