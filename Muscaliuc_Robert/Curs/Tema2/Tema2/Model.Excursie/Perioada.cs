using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.Excursie
{
    public class Perioada
    {
        private DateTime startPerioada;
        private DateTime sfarsitPerioada;

        internal Perioada(DateTime start, DateTime sfarsit)
        {
            startPerioada = start;
            sfarsitPerioada = sfarsit;
        }
    }
}
