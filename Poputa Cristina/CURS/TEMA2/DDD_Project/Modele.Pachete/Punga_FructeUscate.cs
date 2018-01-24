using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.Pachete
{
    public class Punga_FructeUscate
    {
        private tip_FructeUscate tipFructe;
        public int cantitate;
        public int greutate = 50;
        public int pret = 40;


        public tip_FructeUscate TipFructe { get; internal set; }
        public int Cantitate { get; internal set; }
        public int Greutate { get; internal set; }
        public int Pret { get; internal set; }
      

        internal Punga_FructeUscate( tip_FructeUscate tipFructe,int cantitate, int greutate, int pret)
        {
            TipFructe = tipFructe;
            Cantitate = cantitate;
            Greutate = greutate;
            Pret = pret;
        }

    }
}
