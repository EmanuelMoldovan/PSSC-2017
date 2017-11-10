using Model.Generic.Exceptions;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Generic
{
    public class Cnp
    {
        private string _cnp;
        public string CNP { get { return _cnp; } }

        public Cnp(string cnp)
        {
            Contract.Requires<ArgumentNullException>(cnp != null, "text");
            Contract.Requires<ArgumentCannotBeEmptyStringException>(!string.IsNullOrEmpty(cnp), "text");
            Contract.Requires<ArgumentException>(cnp.Length == 13, "CNP are exact 13 caractere.");

            _cnp = cnp;
        }

        #region override object
        public override string ToString()
        {
            return CNP;
        }

        public override bool Equals(object obj)
        {
            var cnp = (Cnp)obj;
            return CNP.Equals(cnp.CNP);
        }

        public override int GetHashCode()
        {
            return CNP.GetHashCode();
        }
        #endregion
    }
}
