using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;

namespace Modele.Generic
{
    public class Pret
    {
        private decimal _valoare;
        public decimal Valoare { get { return _valoare; } }

        public Pret(decimal valoare)
        {
            Contract.Requires<ArgumentException>(valoare > 0, "valoare");
            Contract.Requires<ArgumentException>(valoare <= 200, "valoare");
            _valoare = valoare;
        }
        #region override object
        public override bool Equals(object obj)
        {
            var pret = (Pret)obj;
            return Valoare == pret.Valoare;
        }

        public override int GetHashCode()
        {
            return Valoare.GetHashCode();
        }
        public override string ToString()
        {
            return string.Format("{0}", Valoare);
        }
        #endregion
    }

}
