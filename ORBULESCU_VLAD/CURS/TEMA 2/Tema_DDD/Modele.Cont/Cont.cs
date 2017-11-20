using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modele.Generic;

namespace Modele.Cont
{
    public class Cont
    {
        public NrCont NrCont { get; internal set; }
        public String Valuta { get; internal set; }
        public float Suma { get; internal set; }

       internal Cont(String Val, float Sum)
        {
            NrCont = new NrCont();
            Valuta = Val;
            Suma = Sum;
        }

        public override string ToString()
        {
            return this.NrCont.NumarCont + " " + Valuta + " " + Suma.ToString();
        }
    }
}
