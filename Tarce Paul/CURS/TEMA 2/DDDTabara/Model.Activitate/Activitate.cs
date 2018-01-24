using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modele.Generic;
using Modele.Generic.Exceptions;

namespace Modele.Activitate
{
    public class Activitate : IDataSource
    {

        public TextNume nume { get; internal set; }
        private int durata;
        public StareActivitate stareActivitate { get; internal set; }
        private List<Echipe> echipe { get; set; }

        private Puncte punctajCastigator;
        public static int nrEchipe = 0;


        public Activitate(TextNume nume, int durata, Puncte punctajCastigator)
        {
            stareActivitate = StareActivitate.Creeata;
            this.durata = durata;
            this.echipe = new List<Echipe>();
            this.punctajCastigator = punctajCastigator;
        }

        public void adaugaEchipa(Echipe e)
        {

            Contract.Requires(e != null, "Echipa=>null");
            Contract.Requires(nrEchipe <= 10, "Nr maxim de echipe");
            echipe.Add(e);
            nrEchipe++;
            stareActivitate = StareActivitate.Pregatire;
        }
        public void adaugaEchipe(List<Echipe> echipe)
        {
            Contract.Requires(echipe!= null, "Echipa=>null");
            Contract.Requires(nrEchipe <= 10, "Nr maxim de echipe");
            foreach(var e in echipe)
            {
                echipe.Add(e);
                var look = echipe.FirstOrDefault(x => x.nume.Equals(e.nume)); 
                if( look == null)
                {
                    throw new Modele.Generic.Exceptions.EchipaExistaExceptions("Echipa exista!!");
                }
            }
            nrEchipe = nrEchipe + echipe.Count;
        }

        public void StartActivitate()
        {
            Contract.Requires(stareActivitate == StareActivitate.Pregatire, "Pregatirile s-au terminat");
            stareActivitate = StareActivitate.InDesfasurare;
        }

        public void StopActivitate()
        {
            Contract.Requires(stareActivitate == StareActivitate.InDesfasurare, "");
            stareActivitate = StareActivitate.Incheiata;
        }

        public TextNume getEchipaCastigatoare()
        {                      
            return calculPunctajMaxEchipa();
        }
        public TextNume calculPunctajMaxEchipa()
        {
            int max = 0;
            TextNume nume = new TextNume("");
            foreach (Echipe e in echipe)
            {
                int S = 0;
                foreach (Puncte p in e.Punctaj)
                {
                    S = S + p.Valoare;
                }
                if (S > max)
                {
                    max = S;
                    nume = new TextNume(e.nume.Text);
                }
            }
            return nume;
        }
        public Puncte PunctajCastigator
        {
            get
            {
                return punctajCastigator;
            }
            set
            {
                punctajCastigator = value;
            }
        }

        public int Durata
        {
            get
            {
                return durata;
            }

            set
            {
                durata = value;
            }
        }
    }
}
