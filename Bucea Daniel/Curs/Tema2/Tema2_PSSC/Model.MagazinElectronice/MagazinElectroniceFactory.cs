using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.MagazinElectronice
{
    public class MagazinElectroniceFactory
    {
        public static readonly MagazinElectroniceFactory instance = new MagazinElectroniceFactory();
        public MagazinElectronice Creeaza(string nume, string adresa, int nrAngajati)
        {
            Contract.Requires(nume != null, "Numele este null");
            var magazinElectronice = new MagazinElectronice(nume, adresa, nrAngajati);
            return magazinElectronice;
        }
        public MagazinElectronice Creeaza(string nume)
        {
            var magazinElectronice = new MagazinElectronice(nume);
            return magazinElectronice;
        }
    }
}
