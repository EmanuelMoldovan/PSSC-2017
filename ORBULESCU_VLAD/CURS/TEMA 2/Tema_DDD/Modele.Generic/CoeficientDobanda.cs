using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.Generic
{
    public static class CoeficientDobanda
    {
        public static float CalculeazaCoeficient(int NrClienti, float SumaTotalaRate)
        {
            return NrClienti * SumaTotalaRate / 100;
        }
    }
}
