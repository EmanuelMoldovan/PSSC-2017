using Modele.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;


namespace Modele.Workshop
{
    public class Training
    {
        public PlainText Nume { get; internal set; }

        public Uri LinkContinut { get; internal set; }

        internal Training(PlainText nume)
        {
            Contract.Requires(nume != null, "nume");
            Nume = nume;
        }

        #region operations
        internal void ActualizareLinkContinut(Uri url)
        {
            Contract.Requires(url != null, "url");
            LinkContinut = url;
        }
        #endregion

        #region override object
        public override string ToString()
        {
            return Nume.ToString(); 
        }

        public override bool Equals(object obj)
        {
            var training = (Training)obj;
             if (training != null)
            {
                return Nume.Equals(training.Nume);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Nume.GetHashCode();
        }
        #endregion
    }
}