using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Diagnostics.Contracts;

namespace Modele.Magazin
{
    public class RAMI
    {
        private List<RAM> rami;
        internal RAMI()
        {
            rami = new List<RAM>();
        }

        internal RAMI(List<RAM> rami)
        {
            Contract.Requires(rami != null, "lista de rami");
            this.rami = rami;
        }

        internal void AdaugaRAM(RAM ram)
        {
            Contract.Requires(ram != null, "ram");
            rami.Add(ram);
        }
    }
}
