using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modele.Generic;

namespace Modele.Activitate
{
    public class ActivitateFactory
    {
        public static readonly ActivitateFactory Instance = new ActivitateFactory();

        private ActivitateFactory()
        {

        }

        public Activitate CreeazaActivitate(TextNume nume, int durata, Puncte punctajCastigator)
        {
            Contract.Requires<ArgumentNullException>(nume != null, "text");
            var activitate = new Activitate(nume, durata, punctajCastigator);
            return activitate;
        }
    }
}
