
using Model.Generic;
using Model.ParcAuto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ParcAuto
{
   public class ParcAuto
    {
        public PlainText Nume { get; private set; }
        public Adresa Adresa { get; private set; }
        public StareParcAuto Stare { get; private set; }
        public List<Masina> ListaDeMasini { get; private set; }
        public List<Dealer> ListaDealeri { get; private set; }


        public ParcAuto(PlainText nume, Adresa adresa)
        {
            Nume = nume;
            Adresa = adresa;
           // Stare = stare;
          //  ListaDeMasini = listaMasini;
         //   ListaDealeri = dealeri;
        }

        public override string ToString()
        {
            return Nume + ", " + Adresa + ", " + Stare;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public void DeschideParc()
        {
            Stare = StareParcAuto.Deschis;
        }
        public void InchideParc()
        {
            Stare = StareParcAuto.Inchis;
        }
    }
}
