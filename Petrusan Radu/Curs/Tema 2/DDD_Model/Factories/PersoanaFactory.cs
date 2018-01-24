using Models;
using Models.Enums;
using Models.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factories
{
    public class PersoanaFactory
    {
        public static readonly PersoanaFactory Instance = new PersoanaFactory();

        private PersoanaFactory() { }

        public Persoana CreazaPersoana(string nume, string prenume, string cnp)
        {
            var numePlainText = new PlainText(nume);
            var prenumePlainText = new PlainText(prenume);

            var persoana = new Persoana(numePlainText, prenumePlainText, cnp);

            return persoana;
        }

        public Angajat CreazaAngajat(string nume, string prenume, string cnp, TipAngajat tipAngajat)
        {
            var numePlainText = new PlainText(nume);
            var prenumePlainText = new PlainText(prenume);

            var persoana = new Persoana(numePlainText, prenumePlainText, cnp);

            var angajat = new Angajat(persoana, tipAngajat);

            return angajat;
        }

        public Client CreazaClient(string nume, string prenume, string cnp, TipClient tipClient)
        {
            var numePlainText = new PlainText(nume);
            var prenumePlainText = new PlainText(prenume);

            var persoana = new Persoana(numePlainText, prenumePlainText, cnp);

            var client = new Client(persoana, tipClient);

            return client;
        }
    }
}
