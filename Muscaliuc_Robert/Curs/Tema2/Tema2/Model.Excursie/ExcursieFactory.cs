using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.Excursie
{
    public class ExcursieFactory
    {
        public static readonly ExcursieFactory Instance = new ExcursieFactory();
        private ExcursieFactory()
        {

        }

        public Excursie creazaExcursie(string nume, float pret, string cazare)
        {
            var excursie = new Excursie(nume, pret, new Cazare (cazare));
            return excursie;
        }
    }
}
