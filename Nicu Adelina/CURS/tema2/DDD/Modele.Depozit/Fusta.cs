using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Diagnostics.Contracts;

namespace Modele.Depozit
{
    public class Fusta
    {
        public TipFusta tip;
        public int numar;

        public TipFusta Tip { get; internal set; }
        public int Numar { get; internal set; }
        internal Fusta(TipFusta tip, int numar)
        {
            Contract.Requires(tip != null, "tip");
            Tip = tip;
            Numar= numar;
        }
    }
}
