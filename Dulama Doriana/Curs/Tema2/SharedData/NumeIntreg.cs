using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Pacienti
{
    public class NumeIntreg
    {
        public string nume;
        public string prenume;

        public NumeIntreg(string n, string p)
        {
            nume = n;
            prenume = p;
        }

        public string toString()
        {
            return nume + " " + prenume;
        }
    }
}
