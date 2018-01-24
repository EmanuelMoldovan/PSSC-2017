using Modele.Organizator;
using System;
using System.Diagnostics.Contracts;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Model.TabaraSportiva
{
    public class TabaraSportiva
    {
        private List<Organizator> organizatori;

        public TabaraSportiva()
        {
            organizatori = new List<Organizator>();
        }
        public TabaraSportiva(List<Organizator> o)
        {
            Contract.Requires(o != null, "lista oranizatori->null");
            this.organizatori = o;
        }
        public TabaraSportiva(Organizator o)
        {
            Contract.Requires(o != null, "organizator->null");
            organizatori.Add(o);
        }




    }
}
