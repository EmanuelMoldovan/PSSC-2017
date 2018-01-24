using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Modele.LimbaStraina
{
    public class LimbaStrainaFactory
    {
        public static readonly LimbaStrainaFactory Instance = new LimbaStrainaFactory();

        private LimbaStrainaFactory()
        {

        }

        public LimbaStraina CreeazaLimbaStraina(string nume)
        {
            var numeLength = nume.Length;
            Contract.Requires(numeLength > 5);
            var limbaS = new LimbaStraina(nume);
            return limbaS;
        }

       
    }
}
