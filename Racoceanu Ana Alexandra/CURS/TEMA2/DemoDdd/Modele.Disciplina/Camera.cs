using Modele.Generic;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;

namespace Modele.Etaj
{
    public class Camera
    {
        public PlainText Numar { get; internal set; }
        public Uri Tip { get; internal set; }

        internal Camera(PlainText numar)
        {
            Contract.Requires(numar != null, "numar");
            Numar = numar;
        }

        #region operations
        internal void ActualizareLinkContinut(Uri url)
        {
            Contract.Requires(url != null, "url");
            Tip = url;
        }
        #endregion

        #region override object
        public override string ToString()
        {
            return Numar.ToString();
        }

        public override bool Equals(object obj)
        {
            var curs = (Camera)obj;

            if (curs != null)
            {
                return Numar.Equals(curs.Numar);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Numar.GetHashCode();
        }
        #endregion

    }
}
