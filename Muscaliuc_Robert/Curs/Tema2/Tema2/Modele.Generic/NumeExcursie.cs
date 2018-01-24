using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.Generic
{
    public class NumeExcursie
    {
        private string _numeExcursie;
        public string Nume { get { return _numeExcursie; } }

        public NumeExcursie(string nume){
            _numeExcursie = nume;
        }
    }
}
