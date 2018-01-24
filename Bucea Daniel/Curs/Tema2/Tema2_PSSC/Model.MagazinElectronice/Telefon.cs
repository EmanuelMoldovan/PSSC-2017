using Model.Generic;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.MagazinElectronice
{
    public class Telefon
    {
        public Procesor proc { get; internal set; }
        public int memorie { get; internal set; }
        public string firma { get; internal set; }
        public double dimensiune { get; internal set; }
        public double pret { get; internal set; }
        public double rezCamera { get; internal set; }


        internal Telefon(Procesor proc, int memorie, string firma, double dimEcran, double pret,double camera)
        { 

            this.proc = proc;
            this.memorie = memorie;
            this.firma = firma;
            this.dimensiune = dimEcran;
            this.pret = pret;
            this.rezCamera = camera;
            this.dimensiune = dimensiune;
            this.pret = pret;
        }

        public override string ToString()
        {
            return "Telefon " + firma + " costa " + pret.ToString();
        }
    }
}
