using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PSSC.Models;
using PSSC.Models.DTO;
using Newtonsoft.Json;

namespace PSSC.Repositories
{
    public class WriteRepository:GenericFileRepository
    {
        public string path = @"D:\Anul4\PSSC\Proiect\Proiect\PSSCWeb\";
        public WriteRepository() : base("")
        {
        }

        public WriteRepository(string path) : base(path)
        {

        }

        public Client adaugaClient(ClientDTO client)
        {
            var clientNou = new Client(client);
            SalvareClientInLista(clientNou);
            return clientNou;
        }

        public void adaugaCont(ContDTO account,string username)
        {
            var cont = new Cont(account);
            SalvareContInLista(account,username);
        }

        public bool adaugaAction(ActionDTO action,Guid id,string username)
        {
            return SalvareActionInLista(action,id,username);
        }

        private void SalvareClientInLista(Client client)
        {
            List<Client> allClients = new List<Client>();
            allClients = IncarcaListaDeClienti();
            allClients.Add(client);
            SalvareClientInListaClienti(allClients);
        }

        private void SalvareContInLista(ContDTO cont,string username)
        {
            List<Client> allClients = new List<Client>();
            allClients = IncarcaListaDeClienti();

            var thisClient = allClients.Find(x => x.Username == username);
            thisClient.adaugaCont(cont);
            SalvareClientInListaClienti(allClients);
        }

        private bool SalvareActionInLista(ActionDTO action,Guid id,string username)
        {
            List<Client> allClients = new List<Client>();
            allClients = IncarcaListaDeClienti();

            var account = allClients.Find(x => x.Username == username).myAccounts.Find(x => x.Id == id);
            if (account.makeTransaction(action))
            {
                account.adaugaActiune(action);
                SalvareClientInListaClienti(allClients);
                return true;
            }
            else
                return false;
        }

        public void deleteAccount(Guid id,string username)
        {
            List<Client> allClients = new List<Client>();
            allClients = IncarcaListaDeClienti();

            allClients.Find(x => x.Username == username).removeCont(id);
            SalvareClientInListaClienti(allClients);
        }

        private void SalvareClientInListaClienti(List<Client> allClients)
        {
            ScrieContinutFisier(path+"clienti.json", JsonConvert.SerializeObject(allClients));
        }

        private void SalvareContInListaConturi(List<ContDTO> allAccounts)
        {
            ScrieContinutFisier(path + "conturi.json", JsonConvert.SerializeObject(allAccounts));
        }

        private void SalvareActionInListaActions(List<ActionDTO> allActions)
        {
            ScrieContinutFisier(path + "action.json", JsonConvert.SerializeObject(allActions));
        }

        private List<ActionDTO> IncarcaListaDeActiuni()
        {
            List<ActionDTO> allActions = new List<ActionDTO>();
            if(ExistaFisier(path + "action.json"))
            {
                allActions = JsonConvert.DeserializeObject<List<ActionDTO>>(CitesteContinutFisier(path + "action.json"));
            }
            if (allActions == null)
            {
                return new List<ActionDTO>();
            }
            else
                return allActions;
        }

        private List<Cont> IncarcaListaDeConturi()
        {
            List<Cont> allAccounts = new List<Cont>();
            List<Client> allClient = IncarcaListaDeClienti();

            if (ExistaFisier(path + "clienti.json"))
            {
                allAccounts = JsonConvert.DeserializeObject<List<Cont>>(CitesteContinutFisier(path + "clienti.json"));
            }
            if (allAccounts == null)
            {
                return new List<Cont>();
            }
            else
                return allAccounts;
        }

        private List<Client> IncarcaListaDeClienti()
        {
            List<Client> allClients = new List<Client>();
            if (ExistaFisier(path+"clienti.json"))
            {
                allClients = JsonConvert.DeserializeObject <List<Client>>(CitesteContinutFisier(path+"clienti.json"));
            }
            if (allClients == null)
            {
                return new List<Client>();
            }
            else
                return allClients;
        }
    }
}
