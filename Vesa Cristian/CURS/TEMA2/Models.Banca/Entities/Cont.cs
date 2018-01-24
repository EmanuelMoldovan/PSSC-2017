using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;
using Models.Generic;

namespace Models.Banca.Entities
{
    public class Cont
    {
        private PlainText iban;
        private double suma;

        public Cont(PlainText iban, double suma)
        {
            this.iban = iban;
            this.suma = suma;
        }

        public PlainText IBAN { get => iban; set => iban = value; }
        public double Suma { get => suma; set => suma = value; }
        
        public override bool Equals(object obj)
        {
            var thisCont = (Cont)obj;
            return iban.Equals(thisCont.IBAN);
        }

        public override string ToString()
        {
            return iban.ToString()+suma;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
