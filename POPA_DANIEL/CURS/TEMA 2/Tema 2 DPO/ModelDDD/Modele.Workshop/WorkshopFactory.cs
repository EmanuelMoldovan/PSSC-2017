using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modele.Generic;
using Modele.Generic.Exceptions;
using System.Diagnostics.Contracts;

namespace Modele.Workshop
{
    public class WorkshopFactory
    {
        public static readonly WorkshopFactory Instance = new WorkshopFactory(); 

        private WorkshopFactory()
        {

        }

        public Workshop CreeazaWorkshop(string nume)
        {
            Contract.Requires<ArgumentNullException>(nume != null, "text");
            Contract.Requires<ArgumentInvalidLengthException>(nume.Length >= 2 && nume.Length <= 40, "Numele workshopului trebuie sa contina intre 2 si 40 de caractere.");

            var workshop = new Workshop(new PlainText(nume), new Punctaj(1,2));
            return workshop;
        }

        public Firma CreeazaFirma(string idParticipare, string numeFirma)
        {
            return new Firma(new IdParticipare(idParticipare), new PlainText(numeFirma));
        }
    }
}
