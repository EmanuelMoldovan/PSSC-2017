using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using Core.Identity_and_access_Layer;
using Core.Identity_and_access_Layer.Services;
using Core.Identity_and_access_Layer.Models;
using UI.Menu_Pages;
using UI.Menus;
using System.Threading;

namespace UI.Services
{
    class UserService : Application.Services.IUserSession<User>
    {
        static IClientFactory<Client> clientFactory;
        static IClientRepository<Client> clientRepository;

        public UserService()
        {
            var container = new Castle.Windsor.WindsorContainer();
            container.Register(Castle.MicroKernel.Registration.Component.For <IClientFactory<Client>>().ImplementedBy<Infrastructure.ClientFactory>());
            container.Register(Castle.MicroKernel.Registration.Component.For<IClientRepository<Client>>().ImplementedBy<Infrastructure.Repositories.ClientRepository>());
            clientFactory = container.Resolve<IClientFactory<Client>>();
            clientRepository = container.Resolve<IClientRepository<Client>>();
        }

        public Role getUserRole(User u)
        {
            throw new NotImplementedException();
        }

        public void login(String u, String p)
        {
            if(clientRepository.getClientByUsernameAndPassWord(u, p) != null)
            {
                ClientMenu.Show();
            }
            else
            {
                Thread.Sleep(2000);
                MenuStart.Show();
            }
        }

        public void logout()
        {
            MenuStart.Show();
        }

        public void register(string u, string p, int roleNo, string n, string pr, int v, float tp)
        {
            var test = clientFactory.createClient(u, p, roleNo, n, pr, v, tp);
            if(test != null)
            {
                Console.WriteLine("Utilizatorul pentru " + test.Nume + " " + test.Prenume + " a fost creeat cu success!" +
                    " si are rolul de " + test.Tip);
            }
        }
    }
}
