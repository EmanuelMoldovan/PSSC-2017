using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Business
{
    public class Adresa
    {
        private string _oras;
        public string Oras
        {
            get { return _oras; }
            private set { }
        }

        private string _strada;
        public string Strada
        {
            get { return _strada; }
            private set { }
        }

        private string _numar;
        public string Numar
        {
            get { return _numar; }
            private set { }
        }
        public Adresa(string strada, string numar)
        {
            Contract.Requires(!string.IsNullOrEmpty(strada) && !string.IsNullOrEmpty(numar), "mesaj");
            _numar = numar;
            _strada = strada;
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}", this.Oras, this.Strada, this.Numar);
        }

        public override bool Equals(object obj)
        {
            var adresa = (Adresa)obj;
            return this.Strada.Equals(adresa.Strada) && this.Numar.Equals(adresa.Numar) && this.Oras.Equals(adresa.Oras);
        }

        public override int GetHashCode()
        {
            return 
                this.Oras.GetHashCode() * 
                this.Strada.GetHashCode() * 
                this.Numar.GetHashCode();
        }
    }
}
