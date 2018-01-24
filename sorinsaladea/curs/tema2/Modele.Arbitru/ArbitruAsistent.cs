using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modele.Comisie;

namespace Modele.Arbitru
{
    class ArbitruAsistent:Membru
    {
        public int meciuri;
        public ArbitruAsistent(string nume,string prenume,string studii,DateTime dataN,int meciuri):base(nume,prenume,studii,dataN)
        {
            this.meciuri = meciuri;
        }
    }
}
