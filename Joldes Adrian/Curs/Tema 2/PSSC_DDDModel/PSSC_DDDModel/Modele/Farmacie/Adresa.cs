using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PSSC_DDDModel.Modele.Farmacie
{
    class Adresa
    {
        private int numar;

        public int Numar
        {
            get { return numar; }
            set { numar = value; }
        }

        private string strada;

        public string Strada
        {
            get { return strada; }
            set { strada = value; }
        }
        private string oras;

        public string Oras
        {
            get { return oras; }
            set { oras = value; }
        }
        private string tara;

        public string Tara
        {
            get { return tara; }
            set { tara = value; }
        }

        #region override objects
        public override string ToString()
        {
            return this.oras + ", " + this.strada + ", " + this.numar + ", " + this.tara;
        }

        public override bool Equals(object obj)
        {
            var adresa = (Adresa)obj;
            return this.numar.Equals(adresa.numar) &&
                this.strada.Equals(adresa.strada) &&
                this.oras.Equals(adresa.oras) &&
                this.tara.Equals(adresa.tara);
        }

        public override int GetHashCode()
        {
            return this.numar.GetHashCode() +
                this.strada.GetHashCode() +
                this.oras.GetHashCode() +
                this.tara.GetHashCode();
        }
        #endregion

    }
}
