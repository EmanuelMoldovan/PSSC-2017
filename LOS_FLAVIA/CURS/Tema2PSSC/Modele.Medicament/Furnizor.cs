using Modele.Generic;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.Medicament
{
   public class Furnizor
    {
        string Nume { get; set; }
        Adresa Adresa { get; set; }
        public Furnizor(string nume, Adresa adresa)
        {
            Contract.Requires(nume != null, "nume");
            Contract.Requires(adresa != null, "adresa");
            Nume = nume;
            Adresa = adresa;
        }
        public override string ToString()
        {
            return Nume.ToString() + "  Adresa:" + Adresa.toString();
        }

        public override bool Equals(object obj)
        {
            var fur = (Furnizor)obj;

            if (fur != null)
            {
                return Nume.Equals(fur.Nume);
            }
            return false;
        }
    }
}
