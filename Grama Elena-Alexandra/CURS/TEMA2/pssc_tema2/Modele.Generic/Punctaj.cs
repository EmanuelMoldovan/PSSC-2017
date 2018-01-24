using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Modele.Generic
{
    public class Punctaj
    {
        private int _valoare;
        public int ValoareNota { get { return _valoare; } }

        public Punctaj(int valoare)
        {
            //Contract.Requires<ArgumentException>(valoare > 0, "valoare");
            //Contract.Requires<ArgumentException>(valoare <= 10, "valoare");

            _valoare = valoare;
        }

        public Punctaj()
        {
        }
    }
}
