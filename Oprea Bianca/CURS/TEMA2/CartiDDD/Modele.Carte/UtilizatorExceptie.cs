using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.Librarie
{
    public class UtilizatorExceptie : Exception
    {
        private Utilizator u;
        public UtilizatorExceptie(Utilizator u)
        {
            this.u = u;
            ToString();
        }

        public override string ToString()
        {
            return "Utilizator existent: " + u;
        }
    }
}
