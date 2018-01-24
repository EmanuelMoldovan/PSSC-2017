using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repositories.Cabinet
{
    public class CabinetRepository : Repositories.Cabinet.ICabinetRepository
    {
        private static List<Modele.Cabinet.Cabinet> _cabinete = new List<Modele.Cabinet.Cabinet>();

        public CabinetRepository()
        {
        }

        public void AdaugaCabinet(Modele.Cabinet.Cabinet cabinet)
        {
            var result = _cabinete.FirstOrDefault(d => d.Equals(cabinet));

            if (result != null) throw new DuplicateWaitObjectException();

            _cabinete.Add(cabinet);
            Console.WriteLine("Un nou cabinet a fost adaugat.");
        }

        public void ActualizeazaCabinet(Modele.Cabinet.Cabinet cabinet)
        {
            //persit changes to the database
            Console.WriteLine("Modificarile au fost salvate.");
        }

        public Modele.Cabinet.Cabinet GasesteCabinetDupaNume(string nume)
        {
            return _cabinete.FirstOrDefault(d => d.Nume.Text == nume);
        }
    }
}
