using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.Pachete
{
    public class Pungi_Nuci
    {

        private List<Punga_Nuci> pungiNuci_List;
        internal Pungi_Nuci()
        {
            pungiNuci_List = new List<Punga_Nuci>();
        }

        internal Pungi_Nuci(List<Punga_Nuci> pungaNuci)
        {
            Contract.Requires(pungaNuci != null, "Lista cu pungi de nuci");
            this.pungiNuci_List = pungaNuci;
        }

        internal void AdaugaNuci(Punga_Nuci punga_cu_nuci)
        {
            Contract.Requires(punga_cu_nuci != null, "nuca");
            pungiNuci_List.Add(punga_cu_nuci);
        }
    }
}
