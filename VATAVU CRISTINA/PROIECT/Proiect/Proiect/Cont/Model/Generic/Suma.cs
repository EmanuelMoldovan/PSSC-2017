using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.Generic
{
    public class Suma
    {
        private double suma;
        public double getSuma{ get { return suma; } set { suma = value; } }

        public Suma(double suma)
        {
            this.suma = suma;
        }

    }
}
