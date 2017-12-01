using Model.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ParcAuto
{
    public class Adresa
    {
        public PlainText Localitate { get; private set; }
        public PlainText Judet { get; private set; }
        public PlainText Strada { get; private set; }
        public int Numar { get; private set; }
     

        public Adresa(PlainText localitate, PlainText judet, PlainText strada, int numar)
        {
            Localitate = localitate;
            Judet = judet;
            Strada = strada;
            Numar = numar;
       
        }

        public override bool Equals(object obj)
        {
            var adresa = (Adresa)obj;
            return adresa.Judet.Equals(Judet)
                && adresa.Strada.Equals(Strada)
                && adresa.Numar.Equals(Numar);
        }

        public override string ToString()
        {
            return "Strada " + Strada + ", " + Numar + ", " + Localitate + ", Judet " + Judet;
        }

        public override int GetHashCode()
        {
            return Localitate.GetHashCode() + Judet.GetHashCode() + Strada.GetHashCode() + Numar.GetHashCode();
        }
    }
}

