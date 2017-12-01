using Modele.Generic.Exceptions;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;

namespace Modele.Generic
{
    public class CNP_Pacient
    {
        private string _CNP;
        public string CNP { get { return _CNP; } }

        public CNP_Pacient(string CNP)
        {
            Contract.Requires<ArgumentNullException>(CNP != null, "text");
            Contract.Requires<ArgumentCannotBeEmptyStringException>(!string.IsNullOrEmpty(CNP), "text");
            Contract.Requires<ArgumentException>(CNP.Length == 12, "CNP-ul are 12 caractere.");

            _CNP = CNP;
        }


        #region override object
        public override string ToString()
        {
            return CNP;
        }

        public override bool Equals(object obj)
        {
            var nume = (CNP_Pacient)obj;
            return CNP.Equals(nume.CNP);
        }

        public override int GetHashCode()
        {
            return CNP.GetHashCode();
        }
        #endregion
    }
}
