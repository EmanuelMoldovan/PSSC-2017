using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Business
{
    public class CIF
    {
        private string _value;
        public string Value
        {
            get
            {
                return _value;
            }
            private set { }
        }

        public CIF(string value)
        {
            Contract.Requires(value.Length <=12 && value.Substring(0,2) == "RO");
            Value = value;
        }

        public override string ToString()
        {
            return Value;
        }
        public override bool Equals(object obj)
        {
            var cif = (CIF)obj; 
            return cif.Value.Equals(this.Value);
        }
    }
}
