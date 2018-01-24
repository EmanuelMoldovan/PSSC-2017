using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSSC
{
    public class CalculateBill
    {
        private int persoane;
        private int NrZile;

        public CalculateBill(int pers, int v)
        {
           persoane = pers;
            NrZile = v;
        }
        public int Total()
        {
            return persoane * NrZile * 100;
        }
    }
}
