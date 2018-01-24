using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;
using Models.Generic;
using Models.Banca.Entities;

namespace Models.Banca
{
    public class Banca
    {
        private PlainText nume;
        private List<Client> clienti;
        private List<FilialaBanca.FilialaBanca> filiale;
        public Banca(PlainText nume)
        {
            this.nume = nume;
            clienti = new List<Client>();
            filiale = new List<FilialaBanca.FilialaBanca>();
        }

        public void adaugaClient(Client client)
        {
            clienti.Add(client);
        }

        public void adaugaFiliala(FilialaBanca.FilialaBanca filiala)
        {
            filiale.Add(filiala);
        }

        public PlainText Nume { get => nume; set => nume = value; }
        public List<Client> Prenume { get => clienti; }
        public List<FilialaBanca.FilialaBanca> FilialaBanca { get => filiale;}
        public override bool Equals(object obj)
        {
            var name = (PlainText)obj;
            return nume.Equals(name.Text);
        }

        public override string ToString()
        {
            return nume.ToString();
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
}
