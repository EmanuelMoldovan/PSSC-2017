using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.Scoala
{
    public class Plata
    {

        public bool StudentulAPlatit(int valoare)
        {
            if (valoare != null)
            {
                return true;
            }
            else
                return false;
        }
    }
}
