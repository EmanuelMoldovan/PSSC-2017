using Modele.Generic;
using Modele.Generic.Exceptions;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;

namespace Modele.Etaj
{
    public class EtajFactory
    {
        public static readonly EtajFactory Instance = new EtajFactory();

        private EtajFactory()
        {

        }

        public Etaj CreeazaEtaj(string numar)
        {
            Contract.Requires<ArgumentNullException>(numar != null, "text");
            Contract.Requires<ArgumentInvalidLengthException>(
                    numar.Length >= 2 && numar.Length <= 2, 
                    "Numele etajului trebuie sa contina 2 caractere.");
            
            var etaj = new Etaj(new PlainText(numar), 10);
            
            return etaj;
        }

        public Oaspete CreeazaOaspete(long cnp, string numeOaspete)
        {
            return new Oaspete(
                                cnp, 
                                new PlainText(numeOaspete));
        }
    }
}
