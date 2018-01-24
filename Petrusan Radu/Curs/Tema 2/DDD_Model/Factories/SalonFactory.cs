using Models;
using Models.Enums;
using Models.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factories
{
    public class SalonFactory
    {
        public static readonly SalonFactory Instance = new SalonFactory();

        private SalonFactory() { }

        public Salon CreazaSalon(string denumire, TipStareSalon tip, Adresa adresa, string cif)
        {
            var denumirePlainText = new PlainText(denumire);
            var cifPlainText = new PlainText(cif);

            var salon = new Salon(denumirePlainText, tip, adresa, cifPlainText);

            return salon;
        }
    }
}
