using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Generic
{
    public class Reducere
    {
        public int coeficient {get; internal set; }
        public Reducere(int coeficint)
        {
            this.coeficient = coeficient;
        }

        public double pretCuReducere(double pret)
        {
            return pret * (100 - coeficient) / 100;
        }
    }
}
