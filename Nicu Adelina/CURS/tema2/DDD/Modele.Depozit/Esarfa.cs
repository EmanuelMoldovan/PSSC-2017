using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Diagnostics.Contracts;

namespace Modele.Depozit
{
    public class Esarfa
    {
        public string model;
        public string culoare;
        public int numar;

        public string Model { get; internal set; }
        public string Culoare { get; internal set; }
        public int Numar { get; internal set; }

        internal Esarfa(string model, string culoare, int numar)
        {
            Contract.Requires(model != null, "model");
            Model = model;
            Culoare = culoare;
            Numar = numar;
        }
    }
}
