using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.Comisie
{
    class Secretar:Membru
    {
        public string cabinet;
        public Secretar(string nume,string prenume,string studii,DateTime dataN,string cabinet):base(nume,prenume,studii,dataN)
        {
            this.cabinet = cabinet;
        }
    }
}
