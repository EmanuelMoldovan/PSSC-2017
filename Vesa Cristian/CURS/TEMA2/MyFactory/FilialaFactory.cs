using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Generic;
using Models.FilialaBanca;

namespace MyFactory
{
    public class FilialaFactory
    {
        public static readonly FilialaFactory Instance = new FilialaFactory();

        private FilialaFactory() { }

        public FilialaBanca creazaFiliala(string adresa)
        {
            var Adresa = new PlainText(adresa);

            var filiala = new FilialaBanca(Adresa);

            return filiala;
        }
    }
}
