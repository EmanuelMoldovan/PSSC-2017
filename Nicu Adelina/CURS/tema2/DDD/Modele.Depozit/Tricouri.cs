using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.Diagnostics.Contracts;
using System.Threading.Tasks;

namespace Modele.Depozit
{
    public class Tricouri
    {
        private List<Tricou> tricouri;

        internal Tricouri()
        {
            tricouri = new List<Tricou>();
          
        }
        internal Tricouri(List<Tricou> tricouri)
        {
            Contract.Requires(tricouri != null, "lista de tricouri");
            this.tricouri = tricouri;
        }
           internal void AdaugaTricou(Tricou tricou)
         {
             Contract.Requires(tricou != null, "tricou");
             tricouri.Add(tricou);
         }
    }
}
