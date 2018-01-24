using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modele.Generic.Exceptions;
using System.Collections.ObjectModel;
using System.Diagnostics.Contracts;

namespace Modele.Generic
{
    public class Preturi
    {
        private List<Pret> _preturi;
        public ReadOnlyCollection<Pret> Valori { get { return _preturi.AsReadOnly(); } }

        public Preturi()
        {
            _preturi = new List<Pret>();
        }

        internal Preturi(List<Pret> preturi)
        {
            Contract.Requires(preturi != null, "lista de preturi");
            _preturi = preturi;
        }

        public Pret Media
        {
            get
            {
                if (_preturi.Count < 2) throw new ArgumentNullException();
                return new Pret(_preturi.Select(p => p.Valoare).Average());
            }
        }
        public void AdaugaPret(Pret pret)
        {
            Contract.Requires(pret != null, "pret");
            _preturi.Add(pret);
        }

        #region override object

        public override string ToString()
        {
            return _preturi.Aggregate(new StringBuilder(), (builder, pret) =>
            {
                if (builder.Length > 0) builder.Append(", ");
                builder.Append(pret);
                return builder;
            }).ToString();
        }

        public override bool Equals(object obj)
        {
            var preturi = (Preturi)obj;
            if(preturi != null && preturi._preturi.Count == _preturi.Count)
            {
                return _preturi.Select((pret, idx) => new { Pret1 = pret, Pret2 = preturi._preturi[idx] }).Aggregate
                    (true, (equal, pair) => equal && pair.Pret1.Equals(pair.Pret2));
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
