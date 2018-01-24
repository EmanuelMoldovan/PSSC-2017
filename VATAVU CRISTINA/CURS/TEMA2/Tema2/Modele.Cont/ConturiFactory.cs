using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modele.Generic;

namespace Modele.Cont
{
    public class ConturiFactory
    {
        public static readonly ConturiFactory Instance = new ConturiFactory();

        public ConturiFactory()
        {
        }

        public Cont CreazaCont(IBAN iban, Client client)
        {
            var cont = new Cont(iban, client);
            return cont;
        }

        public Client CreazaClient(PlainText nume, PlainText adresa)
        {
            var client = new Client( nume,  adresa);
            return client;
        }

    }
}
