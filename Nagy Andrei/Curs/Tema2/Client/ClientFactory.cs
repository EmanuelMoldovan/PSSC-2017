using Model.Client;
using Model.Generic;
using Model.ParcAuto;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Client
{
    public class ClientFactory
    {
        public static readonly ClientFactory Instance = new ClientFactory();

        private ClientFactory()
        {

        }

        public Client CreeazaClient(string nume,string prenume, string cnp)
        {
            //Contract.Requires<ArgumentNullException>(nume != null, "text");
            //Contract.Requires<ArgumentNullException>(prenume != null, "text");
            //Contract.Requires(cnp.Length == 13, "CNP-ul trebuie sa contina 13 caractere!");
            var client = new Client(new PlainText(nume),new PlainText(prenume),cnp);
            return client;
        }

        public ContractCumparare CreeazaContractCumparare(Dealer dealer, Masina masina, Client client)
        {
            var contract = new ContractCumparare(dealer,masina,client);
            return contract;
        }
    }
}
