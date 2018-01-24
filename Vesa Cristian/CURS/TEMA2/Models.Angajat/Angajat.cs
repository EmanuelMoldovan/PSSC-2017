using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;

namespace Models.Angajat
{
    public class Angajat
    {
        private string nume;
        private string prenume;
        private string nr_telefon;
        private string adresa;
        private double salar;

        public Angajat(string nume, string prenume, string nr_telefon, string adresa, double salar)
        {
            Contract.Requires(nume != null, "Nume must not be null");
            Contract.Requires(prenume != null, "Prenume must not be null");
            Contract.Requires(nr_telefon != null, "Nr_telefon must not be null");
            Contract.Requires(adresa != null, "Adresa must not be null");
            Contract.Requires(salar < 800, "Salar is not enough");

            this.nume = nume;
            this.prenume = prenume;
            this.nr_telefon = nr_telefon;
            this.adresa = adresa;
            this.salar = salar;
        }

        public string NUME
        {
            get { return nume; }
            set { nume = value; }
        }

        public string PRENUME
        {
            get { return prenume; }
            set { prenume = value; }
        }

        public string NR_TELEFON
        {
            get { return nr_telefon; }
            set { nr_telefon = value; }
        }

        public string ADRESA
        {
            get { return adresa; }
            set { adresa = value; }
        }

        public double SALAR
        {
            get { return salar; }
            set { salar = value; }
        }
    }
}
