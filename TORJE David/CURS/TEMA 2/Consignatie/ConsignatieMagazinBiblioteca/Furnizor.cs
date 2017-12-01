using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsignatieMagazinBiblioteca
{
    public class Furnizor
    {
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public double Comision { get; set; }

        public decimal PaymentDue { get; set; }

        public Furnizor()
        {
            Comision = 0.5;
        }

        public Furnizor(string Nume, string Prenume)
        {
            this.Nume = Nume;
            this.Prenume = Prenume;
            Comision = 0.5;
        }

        public Furnizor(string Nume, string Prenume, double Comision)
        {
            this.Nume = Nume;
            this.Prenume = Prenume;
            this.Comision = Comision;
        }

        public string toString
        {
            get
            {
                return string.Format("{0} {1} - ${2}", Nume, Prenume, PaymentDue);
            }
        }
    }
}
