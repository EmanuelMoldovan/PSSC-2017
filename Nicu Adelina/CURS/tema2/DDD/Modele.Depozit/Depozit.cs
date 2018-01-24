using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;


namespace Modele.Depozit
{
    public class Depozit
    {
        public string nume;
        public int nrRaft;
        public int capacitateDepozit = 15;
        private int nrRaft1;

        public Tricouri Tricouri { get; internal set; }
        public Esarfe Esarfe { get; internal set; }
        public Fuste Fuste { get; internal set; }

        internal Depozit(string nume,int nrRaft)
        {
            this.nume = nume;
            this.nrRaft = nrRaft;
            Tricouri = new Tricouri();
            Esarfe = new Esarfe();
            Fuste = new Fuste();
        }

        public Depozit(int nrRaft1)
        {
            // TODO: Complete member initialization
            this.nrRaft1 = nrRaft1;
        }

        public void AdaugaTricou(string model, char marime, int numar)
        {
            Contract.Requires(model != null, "model tricou");
            if (capacitateDepozit > 0)
            {
                var tricou = new Tricou(model, marime, numar);
                Tricouri.AdaugaTricou(tricou);
                capacitateDepozit--;
            }
            else
            {
                Console.WriteLine("Nu mai sunt locuri in Depozit");
            }
        }

        public void AgaugaEsarfa(string model, string culoare, int numar)
        {
            Contract.Requires(model != null, "model esarfa");
            if (capacitateDepozit > 0)
            {
                var esarfa = new Esarfa(model, culoare, numar);
                Esarfe.AdaugaEsarfa(esarfa);
                capacitateDepozit--;
            }
            else
            {
                Console.WriteLine("Nu mai sunt locuri in depozit");
            }
        }

        public void AdaugaFusta(TipFusta tip, int numar)
        {
            Contract.Requires(tip != null, "tip fusta");
            if (capacitateDepozit > 0)
            {
                var fusta = new Fusta(tip, numar);
                Fuste.AdaugaFusta(fusta);
                capacitateDepozit--;
            }
            else
            {
                Console.WriteLine("Nu mai sunt locuri in depozit");
            }
        }

       

        #region override object
        public override string ToString()
        {
            return nrRaft.ToString();
        }

        public override bool Equals(object obj)
        {
            var depozit = (Depozit)obj;

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
