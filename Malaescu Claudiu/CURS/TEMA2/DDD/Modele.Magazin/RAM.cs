using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Diagnostics.Contracts;

namespace Modele.Magazin
{
    public class RAM
    {
        public TipRami tip;
        public int dimensiune_rami;

        public TipRami Tip { get; internal set; }
        public int Dimensiune { get; internal set; }
        internal RAM(TipRami tip, int dimensiune)
        {
            Contract.Requires(true, "tip");
            Tip = tip;
            Dimensiune= dimensiune;
        }
    }
}
