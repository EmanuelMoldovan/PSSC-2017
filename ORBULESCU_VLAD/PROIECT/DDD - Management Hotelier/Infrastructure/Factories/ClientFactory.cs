using Core.Identity_and_access_Layer.Models;
using Core.Identity_and_access_Layer.Services;
using Infrastructure.Exceptions;
using Infrastructure.Repositories;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class ClientFactory : IClientFactory<Client>
    {
        IClientRepository<Client> clientRepository;
        public ClientFactory()
        {
            var container = new Castle.Windsor.WindsorContainer();
            container.Register(Castle.MicroKernel.Registration.Component.For<IClientRepository<Client>>().ImplementedBy<ClientRepository>());
            clientRepository = container.Resolve<IClientRepository<Client>>();
        }
        public Client createClient(string u, string p, int roleNo, string n, string pr, int v, float tp)
        {
            List<Client> clienti = clientRepository.getAllClients();
            if (clienti.Count != 0)
            {
                try
                {
                    if (clienti.Find(x => x.Username == u) != null)
                    {
                        Console.WriteLine("Username-ul exista deja!");
                        throw new UsernameAlreadyExistsException();
                    }
                }
                catch (UsernameAlreadyExistsException ex)
                {
                   Console.WriteLine(ex.ToString());
                   return null;
                }
            }
            Client clientNou = new Client(Guid.NewGuid(), u, p, roleNo, n, pr, v, tp);
            try
            {
                clienti.Add(clientNou);
                using (StreamWriter file = File.CreateText(@"C:\Users\Vlad Orbulescu\Documents\Facultate\DDD\DDD - Management Hotelier\Infrastructure\clienti.json"))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Serialize(file, clienti);
                }
            }
            catch(IOException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return clientNou;
        }
    }
}
