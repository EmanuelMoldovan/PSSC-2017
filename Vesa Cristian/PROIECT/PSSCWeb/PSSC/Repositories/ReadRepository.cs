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
    public class ReadRepository:GenericFileRepository
    {
        public string path = @"D:\Anul4\PSSC\Proiect\Proiect\PSSCWeb\";
        public ReadRepository(string rootPath)
            : base(rootPath)
        {
        }

        public ReadRepository()
            : base("")
        {
        }

        public List<ClientDTO> CitesteClienti()
        {
            List<ClientDTO> allClients = new List<ClientDTO>();
            if (ExistaFisier(path + "clienti.json"))
            {
                allClients = JsonConvert.DeserializeObject<List<ClientDTO>>(CitesteContinutFisier(path+"clienti.json"));
            }
            return allClients;
        }

        public IEnumerable<ActionDTO> CitesteActiuni(Guid id,string username)
        {
            var allClients = CitesteClienti();
            var myActions = allClients.Find(x => x.Username == username).MyAccounts.Find(x=>x.Id==id).ActionList;
            return myActions.AsEnumerable();
        }

        public IEnumerable<ContDTO> CitesteConturi(string username)
        {
            var allClients = CitesteClienti();
            List<ContDTO> allAccounts = allClients.Find(x => x.Username == username).MyAccounts;
            List<ContDTO> userAccounts = new List<ContDTO>();
            var result = allClients.Find(x => x.Username == username);
            if (allAccounts != null)
            {   
                foreach (ContDTO cont in allAccounts)
                {
                    if (cont.User.Equals(username))
                    {
                        userAccounts.Add(cont);
                    }
                }
            }
            if (userAccounts != null)
            {
                if (userAccounts.Count != 0)
                    return userAccounts.AsEnumerable();
            }
            return null;   
        }
    }
}
