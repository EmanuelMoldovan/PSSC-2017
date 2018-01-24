using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Generic
{
    public class Procesor
    {
        private int nrCoruri;
        private string firma;
        private double putere;

        public int NrCoruri { get { return nrCoruri; } set { nrCoruri = value; } }
        public string Firma { get { return firma; } set { firma = value; } }
        public double Putere { get { return putere; } set { putere = value; } }

        public Procesor(int nrCoruri, string firma, double putere)
        {
            this.nrCoruri = nrCoruri;
            this.firma = firma;
            this.putere = putere;
        }

    }
}
