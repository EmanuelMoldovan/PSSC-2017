using Core.Identity_and_access_Layer.Models;
using Core.Identity_and_access_Layer.Services;
using Infrastructure.Exceptions;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class ClientRepository : IClientRepository<Client>
    {
        public List<Client> getAllClients()
        {
            if(new FileInfo(@"C:\Users\Vlad Orbulescu\Documents\Facultate\DDD\DDD - Management Hotelier\Infrastructure\clienti.json").Length == 0)
            {
                return new List<Client>();
            }
            else
            {
                string listaClientiJson = File.ReadAllText(@"C:\Users\Vlad Orbulescu\Documents\Facultate\DDD\DDD - Management Hotelier\Infrastructure\clienti.json");
                List<Client> clienti = JsonConvert.DeserializeObject<List<Client>>(listaClientiJson);
                return clienti;
            }
        }

        public Client getClientByUserId(Guid id)
        {
            throw new NotImplementedException();
        }

        public Client getClientByUsernameAndPassWord(string u, string p)
        {
            try
            {
                if (new FileInfo(@"C:\Users\Vlad Orbulescu\Documents\Facultate\DDD\DDD - Management Hotelier\Infrastructure\clienti.json").Length == 0)
                {
                    throw new UsersDoNotExistException();
                }
                else
                {
                    string listaClientiJson = File.ReadAllText(@"C:\Users\Vlad Orbulescu\Documents\Facultate\DDD\DDD - Management Hotelier\Infrastructure\clienti.json");
                    List<Client> clienti = JsonConvert.DeserializeObject<List<Client>>(listaClientiJson);
                    Client deGasit = clienti.Find(x => x.Username == u && x.Password == p);
                    if(deGasit == null)
                    {
                        throw new UserNotExistingException();
                    }
                    else
                    {
                        return deGasit;
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }

        public void removeClientByUserId(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
