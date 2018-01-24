using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.Pachete
{
   public class Punga_Nuci
    {

        public tip_Nuci tipNuca;
        public int cantitate;
        public int greutate = 100;
        public int pret = 130;


        
        public tip_Nuci TipNuca { get; internal set; }
        public int Cantitate { get; internal set; }
        public int Greutate { get; internal set; }
        public int Pret { get; internal set; }

        internal Punga_Nuci(tip_Nuci tipNuca, int cantitate, int greutate, int pret)
        {
            TipNuca = tipNuca;
            Cantitate = cantitate;
            Greutate = greutate;
            Pret = pret;
        }
    }
}
