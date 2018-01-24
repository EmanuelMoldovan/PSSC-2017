using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.Generic
{
    public class Adresa
    {
        public string Judet { get; set; }
        public string Localitate { get; set; }
        public string Strada { get; set; }
        public int NrStrada { get; set; }

        public Adresa(string judet, string localitate, string strada, int nr)
        {
            Judet = judet;
            Localitate = localitate;
            Strada = strada;
            NrStrada = nr;

        }

        public string toString()
        {
            return Judet + " , " + Localitate + " , " + Strada + " , " + NrStrada;
        }
    }
}

