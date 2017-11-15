using Model.ParcAuto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Client
{
    public class ContractCumparare
    {
        public Dealer Dealer { get; private set; }
        public Masina Masina { get; private set; }
        public Client Client { get; private set; }
        public ContractCumparare(Dealer dealer,Masina masina, Client client)
        {
            Dealer = dealer;
            Masina = masina;
            Client = client;
        }
    }
}
