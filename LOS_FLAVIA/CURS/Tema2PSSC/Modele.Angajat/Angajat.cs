using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modele.Generic;
using System.Diagnostics.Contracts;

namespace Modele.Angajat
{
    public class Angajat
    {
        string Cnp { get; set; }
        string Nume { get; set; }
        string Prenume { get; set; }
        Adresa Adresa { get; set; }
        string Post { get; set; }
        string Superior { get; set; }

        public Angajat(string cnp, string nume, string prenume, Adresa adresa, string post, string superior)
        {
            Contract.Requires(cnp != null, "dati CNP");
            Contract.Requires(nume != null, "dati nume");
            Contract.Requires(post != null, "dati postul");

            Cnp = cnp;
            Nume = nume;
            Prenume = prenume;
            Adresa = adresa;
            Post = post;
            Superior = superior;
        }

        public override string ToString()
        {
            return "Nume: " + Nume.ToString() +"\nPrenume:"+Prenume+"\nAdresa:"
                +Adresa.toString()+"\nPost ocupat:"+Post+"\nSuperior:"+Superior;
        }

        public override bool Equals(object obj)
        {
            var angajat = (Angajat)obj;

            if (angajat != null)
            {
                return Cnp.Equals(angajat.Cnp);
            }
            return false;
        }




    }
}
