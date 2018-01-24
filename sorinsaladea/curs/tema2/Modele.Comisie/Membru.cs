using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.Comisie
{
    public class Membru
    {
        public string nume;
        public string prenume;
        public string studii;
        public DateTime dataN;
        public Membru(string nume, string prenume, string studii, DateTime dataN)
        {
            this.nume = nume;
            this.prenume = prenume;
            this.studii = studii;
            this.dataN = dataN;
        }
    }
}
