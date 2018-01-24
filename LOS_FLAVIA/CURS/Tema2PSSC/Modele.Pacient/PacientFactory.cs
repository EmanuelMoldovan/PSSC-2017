using Modele.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.Pacient
{
    class PacientFactory
    {
        public static readonly PacientFactory Instance = new PacientFactory();

        public Pacient creeazaPacient(string cnp,string nume,string prenume,Adresa adresa, string afectiune, Data internare)
        {
            var pacient = new Pacient(cnp,nume,prenume,adresa,afectiune,internare);
            Pacienti pacienti = new Pacienti();
            pacienti.AdaugaPacient(pacient);
            return pacient;
        }
    }
}
