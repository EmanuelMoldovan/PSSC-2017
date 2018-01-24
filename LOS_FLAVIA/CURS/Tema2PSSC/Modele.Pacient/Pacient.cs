using Modele.Generic;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.Pacient
{
    public class Pacient
    {
        public string Cnp { get; set; }
        string Nume { get; set; }
        string Prenume { get; set; }
        Adresa Adresa { get; set; }
        string Afectiune { get; set; }
        Data Internare { get; set; }

        public Pacient(string cnp, string nume, string prenume, Adresa adresa, string afectiune,Data internare)
        {
            Contract.Requires(cnp != null, "dati CNP");
            Contract.Requires(nume != null, "dati nume");
            Contract.Requires(prenume != null, "dati prenume");
            Contract.Requires(afectiune != null, "dati afectiunea");
            Contract.Requires(internare != null, "dati data internarii");

            Cnp = cnp;
            Nume = nume;
            Prenume = prenume;
            Adresa = adresa;
            Afectiune = afectiune;
            Internare = internare;
        }
        public override string ToString()
        {
            return "Nume: " + Nume.ToString() + "\nPrenume:" + Prenume + "\nAdresa:"
                + Adresa.toString() + "\nAfectiune:"+ Afectiune+ "\nData internarii:" + Internare.ToString()+"\n\n";
        }

        public override bool Equals(object obj)
        {
            var pacient = (Pacient)obj;

            if (pacient != null)
            {
                return Cnp.Equals(pacient.Cnp);
            }
            return false;
        }



    }
}
