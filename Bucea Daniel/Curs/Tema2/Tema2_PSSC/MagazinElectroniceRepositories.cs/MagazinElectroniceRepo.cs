using Model.MagazinElectronice;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazinElectroniceRepositories.cs
{
    public class MagazinElectroniceRepo
    {
        private static List<MagazinElectronice> magazineElectronice = new List<MagazinElectronice>();

        public void AdaugaMagazin(MagazinElectronice magazinElectronice)
        {
            var result = magazineElectronice.Find(mag => mag.Equals(magazinElectronice));

            if (result != null) throw new DuplicateWaitObjectException();

            magazineElectronice.Add(magazinElectronice);
        }

        public MagazinElectronice cautaMagazin(string nume)
        {
            return magazineElectronice.Find(mag => mag.nume.Equals(nume));
        }

        public void stergeMagazin(MagazinElectronice magazinElectronice)
        {
            var result = magazineElectronice.Find(mag => mag.Equals(magazinElectronice));

            Contract.Requires(result != null, "Magazinul nu a fost gasit");

            magazineElectronice.Remove(result);
        }

        public void AfisareListaMagazine()
        {
            foreach(var mag in magazineElectronice)
            {
                Console.WriteLine(mag.nume + " " + mag.adresa + " " + mag.nrAngajati);
            }
        }
    }
}
