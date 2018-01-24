using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Banca.Types;
using Models.Generic;
using System.Diagnostics.Contracts;

namespace Models.Banca.Entities
{
    public class Tranzactie
    {
        TipTranzactie tip;
        private PlainText iban;
        private PlainText data;
        private double suma;

        public Tranzactie(TipTranzactie tip, PlainText iban, PlainText data, double suma)
        {
            Contract.Requires(suma != 0, "Suma must not be null");

            this.tip = tip;
            this.iban = iban;
            this.data = data;
            this.suma = suma;
        }

        public PlainText IBAN { get => iban; set => iban = value; }
        public PlainText Data { get => data; set => data = value; }
        public double Suma { get => suma; set => suma = value; }
        public TipTranzactie Tip_Tranzactie { get => tip; }

        public override bool Equals(object obj)
        {
            var tranzaction = (Tranzactie)obj;
            return iban.Equals(tranzaction.IBAN);
        }

        public override string ToString()
        {
            return iban.ToString() + data.ToString() + suma;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
