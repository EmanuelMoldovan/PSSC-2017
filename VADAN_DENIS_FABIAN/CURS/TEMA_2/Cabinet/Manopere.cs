using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;

namespace Modele.Cabinet
{
    public class Manopere
    {
        private List<Manopera> _manopere;
        public ReadOnlyCollection<Manopere> Valori { get { return _manopere.AsReadOnly(); } }

        internal Manopere()
        {
            _manopere = new List<Manopera>();
        }

        internal Manopere(List<Manopera> manopere)
        {
            Contract.Requires(manopere != null, "lista de laboratoare");
            _manopere = manopere;
        }

        internal void AdaugaLaborator(Manopera manopera)
        {
            Contract.Requires(manopera != null, "laborator");
            _manopere.Add(manopera);
        }

        #region override object
        public override string ToString()
        {
            return _manopere.Aggregate(new StringBuilder(), (builder, laborator) => {
                if (builder.Length > 0) builder.Append(", ");
                builder.Append(laborator);
                return builder;
            }).ToString();

        }

        public override bool Equals(object obj)
        {
            var manopere = (Manopere)obj;

            if (manopere != null && manopere._manopere.Count == _manopere.Count)
            {
                return _manopere.Select((manopera, idx) => new { Manopera1 = manopera, Manopera2 = manopere._manopere[idx] })
                    .Aggregate(true, (equal, pair) => equal && pair.Manopera1.Equals(pair.Manopera2));

            }
            return false;
        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
        #endregion
    }
}
