using PsscT2.ModelGeneric;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsscT2.Modele.ModeleClienti
{
    class Client
    {
        private string nume;
        private Cont cont_client;

        public Client(string nume,  Cont cont_client)
        {
            this.nume = nume;
            this.cont_client = cont_client;
        }

        public string Nume { get => nume; set => nume = value; }
        public Cont Cont_client { get => cont_client; set => cont_client = value; }
    }
}
