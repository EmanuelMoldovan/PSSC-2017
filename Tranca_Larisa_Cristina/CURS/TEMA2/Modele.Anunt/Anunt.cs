using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Modele.Generic;
using Modele.Agent;

namespace Modele.Anunt
{
    public class Anunt
    {
        public Locuinta Locuinta { get; set; }
        public string Descriere { get; set; }
        public DateTime Data { get; set; }
        public float pretul { get; set; }
        public string locatia { get; set; }
        public Email AdresaEmail { get; set; }
        public Telefon NumarTelefon { get; set; }
        public bool anunturiNoi;
        private string nume;
        private Email email;
        private Telefon telefon;
        private Email email1;
        private Telefon telefon1;

        public bool AnunturiNoi
        {
            get { return anunturiNoi; }
            set { this.anunturiNoi = (this.Data.Year >2016 ) ? true : false; }
        }
        public Anunt(Locuinta Locuinta, string Descriere, DateTime Data, float pretul, string locatia, Email AdresaEmail, Telefon NumarTelefon)
        {
            Locuinta = Locuinta;
            Descriere = Descriere;
            Data = Data;
            pretul = pretul;
            locatia = locatia;
            AdresaEmail = AdresaEmail;
            NumarTelefon = NumarTelefon;
        }

        public Anunt(Agent.Locuinta locuinta, string nume, float pretul, string locatia, Email email, Telefon telefon)
        {
            Locuinta = locuinta;
            this.nume = nume;
            this.pretul = pretul;
            this.locatia = locatia;
            this.email = email;
            this.telefon = telefon;
        }
    }
}
