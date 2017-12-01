using Modele.Generic;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.Librarie
{
    public class Carte
    {
        public ISSN nr { get; internal set; }
        public Text titlu { get; internal set; }
        public Stare stare { get;  set; }
        public Gen_tip gent { get; internal set; }
        public Gen_continut genc { get; internal set; }

        public Carte(ISSN nr, Text titlu, Gen_tip gent, Gen_continut genc)
        {
            Contract.Requires(nr != null, "numar necesar nenul");
            Contract.Requires(titlu != null, "titlul necesar nenul");
            this.nr = nr;
            this.titlu = titlu;
            stare = Stare.disponibila;
            this.gent = gent;
            this.genc = genc;
        }
        public override string ToString()
        {
            return nr.ToString() + " " + titlu.ToString();
        }
        
    }
}
