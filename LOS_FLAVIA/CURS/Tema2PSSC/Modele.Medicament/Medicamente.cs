using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.Medicament
{
    public class Medicamente
    {
        private List<Medicament> _medicamente;
      

        public Medicamente()
        {
            _medicamente = new List<Medicament>();
        }

        public Medicamente(List<Medicament> medicamente)
        {
            Contract.Requires(medicamente != null, "lista de medicamente");
            _medicamente = medicamente;
        }

        internal void AdaugaMedicament(Medicament medicament)
        {
            Contract.Requires(medicament != null, "medicament");
            _medicamente.Add(medicament);
        }

        #region override object
        public override string ToString()
        {
            return _medicamente.Aggregate(new StringBuilder(), (builder, medicament) => {
                if (builder.Length > 0) builder.Append("");
                builder.Append(medicament);
                return builder;
            }).ToString();

        }

        public override bool Equals(object obj)
        {
            var medicamente = (Medicamente)obj;

            if (medicamente != null && medicamente._medicamente.Count == _medicamente.Count)
            {
                return _medicamente.Select((med, idx) => new { Med1 = med, Med2 = medicamente._medicamente[idx] })
                    .Aggregate(true, (equal, pair) => equal && pair.Med1.Equals(pair.Med2));

            }
            return false;
        }
        #endregion
    }
}
