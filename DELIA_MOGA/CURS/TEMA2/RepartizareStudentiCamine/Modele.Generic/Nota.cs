using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.Generic
{
    public class Nota
    {

        private decimal _valoare;
        public decimal Valoare { get { return _valoare; } }

        public Nota(decimal valoare)
        {
            if (valoare < 0 || valoare > 10)
            {
                throw new ArgumentException();
            }

            _valoare = valoare;
        }

        static public bool MaiMica(Nota n1, Nota n2)
        {
            if (n1._valoare < n2._valoare)
                return true;
            else
                return false;
        }

        #region override object
        public override bool Equals(object obj)
        {
            var nota = (Nota)obj;
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
