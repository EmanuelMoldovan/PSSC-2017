using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.Medicament
{
   public class Medicament
    {
        Furnizor Furnizor { get; set; }
        string Nume { get; set; }
        int Stoc { get; set; }

        public Medicament(Furnizor furnizor,string nume,int stoc)
        {
            Contract.Requires(furnizor != null, "furnizor");
            Contract.Requires(nume != null, "nume");
                      
            Furnizor = furnizor;
            Nume = nume;
            Stoc = stoc;
        }
        public override string ToString()
        {
            return Nume.ToString() + "   Stoc:" + Stoc.ToString()+"\nFurnizor:"+Furnizor.ToString()+"\n";
        }

        public override bool Equals(object obj)
        {
            var medicament = (Medicament)obj;

            if (medicament != null)
            {
                return Nume.Equals(medicament.Nume);
            }
            return false;
        }

    }
}
