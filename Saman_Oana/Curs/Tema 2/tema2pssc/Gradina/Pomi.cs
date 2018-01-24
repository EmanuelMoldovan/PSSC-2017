using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Gradina
{
    public class Pomi
    {
        private List<Pom> pomi;
        public ReadOnlyCollection<Pom> Valori { get { return pomi.AsReadOnly(); } }

        internal Pomi()
        {
            pomi = new List<Pom>();
        }

        internal Pomi(List<Pom> pomi)
        {
            this.pomi = pomi;
        }

        internal void AdaugaPom(Pom pom)
        {
            pomi.Add(pom);
        }

        public override string ToString()
        {
            return pomi.Aggregate(new StringBuilder(), (builder, pom) => {
                if (builder.Length > 0) builder.Append(", ");
                builder.Append(pom);
                return builder;
            }).ToString();

        }
    }
}
