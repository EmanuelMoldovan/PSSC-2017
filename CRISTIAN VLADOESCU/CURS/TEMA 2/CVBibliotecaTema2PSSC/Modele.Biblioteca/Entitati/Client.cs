using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.Biblioteca.Entitati
{
    public class Client
    {
        private string Nume;
        private string Prenume;
        private string CNP;
        private int nrCartiImprumutate;

        public Client(string nume, string prenume, string cNP, int nrCartiImprumutate)
        {
            Nume1 = nume;
            Prenume1 = prenume;
            CNP1 = cNP;
            this.NrCartiImprumutate = nrCartiImprumutate;
        }

        public string Nume1 { get => Nume; set => Nume = value; }
        public string Prenume1 { get => Prenume; set => Prenume = value; }
        public string CNP1 { get => CNP; set => CNP = value; }
        public int NrCartiImprumutate { get => nrCartiImprumutate; set => nrCartiImprumutate = value; }

        public override bool Equals(object obj)
        {
            var client = obj as Client;
            return client != null &&
                   Nume1 == client.Nume1 &&
                   Prenume1 == client.Prenume1 &&
                   CNP1 == client.CNP1 &&
                   NrCartiImprumutate == client.NrCartiImprumutate;
        }
    }
}
