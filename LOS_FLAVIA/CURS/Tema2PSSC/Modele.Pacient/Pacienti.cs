using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.Pacient
{
    public class Pacienti
    {
        public List<Pacient> _pacienti;
       

        public Pacienti()
        {
            _pacienti = new List<Pacient>();
        }

        public Pacienti(List<Pacient> pacienti)
        {
            Contract.Requires(pacienti != null, "lista de pacienti");
            _pacienti = pacienti;
        }

        internal void AdaugaPacient(Pacient pacient)
        {
            Contract.Requires(pacient != null, "pacient");
            _pacienti.Add(pacient);
        }

        #region override object
        public override string ToString()
        {
            return _pacienti.Aggregate(new StringBuilder(), (builder, pacient) => {
                if (builder.Length > 0) builder.Append(", ");
                builder.Append(pacient);
                return builder;
            }).ToString();

        }

        public override bool Equals(object obj)
        {
            var pacienti = (Pacienti)obj;

            if (pacienti != null && pacienti._pacienti.Count == _pacienti.Count)
            {
                return _pacienti.Select((pac, idx) => new { Pac1 = pac, Pac2 = pacienti._pacienti[idx] })
                    .Aggregate(true, (equal, pair) => equal && pair.Pac1.Equals(pair.Pac2));

            }
            return false;
        }
        #endregion
    }
}
