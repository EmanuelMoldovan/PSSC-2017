using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;

namespace Modele.Generic
{
    public class Material
    {
        private decimal _pret;
        public decimal Pret { get { return _pret; } }

        public Material(decimal pret)
        {
            Contract.Requires<ArgumentException>(pret > 0, "pret");

            _pret = pret;
        }

        #region override object
        public override bool Equals(object obj)
        {
            var material = (Material)obj;
            return Pret == material.Pret;
        }

        public override int GetHashCode()
        {
            return Pret.GetHashCode();
        }

        public override string ToString()
        {
            return string.Format("{0}", Pret);
        }
        #endregion
    }
}
