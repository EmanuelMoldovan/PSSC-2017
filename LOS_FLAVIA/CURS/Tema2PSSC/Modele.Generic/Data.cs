using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.Generic
{
    public class Data
    {
        int Zi { get; set; }
        int Luna { get; set; }
        int An { get; set; }

        public Data(int zi, int luna, int an)
        {
            Zi = zi;
            Luna = luna;
            An = an;
        }
        public override string ToString()
        {
            return Zi.ToString() + "/" + Luna + "/" + An;
               
        }
    }
}
