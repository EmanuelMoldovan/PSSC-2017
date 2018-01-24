using Models.Enums;
using Models.Generic;
using System.Diagnostics.Contracts;

namespace Models
{
    public class Persoana
    {
        public PlainText Nume { get; private set; }
        public PlainText Prenume { get; private set; }
        public string CNP { get; private set; }
        public TipGen Gen { get; private set; }

        public Persoana(PlainText nume, PlainText prenume, string cnp)
        {
            Contract.Requires(cnp.Length == 13, "CNP-ul trebuie sa contina 13 caractere!");
            Nume = nume;
            Prenume = prenume;
            CNP = cnp;
            var gen = (int)cnp[0];
            Gen = (TipGen)gen;
        }

        public override bool Equals(object obj)
        {
            var persoana = (Persoana)obj;
            return persoana.CNP == CNP;
        }

        public override string ToString()
        {
            return Prenume + " " + Nume + ", " + Gen + ", " + CNP;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
