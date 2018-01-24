using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modele.Generic.Exceptions;

namespace Modele.Generic
{
    public class IBAN
    {
        private string cod;
        public string getIBAN{get{return cod;}}

        public IBAN(string cod)
        {
            Contract.Requires<IBANFormatNotOKException>(Char.IsLetter(cod[0]) && Char.IsLetter(cod[1])
                                                     && Char.IsDigit(cod[2]) && Char.IsDigit(cod[3])
                                                     && Char.IsLetter(cod[4]) && Char.IsLetter(cod[5])
                                                     && Char.IsLetter(cod[6]) && Char.IsLetter(cod[7]),
                                                     "IBAN incorect");
            Contract.Requires<IBANLengthNotOKException>(cod.Length == 24, "IBAN de lungime incorecta");
            this.cod = cod;
        }
    }
}
