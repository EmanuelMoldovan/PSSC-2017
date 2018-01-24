using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.Generic
{
    public class Durata
    {
        private UInt16 _valoare; //ce tip trb???????
        public UInt16 Valoare { get { return _valoare; } }

        public Durata(UInt16 valoare)
        {
            _valoare = valoare;
        }

        #region override object
        public override bool Equals(object obj)
        {
            var nota = (Durata)obj;
            return Valoare == nota.Valoare;
        }

        public override int GetHashCode()
        {
            return Valoare.GetHashCode();
        }

        public override string ToString()
        {
            return string.Format("{0}", Valoare);
        }
        #endregion
    }
}
