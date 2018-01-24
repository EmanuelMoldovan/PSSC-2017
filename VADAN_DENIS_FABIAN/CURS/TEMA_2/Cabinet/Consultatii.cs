using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;

namespace Modele.Consultatie
{
    public class Consultatii
    {
        private List<Consultatie> _consultatii;
        public ReadOnlyCollection<Consultatie> Valori { get { return _consultatii.AsReadOnly(); } }

        internal Consultatii()
        {
            _consultatii = new List<Consultatie>();
        }

        internal Consultatii(List<Consultatie> consultatii)
        {
            Contract.Requires(consultatii != null, "lista de consultatii");
            _consultatii = consultatii;
        }

        internal void AdaugaConsultatie(Consultatie consultatie)
        {
            Contract.Requires(consultatie != null, "curs");
            _consultatii.Add(consultatie);
        }

        #region override object
        public override string ToString()
        {
            return _consultatii.Aggregate(new StringBuilder(), (builder, consultatie) => {
                if (builder.Length > 0) builder.Append(", ");
                builder.Append(consultatie);
                return builder;
            }).ToString();

        }

        public override bool Equals(object obj)
        {
            var consultatii = (Consultatii)obj;

            if (consultatii != null && consultatii._consultatii.Count == _consultatii.Count)
            {
                return _consultatii.Select((consultatie, idx) => new { Consultatie1 = consultatie, Consultatie2 = consultatii._consultatii[idx] })
                    .Aggregate(true, (equal, pair) => equal && pair.Consultatie1.Equals(pair.Consultatie2));

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
