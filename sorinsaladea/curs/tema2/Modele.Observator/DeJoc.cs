using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modele.Comisie;

namespace Modele.Observator
{
    class DeJoc:Membru
    {
        public int aniJucati;
        public DeJoc(string nume,string prenume,string studii,DateTime dataN,int aniJucati):base(nume,prenume,studii,dataN)
        {
            this.aniJucati = aniJucati;
        }
    }
}
