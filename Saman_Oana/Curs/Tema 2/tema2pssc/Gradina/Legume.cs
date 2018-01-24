using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Gradina
{
    public class Legume
    {
        private List<Leguma> legume;
        public ReadOnlyCollection<Leguma> Valori { get { return legume.AsReadOnly(); } }

        internal Legume()
        {
            legume = new List<Leguma>();
        }

        internal Legume(List<Leguma> legume)
        {
            this.legume = legume;
        }

        internal void AdaugaLeguma(Leguma leguma)
        {
            legume.Add(leguma);
        }

        public override string ToString()
        {
            return legume.Aggregate(new StringBuilder(), (builder,leguma) => {
                if (builder.Length > 0) builder.Append(", ");
                builder.Append(leguma);
                return builder;
            }).ToString();

        }
    }
}
