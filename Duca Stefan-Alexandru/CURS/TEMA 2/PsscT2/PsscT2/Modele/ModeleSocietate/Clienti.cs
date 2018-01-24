using PsscT2.Modele.ModeleClienti;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsscT2.Modele.ModeleSocietate
{
    class Clienti
    {
        private  List<Client> clienti = new List<Client>();

       public void AdaugaClient(Client client)
        {
            Contract.Requires(client != null, "client");
            clienti.Add(client);
        }

        public List<Client> GetClienti
        {
           get { return clienti; }
        }
        
    }
}
