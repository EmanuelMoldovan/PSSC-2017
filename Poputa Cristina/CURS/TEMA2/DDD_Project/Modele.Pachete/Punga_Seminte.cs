using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.Pachete
{
    public class Punga_Seminte
    {
        public tip_Seminte tipSeminte;
        public int cantitate;
        public int greutate = 50; 
        public int pret = 10;


        public tip_Seminte TipSeminte{ get; internal set; }
        public int Cantitate { get; internal set; }
        public int Greutate { get; internal set; }
        public int Pret { get; internal set; }

        internal Punga_Seminte( tip_Seminte tipSeminte, int cantitate,int greutate, int pret)
        {
            TipSeminte = tipSeminte;
            Cantitate = cantitate;
            Greutate = greutate;
            Pret = pret;
        }
    }
}
