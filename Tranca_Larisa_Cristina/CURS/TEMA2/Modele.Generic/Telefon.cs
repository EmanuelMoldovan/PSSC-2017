using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;

namespace Modele.Generic
{
    public class Telefon
    {
        private decimal _valoare;
        public decimal Valoare { get { return _valoare; } }

        public Telefon(decimal valoare)
        {
            Contract.Requires<ArgumentException>(valoare > 0, "valoare");
            Contract.Requires<ArgumentException>(valoare <= 10, "valoare");

            _valoare = valoare;
        }

        #region override object
        public override bool Equals(object obj)
        {
            var numarTelefon = (Telefon)obj;
            return Valoare == numarTelefon.Valoare;
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
