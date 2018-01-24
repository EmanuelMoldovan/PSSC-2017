using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modele.Generic;

namespace Modele.Cont
{
    public class Client
    {
        private PlainText nume;
        private PlainText adresa;

        public PlainText Nume{ get { return nume; } }
        public PlainText Adresa { get { return Adresa; } }

        public Client(PlainText nume, PlainText adresa)
        {
            this.nume = nume;
            this.adresa = adresa;
        }
    }
}
