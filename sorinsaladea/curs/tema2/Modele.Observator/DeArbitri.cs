using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modele.Comisie;


namespace Modele.Observator
{
    class DeArbitri:Membru
    {
        public int aniArbitraj;
        public DeArbitri(string nume,string prenume,string studii,DateTime dataN,int aniArbitraj):base(nume,prenume,studii,dataN)
        {
            this.aniArbitraj = aniArbitraj;
        }
    }
}
