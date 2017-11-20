using Modele.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.Clienti
{
    public class ClientFactory
    {
        //Ca si in cazul conturilor, un client poate fi creat doar prin intermediul apelului acestei metode
        public static Client CreeazaClient(String N, String P, String Cnp, String Ad, String Em, float Vl, RataCredit Rc)
        {
            return new Client(N, P, Cnp, Ad, Em, Vl, Rc);
        }
    }
}
