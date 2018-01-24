using Model.Generic;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Model.MagazinElectronice
{
    public class Laptop
    {
        public Procesor proc { get; internal set; }
        public PlacaVideo placaVideo { get; internal set; }
        public OS sistemOperare { get; internal set; }
        public int hardDisk { get; internal set; }
        public string firma { get; internal set; }
        public double dimensiune { get; internal set; }
        public double pret { get; internal set; }

        public Laptop(Procesor proc, PlacaVideo placaVideo, OS sisOp, int hdd, string firma, double dimEcran, double pret)
        {
            Contract.Requires(proc != null, "Procesorul trebuie sa existe");
            Contract.Requires(placaVideo != null, "Placa video trebuie sa existe");
            Contract.Requires(Double.IsNaN(pret)!=false, "Placa video trebuie sa existe");

            this.proc = proc;
            this.placaVideo = placaVideo;
            this.sistemOperare = sisOp;
            this.hardDisk = hdd;
            this.firma = firma;
            this.dimensiune = dimensiune;
            this.pret = pret;
        }

        public Laptop()
        {
        }

        public override string ToString()
        {
            return "Laptop " + firma + " costa " + pret.ToString();
        }


    }
}
