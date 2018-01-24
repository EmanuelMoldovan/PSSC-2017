using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedData
{
    public class Data
    {
        public int zi;
        public int luna;
        public int an;

        public Data(int z, int l, int a)
        {
            zi = z;
            luna = l;
            an = a;
        }

        public string toString()
        {
            return zi + "/" + luna + "/" + an + "/";
        }
    }
}
