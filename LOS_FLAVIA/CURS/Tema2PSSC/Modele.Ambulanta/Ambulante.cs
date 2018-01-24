using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.Ambulanta
{
    public class Ambulante
    {
        public List<Ambulanta> _ambulante;


        public Ambulante()
        {
            _ambulante = new List<Ambulanta>();
        }

        public Ambulante(List<Ambulanta> ambulante)
        {
            Contract.Requires(ambulante != null, "lista de ambulante");
            _ambulante = ambulante;
        }

        internal void AdaugaAmbulanta(Ambulanta ambulanta)
        {
            Contract.Requires(ambulanta != null, "ambulanta");
            _ambulante.Add(ambulanta);
        }

        #region override object
        public override string ToString()
        {
            return _ambulante.Aggregate(new StringBuilder(), (builder, ambulanta) => {
                if (builder.Length > 0) builder.Append("");
                builder.Append(ambulanta);
                return builder;
            }).ToString();

        }

        public override bool Equals(object obj)
        {
            var ambulante = (Ambulante)obj;

            if (ambulante != null && ambulante._ambulante.Count == _ambulante.Count)
            {
                return _ambulante.Select((amb, idx) => new { Ambulanta1 = amb, Ambulanta2 = ambulante._ambulante[idx] })
                    .Aggregate(true, (equal, pair) => equal && pair.Ambulanta1.Equals(pair.Ambulanta2));

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
