using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modele.Generic.Exceptions;
using System.Diagnostics.Contracts;

namespace Modele.Generic
{
    public class IdParticipare
    {
        private string _numar;

        public string Numar { get { return _numar; } }

        public IdParticipare (string numar)
        {
            Contract.Requires<ArgumentNullException>(numar != null, "text");
            Contract.Requires<ArgumentCannotBeEmptyStringException>(!string.IsNullOrEmpty(numar), "text");
            Contract.Requires<ArgumentException>(numar.Length == 5, "Id-ul de participare are exact 5 caractere. ");
            _numar = numar;
        }

        #region override object
        public override string ToString()
        {
            return Numar;
        }

        public override bool Equals(object obj)
        {
            var nume = (IdParticipare)obj;
            return Numar.Equals(nume.Numar);
        }

        public override int GetHashCode()
        {
            return Numar.GetHashCode();
        }
        #endregion
    }
}
