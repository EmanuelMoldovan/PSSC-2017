using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modele.Activitate;
using Modele.Generic;

namespace Repositories.Activitate
{
    public class ActivitateRepository
    {
        private static List<Modele.Activitate.Activitate> _activitate = new List<Modele.Activitate.Activitate>();

        public ActivitateRepository()
        {

        }

        public void AdaugaActivitate(Modele.Activitate.Activitate activitate)
        {
            var result = _activitate.FirstOrDefault(a => a.Equals(activitate));
            if (result != null)
                throw new DuplicateWaitObjectException();
            _activitate.Add(activitate);
            Console.WriteLine("Activitate noua adaugata");
        }

        public void ActualizeazaActivitate(Modele.Activitate.Activitate activitate)
        {
            Console.WriteLine("Modificari salvate");
        }

        public Modele.Activitate.Activitate GasesteActivitate(string nume)
        {
            return _activitate.FirstOrDefault(d => d.nume.Text == nume);
        }
    }
}
