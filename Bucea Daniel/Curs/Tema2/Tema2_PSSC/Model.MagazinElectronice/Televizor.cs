using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.MagazinElectronice
{
    public class Televizor
    {
        public double dimEcran;
        public TipTelevizor tipTelevizor;
        public double pret;
        public string firma;
        public string rezolutie;
        public bool smartTV;

        public double DimEcran { get; internal set; }
        public TipTelevizor TipTelevizor { get; internal set; }
        public double Pret { get; internal set; }
        public string Firma { get; internal set; }
        public string Rezolutie { get; internal set; }
        public bool SmartTV { get; internal set; }


        internal Televizor(double dimEcran,TipTelevizor tipTel,double pret, string firma, string rez, bool smartTV)
        {
            DimEcran = dimEcran;
            TipTelevizor = tipTel;
            Pret = pret;
            Firma = firma;
            Rezolutie = rez;
            SmartTV = smartTV;
        }
    }
}
