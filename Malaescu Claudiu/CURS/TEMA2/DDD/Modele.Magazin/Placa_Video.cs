using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;

namespace Modele.Magazin
{
    public class Placa_Video
    {
        public string model;
        public int dimensiune_placa_biti;
        public int capacitate;

        public string Model { get; internal set; }
        public int Dimensiune_Placa_Biti { get; internal set; }
        public int Capacitate { get; internal set; }

        internal Placa_Video(string model, int dimensiune_biti, int capacitate)
        {
            Contract.Requires(model != null, "model");
            Model = model;
            Dimensiune_Placa_Biti = dimensiune_biti;
            Capacitate = capacitate;

        }

    }
}
