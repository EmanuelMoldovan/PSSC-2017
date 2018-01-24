using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;

namespace Modele.Generic
{
    public class Punctaj
    {
        private int _coef1;
        private int _coef2;

        public decimal Calcul { get { return (decimal)_coef1 / (decimal)_coef2; } }

        public Punctaj( int coef1, int coef2 )
        {
            Contract.Requires<ArgumentException>(coef1 > 0, "primul termen");
            Contract.Requires<ArgumentException>(coef2 > 0, "al doilea termen");
           
            _coef1 = coef1;
            _coef2 = coef2;
        }

        #region override object
        public override bool Equals(object obj)
        {
            var punctaj = (Punctaj)obj;
            return punctaj._coef1 == _coef1 && punctaj._coef2 == _coef2;
        }
        public override int GetHashCode()
        {
            return Calcul.GetHashCode();
        }

        public override string ToString()
        {
            return string.Format("{0}/{1}", _coef1, _coef2);
        }
        #endregion

    }
}
