using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Workshop
{
    public class WorkshopRepository :Repositories.Workshop.IWorkshopRepository
    {
        private static List<Modele.Workshop.Workshop> _workshopuri = new List<Modele.Workshop.Workshop>();

        public WorkshopRepository()
        {
        }

        public void AdaugaWorkshop(Modele.Workshop.Workshop workshop)
        {
            var result = _workshopuri.FirstOrDefault(w => w.Equals(workshop));

            if (result != null) throw new DuplicateWaitObjectException();

            _workshopuri.Add(workshop);
            Console.WriteLine("Un nou workshop a fost adaugat.");
        }

        public void ActualizeazaWorkshop(Modele.Workshop.Workshop workshop)
        {
            Console.WriteLine("Modificarile au fost salvate.");
        }

        public Modele.Workshop.Workshop GasesteWorkshopDupaNume(string nume)
        {
            return _workshopuri.FirstOrDefault(w => w.Nume.Text == nume);
        }
    }
}
