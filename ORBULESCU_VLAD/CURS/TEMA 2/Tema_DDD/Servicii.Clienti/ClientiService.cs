using Modele.Clienti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicii.Clienti
{
    class ClientiService
    {
        public void Crediteaza(Client C, float SumaRata)
        {
            C.RataCredit.Rata = SumaRata;
        }
    }
}
