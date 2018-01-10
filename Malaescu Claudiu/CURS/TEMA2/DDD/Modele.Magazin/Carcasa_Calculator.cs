using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Diagnostics.Contracts;

namespace Modele.Magazin
{
    public class Carcasa_Calculator
    {
        public string model;
        public string culoare;

        public string Model { get; internal set; }
        public string Culoare { get; internal set; }

        internal Carcasa_Calculator(string model, string culoare)
        {
            Contract.Requires(model != null, "model");
            Model = model;
            Culoare = culoare;
        }
    }
}
