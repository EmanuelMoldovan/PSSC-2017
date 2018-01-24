using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Generic
{
    public class PlacaVideo
    {
        private string firma;
        private double putere;
        private string nume;

        public string Firma { get { return firma; } set { firma = value; } }
        public double Putere { get { return putere; } set { putere = value; } }
        public string Nume { get { return nume; } set { nume = value; } }

        public PlacaVideo(string firma, double putere, string nume)
        {
            this.firma = firma;
            this.putere = putere;
            this.nume = nume;
        }
    }
}
