using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;
using System.Diagnostics;

namespace Modele.Magazin
{
    public class Magazin
    {
        public string nume;
        public int nrRaft;
        public int capacitate_magazin = 22;
        private int nrRaftinit;

        public Placi_Video placi_video { get; internal set; }
        public Carcase_Calculatoare carcase_calculatoare { get; internal set; }
        public RAMI rami { get; internal set; }

        internal Magazin(string nume,int nrRaft)
        {
            this.nume = nume;
            this.nrRaft = nrRaft;
            placi_video = new Placi_Video();
            carcase_calculatoare = new Carcase_Calculatoare();
            rami = new RAMI();
        }

        public Magazin(int nrRaftinit)
        {
            // TODO: Complete member initialization
            this.nrRaftinit = nrRaftinit;
        }

        public void AdaugaPlacaVideo(string model, int dimensiune_biti, int capacitate)
        {
            Contract.Requires(model != null, "model placa video");
            if (capacitate_magazin > 0)
            {
                var placa = new Placa_Video(model, dimensiune_biti, capacitate);
                placi_video.AdaugaPlaca(placa);
                capacitate_magazin--;
            }
            else
            {
               
                Debug.WriteLine("Nu mai sunt locuri in Depozit");
            }
        }

        public void AdaugaCarcasaCalculator(string model, string culoare)
        {
            Contract.Requires(model != null, "model carcasa");
            if (capacitate_magazin > 0)
            {
                var carcasa = new Carcasa_Calculator(model, culoare);
                carcase_calculatoare.AdaugaCarcase(carcasa);
                capacitate_magazin--;
            }
            else
            {
                Debug.WriteLine("Nu mai sunt locuri in depozit");
            }
        }

        public void AdaugaFusta(TipRami tip, int dimensiune)
        {
            Contract.Requires(true, "tip RAM");
            if (capacitate_magazin > 0)
            {
                var ram = new RAM(tip, dimensiune);
                rami.AdaugaRAM(ram);
                capacitate_magazin--;
            }
            else
            {
                Debug.WriteLine("Nu mai sunt locuri in depozit");
            }
        }

       

        #region override object
        public override string ToString()
        {
            return nrRaft.ToString();
        }

        public override bool Equals(object obj)
        {
            var depozit = (Magazin)obj;

            if (depozit != null)
            {
                return nrRaft.Equals(depozit.nrRaft);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return nrRaft.GetHashCode();
        }
       #endregion
    }
}
