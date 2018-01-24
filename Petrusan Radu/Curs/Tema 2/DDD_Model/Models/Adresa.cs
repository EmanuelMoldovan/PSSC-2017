using Models.Generic;

namespace Models
{
    public class Adresa
    {
        public PlainText Localitate { get; private set; }
        public PlainText Judet { get; private set; }
        public PlainText Strada { get; private set; }
        public string Numar { get; private set; }
        public CodPostal CodPostal { get; private set; }

        public Adresa(PlainText localitate, PlainText judet, PlainText strada, string numar, CodPostal codPostal)
        {
            Localitate = localitate;
            Judet = judet;
            Strada = strada;
            Numar = numar;
            CodPostal = codPostal;
        }

        public override bool Equals(object obj)
        {
            var adresa = (Adresa)obj;
            return adresa.CodPostal.Equals(CodPostal)
                && adresa.Judet.Equals(Judet)
                && adresa.Strada.Equals(Strada)
                && adresa.Numar.Equals(Numar);
        }

        public override string ToString()
        {
            return "Strada " + Strada + ", " + Numar + ", " + Localitate + ", Judet " + Judet + ", CP " + CodPostal;
        }

        public override int GetHashCode()
        {
            return Localitate.GetHashCode() + Judet.GetHashCode() + Strada.GetHashCode() + Numar.GetHashCode() + CodPostal.GetHashCode();
        }
    }
}
