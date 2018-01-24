using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;

namespace Models.Tranzactie
{
    public class Imprumut
    {
        private string iban;
        private string data;
        private double suma;

        public Imprumut(string iban, string data, double suma)
        {
            Contract.Requires(iban != null, "IBAN must not be null");
            Contract.Requires(data != null, "Data must not be null");
            Contract.Requires(suma != 0, "Suma must not be null");

            this.iban = iban;
            this.data = data;
            this.suma = suma;
        }

        public string IBAN
        {
            get { return iban; }
            set { iban = value; }
        }

        public string DATA
        {
            get { return data; }
            set { data = value; }
        }

        public double SUMA
        {
            get { return suma; }
            set { suma = value; }
        }

    }
}
