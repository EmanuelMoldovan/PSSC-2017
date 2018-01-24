using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Pacienti
{
    public class DataNastere
    {
        public int zi;
        public int luna;
        public int an;

        public DataNastere(int z,int l,int a)
        {
            zi = z;
            luna = l;
            an = a;
        }

        public string toString()
        {
            return zi + "/" + luna + "/" + an;
        }
    }
}
