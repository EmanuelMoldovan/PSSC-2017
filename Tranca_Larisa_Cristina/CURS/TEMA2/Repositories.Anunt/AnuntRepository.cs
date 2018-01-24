using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Repositories.Anunt
{
    public class AnuntRepository : IAnuntRepository
    {
        private static List<Module.Anunt.Anunt> _anunturi = new List<Modele.Anunt.Anunt>();

        public AnuntRepository()
        {
        }

        public void AdaugaAnunt(Modele.Anunt.Anunt anunt)
        {
            var result = _anunturi.FirstOrDefault(a => a.Equals(anunt));

            if (result != null) throw new DuplicateWaitObjectException();

            _anunturi.Add(anunt);
            Console.WriteLine("Un nou anunt a fost adaugat.");
        }

        public void ActualizeazaAnunt(Modele.Anunt.Anunt anunt)
        {
            //persit changes to the database
            //Console.WriteLine("Modificarile au fost salvate.");
        }

        public Modele.Anunt.Anunt GasesteAnuntulDupaDescriere(string descriere)
        {
            return _anunturi.FirstOrDefault(a => a.Descriere.Text == descriere);
        }
    }
}
