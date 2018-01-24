using Models.Enums;

namespace Models
{
    public class Angajat : Persoana
    {
        public TipAngajat TipAngajat { get; private set; }

        public Angajat(Persoana persoana, TipAngajat tipAngajat) : base(persoana.Nume, persoana.Prenume, persoana.CNP)
        {
            TipAngajat = tipAngajat;
        }

        public override string ToString()
        {
            return base.ToString() + ", " + TipAngajat;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
    }
}