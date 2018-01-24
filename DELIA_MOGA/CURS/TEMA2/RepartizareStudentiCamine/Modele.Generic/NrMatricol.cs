using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modele.Generic.Exceptii;

namespace Modele.Generic
{
    public class NrMatricol
    {
        private string _numar;
        public string Numar { get { return _numar; } }

        public NrMatricol(string numar)
        {
            if (numar.Length != 4)
            {
                throw new ArgumentException();
            }

            if (string.IsNullOrEmpty(numar))
            {
                throw new ArgumentCannotBeEmptyStringException(numar);
            }

            _numar = numar;
        }

        #region override object
        public override string ToString()
        {
            return Numar;
        }

        public override bool Equals(object obj)
        {
            var nume = (NrMatricol)obj;
            return Numar.Equals(nume.Numar);
        }

        public override int GetHashCode()
        {
            return Numar.GetHashCode();
        }
        #endregion
    }
}
