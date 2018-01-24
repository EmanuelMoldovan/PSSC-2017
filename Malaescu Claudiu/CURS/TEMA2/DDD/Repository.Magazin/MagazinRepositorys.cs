using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Magazin
{
    public class MagazinRepositorys
    {
        private static List<Modele.Magazin.Magazin> _magazin = new List<Modele.Magazin.Magazin>();
       
        public void AdaUgaMagazin(Modele.Magazin.Magazin magazin)
        {
            var result = _magazin.FirstOrDefault(d => d.Equals(magazin));

            if (result != null) throw new DuplicateWaitObjectException();

            _magazin.Add(magazin);
            Console.WriteLine("Un nou depozit a fost adaugat.");
        }

        public void ActualizeazaDepozit(Modele.Magazin.Magazin magazin)
        {
            //persit changes to the database
            Console.WriteLine("Modificarile au fost salvate.");
        }

        public Modele.Magazin.Magazin GasesteMagazinulDupaNume(string nume)
        {
            return _magazin.FirstOrDefault(d => d.nume == nume);
        }  
    }
}
