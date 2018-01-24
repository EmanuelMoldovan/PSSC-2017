using Models.Enums;
using Models.Generic;
using System.Collections.Generic;

namespace Models
{
    public class Salon
    {
        public PlainText Denumire { get; private set; }
        public TipStareSalon Stare { get; private set; }
        public Adresa Adresa { get; private set; }
        public PlainText CIF { get; private set; }

        public List<Angajat> Angajati { get; private set; }
        public List<Client> Clienti { get; private set; }

        public Salon(PlainText denumire, TipStareSalon stare, Adresa adresa, PlainText cif)
        {
            Denumire = denumire;
            Stare = stare;
            Adresa = adresa;
            CIF = cif;

            Angajati = new List<Angajat>();
            Clienti = new List<Client>();
        }

        public override string ToString()
        {
            return "Salon " + Denumire + ", " + Stare + ", CIF: " + CIF + ", " + Adresa;
        }

        public override bool Equals(object obj)
        {
            var salon = (Salon)obj;
            return salon.CIF.Equals(CIF);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}