using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modele.Generic;
using System.Diagnostics.Contracts;

namespace Modele.Activitate
{
    public class Echipe
    {
        public TextNume nume { get; internal set; }
        private List<Puncte> punctaj;
        public List<Taberist> taberisti;

        public Echipe(TextNume nume, List<Taberist> taberisti)
        {
            Contract.Requires(nume != null, "nume =>null");
            this.nume = nume;
            this.punctaj = new List<Puncte>();
            this.taberisti = taberisti;
        }
        public void addPunctaj(Puncte p)
        {
            punctaj.Add(p);
        }

        public double MediePunctaje()
        {
            double M, S = 0;
            foreach(Puncte p in punctaj)
            {
                S = S + p.Valoare;
            }
            M = S / punctaj.Count;
            return M;
        }
        public List<Puncte> Punctaj
        {
            get
            {
                return punctaj;
            }
            set
            {
                punctaj = value;
            }
        }



    }
}
