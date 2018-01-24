using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Banca.Entities;
using Models.FilialaBanca.Entities;
using Models.Generic;
using Models.Banca.Types;

namespace MyFactory
{
    public class EntityFactory
    {
        public static readonly EntityFactory instance = new EntityFactory();

        private EntityFactory() { }

        public Client CreazaClient(string nume, string prenume, string cnp)
        {
            var Nume = new PlainText(nume);
            var Prenume = new PlainText(prenume);
            var CNP = new PlainText(cnp);

            var client = new Client(Nume, Prenume, CNP);

            return client;
        }

        public Cont CreazaCont(string iban, double suma)
        {
            var IBAN = new PlainText(iban);

            var cont = new Cont(IBAN, suma);

            return cont;
        }

        public Tranzactie creazaTranzactie(TipTranzactie tip, string iban, string data, double suma)
        {
            var IBAN = new PlainText(iban);
            var Data = new PlainText(data);

            var tranzactie = new Tranzactie(tip, IBAN, Data, suma);
            return tranzactie;
        }

        public Angajat creazaAngajat(string nume, string prenume, string nr_telefon, string adresa, double salar)
        {
            var Nume = new PlainText(nume);
            var Prenume = new PlainText(prenume);
            var Adresa = new PlainText(adresa);
            var Nr_telefon = new PlainText(nr_telefon);

            var angajat = new Angajat(Nume, Prenume, Nr_telefon, Adresa, salar);
            return angajat;

        }

    }
}
