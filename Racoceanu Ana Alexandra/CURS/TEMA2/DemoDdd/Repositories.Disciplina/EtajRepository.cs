using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Modele.Etaj;

namespace Repositories.Etaj
{
    public class EtajRepository : Repositories.Etaj.IEtajRepository
    {
        private static List<Modele.Etaj.Etaj> _etaje = new List<Modele.Etaj.Etaj>();

        public EtajRepository()
        {
        }

        public void AdaugaEtaj(Modele.Etaj.Etaj etaj)
        {
            var result = _etaje.FirstOrDefault(d => d.Equals(etaj));

            if (result != null) throw new DuplicateWaitObjectException();

            _etaje.Add(etaj);
            Console.WriteLine("Un nou etaj a fost adaugat.");
        }

        public void ActualizeazaEtaj(Modele.Etaj.Etaj disciplina)
        {
            Console.WriteLine("Modificarile au fost salvate.");
        }

        public Modele.Etaj.Etaj GasesteEtajulDupaNumar(string numar)
        {
            return _etaje.FirstOrDefault(d => d.Numar.Text == numar);
        }
    }
}
