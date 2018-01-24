using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.Generic
{
    public class NumarMasina
    {
        private string numarMasina;
        public string Value { get { return numarMasina; } }

        public NumarMasina(string valoare)
        {
          // Contract.Requires<ArgumentException>(valoare.Length == 7, "Format incorect");


            numarMasina = valoare;
        }

        #region override object
        public override bool Equals(object obj)
        {
            var nr = (NumarMasina)obj;
            return Value == nr.numarMasina;
        }

       

        public override string ToString()
        {
            return string.Format("{0}", Value);
        }
        #endregion
    }
}

