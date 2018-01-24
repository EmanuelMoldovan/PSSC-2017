using PsscT2.ModelGeneric;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsscT2.Modele.ModeleSalariati
{
    class Salariat
    {
        private String nume;
        private int salariu;
        private Cont cont;

        public Salariat(string nume, int salariu, Cont cont)
        {
            this.nume = nume;
            this.salariu = salariu;
            this.cont = cont;
        }

        public string Nume { get => nume; set => nume = value; }
        public int Salariu { get => salariu; set => salariu = value; }
        public Cont Cont { get => cont; set => cont = value; }
    }
}
