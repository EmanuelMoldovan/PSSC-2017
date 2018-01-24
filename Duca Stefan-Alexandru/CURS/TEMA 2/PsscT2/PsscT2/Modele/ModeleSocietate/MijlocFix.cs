using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsscT2.Modele.ModeleSocietate
{
    class MijlocFix
    {
        String nume;
        private  int valoare;

        public MijlocFix(string nume, int valoare)
        {
            this.nume = nume;
            this.valoare = valoare;
        }

        public int getValoare()
        {
             return valoare; 
        }
    }
}
