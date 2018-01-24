using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;
using Models.Banca.Entities;
using Models.Generic;

namespace Models.Banca.Entities
{
    public class Client
    {
        private PlainText nume;
        private PlainText prenume;
        private PlainText cnp;
        private List<Cont> conturi;
        private List<Tranzactie> tranzactii;

        public Client(PlainText nume, PlainText prenume, PlainText cnp)
        {
            this.nume = nume;
            this.prenume = prenume;
            this.cnp = cnp;
            conturi = new List<Cont>();
            tranzactii = new List<Tranzactie>();
        }

        public PlainText Nume { get => nume; set => nume = value; }
        public PlainText Prenume { get => prenume; set => prenume = value; }
        public PlainText CNP { get => cnp; set => cnp = value; }
        public List<Cont> Conturi { get => conturi; }
        public List<Tranzactie> Tranzactii { get => tranzactii; }

        public void adaugaCont(Cont cont)
        {
            conturi.Add(cont);
        }

        public void adaugaImprumut(Tranzactie tranzactie)
        {
            tranzactii.Add(tranzactie);
        }

        public override bool Equals(object obj)
        {
            var thisClient = (Client)obj;
            return cnp.Equals(thisClient.CNP);
        }

        public override string ToString()
        {
            return nume.ToString() + prenume.ToString() + cnp.ToString();
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
