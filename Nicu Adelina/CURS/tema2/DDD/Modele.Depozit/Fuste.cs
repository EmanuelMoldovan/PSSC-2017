using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Diagnostics.Contracts;

namespace Modele.Depozit
{
    public class Fuste
    {
        private List<Fusta> fuste;
        internal Fuste()
        {
            fuste = new List<Fusta>();
        }

        internal Fuste(List<Fusta> fuste)
        {
            Contract.Requires(fuste != null, "lista de fuste");
            this.fuste = fuste;
        }

        internal void AdaugaFusta(Fusta fusta)
        {
            Contract.Requires(fusta != null, "fusta");
            fuste.Add(fusta);
        }
    }
}
