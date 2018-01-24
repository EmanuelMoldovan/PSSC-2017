using PsscT2.Modele.ModeleClienti;
using PsscT2.Modele.ModeleSalariati;
using PsscT2.ModelGeneric;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsscT2.Modele.ModeleSocietate
{
    class Societate
    {
        private string nume;
        private List<Salariat> salariati { get; set; }
        private List<Client> clienti;
        private List<MijlocFix> mijloaceFixe { get; set; }
        private CapitalActiv capitalActiv { get; set; }
        private CapitalPasiv capitalPasiv { get; set; }
        public StareSocietate stare { get;  set; }
        private Cont cont;
        private int CUI;

        public Societate(string nume, List<Salariat> salariati, List<Client> clienti,  CapitalActiv capitalActiv, CapitalPasiv capitalPasiv,  Cont cont,int CUI)
        {
            this.Nume = nume;
            this.salariati = salariati;
            this.Clienti = clienti;
            this.capitalActiv = capitalActiv;
            this.capitalPasiv = capitalPasiv;
            this.Cont = cont;
            this.CUI1 = CUI;
        }

        public Societate()
        {
        }

        void AdaugaSalariat(Salariat salariat, Salariati salariati)
        {  

            Contract.Requires(salariat != null, "salariat");
            salariati.AdaugaSalariat(salariat);
        }


        void AdaugaClient(Client client, Clienti clienti)
        {
            Contract.Requires(client != null, "client");
            clienti.AdaugaClient(client);
        }


        public List<Salariat> GetSalariati
        {
            get { return salariati; }
        }

        public string Nume { get => nume; set => nume = value; }
        internal List<Client> Clienti { get => clienti; set => clienti = value; }
        internal Cont Cont { get => cont; set => cont = value; }
        public int CUI1 { get => CUI; set => CUI = value; }
    }
}
