using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics.Contracts;
using Modele.Generic.Exceptions;
using Modele.ClasaStudiu;
using Modele.Generic;


namespace Modele.ClasaStudiu
{
    public class ClasaStudiuFactory
    {
        public static readonly ClasaStudiuFactory Instance = new ClasaStudiuFactory();

        public ClasaStudiu CreeazaClasaStudiu(string nume)
        {
            Contract.Requires<ArgumentNullException>(nume != null, "text");
            Contract.Requires<ArgumentInvalidLengthException>(nume.Length >= 2 && nume.Length <= 10,
                    "Numele clasei trebuie sa contina intre 2 si 10 de caractere.");

            var clasaStudiu = new ClasaStudiu(new PlainText(nume));

            return clasaStudiu;
        }
    }
}
