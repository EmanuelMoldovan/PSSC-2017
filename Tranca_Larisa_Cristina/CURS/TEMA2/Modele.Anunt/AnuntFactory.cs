using Modele.Agent;
using Modele.Generic;
using Modele.Generic.Exceptions;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;

namespace Modele.Anunt
{
    class AnuntFactory
    {
        public static readonly AnuntFactory Instance = new AnuntFactory();

        private AnuntFactory()
        {

        }

        public Anunt CreeazaAnunt(string nume, string adresa, float pretul, string locatia, string AdresaEmail, int NumarTelefon)
        {
            Contract.Requires<ArgumentNullException>(nume != null, "text");
            Contract.Requires<ArgumentInvalidLengthException>(
                    nume.Length >= 2 && nume.Length <= 50,
                    "Numele anuntului trebuie sa contina intre 2 si 50 de caractere.");

            var anunt = new Anunt( new Locuinta(adresa),nume, pretul, locatia, new Email(AdresaEmail), new Telefon(NumarTelefon));

            return anunt;
        }
        public Agent CreeazaAgent(string nume, string prenume)
        {
            return new Agent(nume, prenume);
        }
    }
}
