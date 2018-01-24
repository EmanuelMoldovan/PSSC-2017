using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Business
{
    public class MagazinFactory
    {
        public static readonly MagazinFactory Instance = new MagazinFactory();

        private MagazinFactory()
        {

        }

        public Magazin CreateMagazin(string denumire, string cif)
        {
            Contract.Requires(denumire!=null, "message");
            Contract.Requires(cif!=null);
            return new Magazin(denumire, cif);
        }
    }
}
