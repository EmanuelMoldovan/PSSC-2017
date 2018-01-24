using Modele.Generic;
using Modele.Generic.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;


namespace Modele.Organizator
{
    public class OrganizatorFactory
    {
        public static readonly OrganizatorFactory Instance = new OrganizatorFactory();

        private OrganizatorFactory()
        {


        }

        public Organizator CreeazaOrganizator(TextNume nume, int varsta, GradOrganizator grad)
        {
            Contract.Requires<ArgumentNullException>(nume != null);
            Contract.Requires<ArgumentNumbersException>(System.Text.RegularExpressions.Regex.IsMatch(nume.ToString(), @"\d"), "Numele nu trebuie sa contina numere");

            var organizator = new Organizator(nume, varsta, grad);
            return organizator;
        }
    }
}
