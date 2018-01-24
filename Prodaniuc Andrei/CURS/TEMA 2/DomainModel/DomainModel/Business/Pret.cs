using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Business
{
    public class Pret
    {
        private decimal _value;
        public decimal Value
        {
            get { return _value; }
            private set { }
        }


        public Pret(decimal pret)
        {
            Contract.Requires(pret > 0);
            Value = pret;
        }

        public override bool Equals(object obj)
        {
            var pret = (Pret)obj;
            return Value == pret.Value;
        }

        public override int GetHashCode()
        {
            return this.Value.GetHashCode();
        }

        public override string ToString()
        {
            return this.Value.ToString();
        }
    }
}
