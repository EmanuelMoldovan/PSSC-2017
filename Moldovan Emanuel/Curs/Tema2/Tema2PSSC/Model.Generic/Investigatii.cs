using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Generic
{
    public class Investigatii
    {
        private bool _ekg;
        public bool Ekg { get { return _ekg; } }

        private decimal _temperatura;
        public decimal Temperatura { get { return _temperatura; } }

        private bool _radiografie;
        public bool Radiografie { get { return _radiografie; } }

        public Investigatii(bool ekg, decimal temperatura, bool radiografie)
        {
            Contract.Requires<ArgumentException>(temperatura > 0, "temperatura");

            _ekg = ekg;
            _temperatura = temperatura;
            _radiografie = radiografie;
        }

        #region override object
        public override bool Equals(object obj)
        {
            var investigatii = (Investigatii)obj;
            return (Ekg == investigatii.Ekg && Temperatura == investigatii.Temperatura && Radiografie == investigatii.Radiografie);
        }

        public override int GetHashCode()
        {
            return Ekg.GetHashCode() + Temperatura.GetHashCode() + Radiografie.GetHashCode();
        }

        public override string ToString()
        {
            return string.Format("EKG efectuat: {0} - Temperatura: {1} - Radiografie efectuata: {2}", Ekg, Temperatura, Radiografie);
        }
        #endregion
    }
}
