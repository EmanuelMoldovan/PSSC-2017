using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.Banca
{
    public class BancaFactory
    {
        public static Banca CreeazaBanca (String n, String a, Boolean Ac)
        {
            return new Banca(n, a, Ac);
        }
    }
}
