using Modele.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modele.Agent
{
    public class Agent
    {
        public List<Cumparator> Cumparatori { get; set; }
        public List<Vanzator> Vanzatori { get; set; }
        public List<Locuinta> Locuinte { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public bool esteLocuintaDisponibila;
        public bool locuinteDisponibile;
        public bool esteDisponibila
        {
            get { return esteLocuintaDisponibila; }
            set { this.esteLocuintaDisponibila = (this.Cumparatori.Count() == 0) ? true : false; }
        }
        public bool areLocuinteDisponibile
        {
            get { return locuinteDisponibile; }
            set { this.locuinteDisponibile = (this.Locuinte.Count() == 0) ? true : false; }
        }
        public Agent(List<Cumparator> Cumparatori, List<Vanzator> Vanzatori, string Nume, string Prenume, List<Locuinta> Locuinte)
        {
            Cumparatori = Cumparatori;
            Vanzatori = Vanzatori;
            Locuinte = Locuinte;
            Nume = Nume;
            Prenume = Prenume;
        }
    }
}
