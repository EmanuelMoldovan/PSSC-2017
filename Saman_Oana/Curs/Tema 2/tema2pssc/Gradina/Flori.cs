using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Gradina
{
    public class Flori
    {
        private List<Floare> flori;
        public ReadOnlyCollection<Floare> Valori { get { return flori.AsReadOnly(); } }

        internal Flori()
        {
            flori = new List<Floare>();
        }

        internal Flori(List<Floare> flori)
        {
            this.flori = flori;
        }

        internal void AdaugaFloare(Floare floare)
        {
            flori.Add(floare);
        }

        public override string ToString()
        {
            return flori.Aggregate(new StringBuilder(), (builder, floare) => {
                if (builder.Length > 0) builder.Append(", ");
                builder.Append(floare);
                return builder;
            }).ToString();

        }
    }
}
