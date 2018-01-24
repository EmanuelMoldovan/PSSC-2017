using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.LimbaStraina
{
    public class Cursuri
    {
        public NivelLimba Nivel { get; set; }
        public List<string> Cursanti { get; set; }

        internal Cursuri(NivelLimba nivel)
        {
            Nivel = nivel;
        }

        public Cursuri CreareCurs(string LimbaS,string nume)
        {
            Contract.Requires(nume.Length >= 2);
            var curs = new Cursuri(new NivelLimba(LimbaS, nume));
            return curs;
        }
    }
}
