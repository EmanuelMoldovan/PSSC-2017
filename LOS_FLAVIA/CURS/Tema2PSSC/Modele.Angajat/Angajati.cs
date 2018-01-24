using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.Angajat
{
    public class Angajati
    {
        private List<Angajat> _angajati;


        public Angajati()
        {
            _angajati = new List<Angajat>();
        }

        public Angajati(List<Angajat> angajati)
        {
            Contract.Requires(angajati != null, "lista de angajati");
            _angajati = angajati;
        }

        internal void AdaugaAngajat(Angajat angajat)
        {
            Contract.Requires(angajat != null, "angajat");
            _angajati.Add(angajat);
        }

        #region override object
        public override string ToString()
        {
            return _angajati.Aggregate(new StringBuilder(), (builder, angajat) => {
                if (builder.Length > 0) builder.Append(", ");
                builder.Append(angajat);
                return builder;
            }).ToString();

        }

        public override bool Equals(object obj)
        {
            var angajati = (Angajati)obj;

            if (angajati != null && angajati._angajati.Count == _angajati.Count)
            {
                return _angajati.Select((ang, idx) => new { Ang1 = ang, Ang2 = angajati._angajati[idx] })
                    .Aggregate(true, (equal, pair) => equal && pair.Ang1.Equals(pair.Ang2));

            }
            return false;
        }
        #endregion
    }
}
