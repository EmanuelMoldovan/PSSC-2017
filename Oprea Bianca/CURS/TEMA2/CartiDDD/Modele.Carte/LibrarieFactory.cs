using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modele.Generic;
using System.Collections.ObjectModel;

namespace Modele.Librarie
{
    public class LibrarieFactory
    {
        public static readonly LibrarieFactory instance = new LibrarieFactory(); 
        public Librarie Creaza(string nume)
        {
            Contract.Requires(nume != null, "Numele este null");
            var librarie = new Librarie(new Text(nume));
            return librarie;
        }
        public Librarie Creaza(string nume, Carti lista_carti, List<Utilizator> lista_util)
        {
            Contract.Requires(nume != null, "Numele este null");
            Contract.Requires(lista_carti != null, "Lista de carti este null");
            Contract.Requires(lista_util != null, "Lista de utilizatori este null");
            var librarie = new Librarie(new Text(nume), lista_carti, lista_util);
            return librarie;
        }

    }
}
