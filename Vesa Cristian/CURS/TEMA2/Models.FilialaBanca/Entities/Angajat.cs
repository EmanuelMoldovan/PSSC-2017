using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;
using Models.Generic;

namespace Models.FilialaBanca.Entities
{
    public class Angajat
    {
        private PlainText nume;
        private PlainText prenume;
        private PlainText nr_telefon;
        private PlainText adresa;
        private double salar;

        public Angajat(PlainText nume, PlainText prenume, PlainText nr_telefon, PlainText adresa, double salar)
        {
            Contract.Requires(salar < 800, "Salar is not enough");

            this.nume = nume;
            this.prenume = prenume;
            this.nr_telefon = nr_telefon;
            this.adresa = adresa;
            this.salar = salar;
        }

        public PlainText Nume { get => nume; set => nume = value; }
        public PlainText Prenume { get => prenume; set => prenume = value; }
        public PlainText Adresa { get => adresa; set => adresa = value; }
        public PlainText Nr_telefon { get => nr_telefon; set => nr_telefon = value; }
        public double Salar { get => salar; }
        public override bool Equals(object obj)
        {
            var angajat = (Angajat)obj;
            return nume.Equals(angajat.Nume) && prenume.Equals(angajat.Prenume) && adresa.Equals(angajat.Adresa) && nr_telefon.Equals(angajat.Nr_telefon);
        }

        public override string ToString()
        {
            return nume.ToString() + prenume.ToString() + adresa.ToString() + nr_telefon.ToString();
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
