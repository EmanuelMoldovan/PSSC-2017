using Model.Generic.Exceptions;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Generic
{
    public class Telefon
    {
        private string _telefon;
        public string TELEFON { get { return _telefon; } }

        public Telefon(string telefon)
        {
            Contract.Requires<ArgumentNullException>(telefon != null, "text");
            Contract.Requires<ArgumentCannotBeEmptyStringException>(!string.IsNullOrEmpty(telefon), "text");
            Contract.Requires<ArgumentException>(telefon.Length == 10, "TELEFON are exact 10 caractere.");

            _telefon = telefon;
        }

        #region override object
        public override string ToString()
        {
            return TELEFON;
        }

        public override bool Equals(object obj)
        {
            var telefon = (Telefon)obj;
            return TELEFON.Equals(telefon.TELEFON);
        }

        public override int GetHashCode()
        {
            return TELEFON.GetHashCode();
        }

        #endregion
    }
}
