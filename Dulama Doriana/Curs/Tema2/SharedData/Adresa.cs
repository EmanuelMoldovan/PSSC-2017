using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Pacienti
{
    public class Adresa
    {
        public string judet;
        public string localitate;
        public string strada;
        public int nrStrada;

        public Adresa(string j, string l, string s, int nr)
        {
            judet = j;
            localitate = l;
            strada = s;
            nrStrada = nr;

        }

        public string toString()
        {
            return judet + " , " + localitate + " , " + strada + " , " + nrStrada;
        }
    }
}
