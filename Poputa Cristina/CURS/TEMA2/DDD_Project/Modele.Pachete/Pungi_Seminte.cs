using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.Pachete
{
    public class Pungi_Seminte
    {

        private List<Punga_Seminte> pungiSeminte_List;
        internal Pungi_Seminte()
        {
            pungiSeminte_List = new List<Punga_Seminte>();
        }

        internal Pungi_Seminte(List<Punga_Seminte> pungiSeminte_List)
        {
            Contract.Requires(pungiSeminte_List != null, "Lista cu pungi de seminte");
            this.pungiSeminte_List = pungiSeminte_List;
        }

        internal void AdaugaSeminte(Punga_Seminte pungaSeminte)
        {
            Contract.Requires(pungaSeminte != null, "seminte");
            pungiSeminte_List.Add(pungaSeminte);
        }
    }
}
