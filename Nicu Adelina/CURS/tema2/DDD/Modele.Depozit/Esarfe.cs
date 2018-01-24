using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Diagnostics.Contracts;

namespace Modele.Depozit
{
    public class Esarfe
    {
        private List<Esarfa> esarfe;
        internal Esarfe()
         {
             esarfe = new List<Esarfa>();
         }
 
         internal Esarfe(List<Esarfa> esarfe)
         {
             Contract.Requires(esarfe != null, "lista de esarfe");
             this.esarfe = esarfe;
         }
 
         internal void AdaugaEsarfa(Esarfa esarfa)
         {
             Contract.Requires(esarfa != null, "esarfa");
             esarfe.Add(esarfa);
         }
    }
    
}
