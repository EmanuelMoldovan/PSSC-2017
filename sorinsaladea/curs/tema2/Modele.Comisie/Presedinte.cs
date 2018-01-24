using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.Comisie
{
    class Presedinte:Membru
    {
        public int mandat;
        public Presedinte(string nume, string prenume, string studii, DateTime dataN, int mandat) : base(nume, prenume, studii, dataN)
        {
            this.mandat = mandat;
        }
    }
}
