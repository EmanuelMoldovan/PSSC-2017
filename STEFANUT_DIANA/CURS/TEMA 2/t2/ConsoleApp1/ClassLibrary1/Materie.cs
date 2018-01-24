using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics.Contracts;
using Modele.Generic.Exceptions;

namespace Modele.Generic
{
    public class Materie
    {
        private string _materie;
        public string Materiee { get { return _materie; } }

        public Materie(string materie)
        {
            Contract.Requires<ArgumentNullException>(materie != null, "text");
            Contract.Requires<ArgumentCannotBeEmptyStringException>(!string.IsNullOrEmpty(materie), "text");

            _materie = materie;
        }


        #region override object
        public override string ToString()
        {
            return Materiee;
        }

        public override bool Equals(object obj)
        {
            var nume = (Materie)obj;
            return Materiee.Equals(nume.Materiee);
        }

        public override int GetHashCode()
        {
            return Materiee.GetHashCode();
        }
        #endregion

    }
}
