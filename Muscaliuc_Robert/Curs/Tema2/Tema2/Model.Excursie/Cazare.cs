using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.Excursie
{
    public class Cazare
    {
        private string numeCazare;
        private string locatieCazare;
        public string NumeCazare { get { return numeCazare; } }

        internal Cazare(string nume, string locatie)
        {
            numeCazare = nume;
            locatieCazare = locatie;
        }
        internal Cazare(string nume)
        {
            numeCazare = nume;
        }
    }
}
