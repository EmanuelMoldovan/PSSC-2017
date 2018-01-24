using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;

namespace Modele.Depozit
{
    public class Tricou
    {
        public string model;
        public char marime;
        public int numar;

        public string Model { get; internal set; }
        public char Marime { get; internal set; }
        public int Numar { get; internal set; }

        internal Tricou(string model, char marime, int numar)
        {
            Contract.Requires(model != null, "model");
            Model = model;
            Marime = marime;
            Numar = numar;

        }

    }
}
