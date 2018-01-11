using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.Pachete
{
    public class Pungi_FructeUscate
    {
        private List<Punga_FructeUscate> pungiFructeUscate_List;
        internal Pungi_FructeUscate()
        {
            pungiFructeUscate_List = new List<Punga_FructeUscate>();
        }

        internal Pungi_FructeUscate(List<Punga_FructeUscate> pungaFructeUscate)
        {
            Contract.Requires(pungaFructeUscate != null, "Lista cu pungi de nuci");
            this.pungiFructeUscate_List = pungaFructeUscate;
        }

        internal void AdaugaFructeUscate(Punga_FructeUscate pungaFructeUscate)
        {
            Contract.Requires(pungaFructeUscate != null, "nuca");
            pungiFructeUscate_List.Add(pungaFructeUscate);
        }
    }
}
