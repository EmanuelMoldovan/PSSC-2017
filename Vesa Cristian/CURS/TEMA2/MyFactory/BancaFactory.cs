using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Banca;
using Models.Generic;

namespace MyFactory
{
    public class BancaFactory
    {
        public static readonly BancaFactory Instance = new BancaFactory();

        private BancaFactory() { }

        public Banca creazaBanca(string nume)
        {
            var Nume = new PlainText(nume);

            var banca = new Banca(Nume);

            return banca;
        }
    }
}
