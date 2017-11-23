using Generic.Exceptions;
using Modele.Generic;
using System;
using System.Diagnostics.Contracts;


namespace Modele.Cabinet
{
    public class CabinetFactory
    {
        public static readonly CabinetFactory Instance = new CabinetFactory();

        private CabinetFactory()
        {

        }

        public Cabinet CreazaCabinet(string nume)
        {
            Contract.Requires<ArgumentNullException>(nume != null, "text");
            Contract.Requires<ArgumentInvalidLengthException>(
                    nume.Length >= 2 && nume.Length <= 50,
                    "Numele Pacientului trebuie sa contina intre 2 si 50 de caractere.");

            var cabinet = new Cabinet(new PlainText(nume));

            return cabinet;
        }

        public Pacient ProgrameazaPacient(string CNP, string numePacient)
        {
            return new Pacient(
                                new CNP_Pacient(CNP),
                                new PlainText(numePacient));
        }
    }
}
