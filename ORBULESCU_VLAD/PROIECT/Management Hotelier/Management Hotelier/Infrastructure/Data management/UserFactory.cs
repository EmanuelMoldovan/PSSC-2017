using Core.Identity_and_access_layer;
using Core.Identity_and_access_layer.Models;
using Core.Persons_layer.Models;
using Core_services.Factories;
using Core_services.Repositories;
using Infrastructure;
using Infrastructure.Data_management;
using Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data_management
{
    public class UserFactory : IUserFactory<User>
    {
        protected String filePath = @"C:\Users\Vlad Orbulescu\Documents\Facultate\DDD\Management Hotelier\Management Hotelier\Infrastructure\Storage\Users.json";
        IPersonFactory<Persoana> personFactory;
        IFileManager<List<Object>> fileManager;
        IDataCheck dataCheck;
        IUserRepository<User> userRepository;
        IDataCaster<User> userDataCaster;
        public UserFactory() //TODO - General Repository and factory interface for all types of users
        {
            var container = new Castle.Windsor.WindsorContainer();
            container.Register(Castle.MicroKernel.Registration.Component.For<IPersonFactory<Persoana>>().ImplementedBy<Core_services.Factories.PersonRepository>());
            container.Register(Castle.MicroKernel.Registration.Component.For<IFileManager<List<Object>>>().ImplementedBy<FileManager>());
            container.Register(Castle.MicroKernel.Registration.Component.For<IDataCheck>().ImplementedBy<DataCheck>());
            container.Register(Castle.MicroKernel.Registration.Component.For<IUserRepository<User>>().ImplementedBy<UserRepository>());
            container.Register(Castle.MicroKernel.Registration.Component.For<IDataCaster<User>>().ImplementedBy<DataCaster<User>>());
            personFactory = container.Resolve<IPersonFactory<Persoana>>();
            fileManager = container.Resolve<IFileManager<List<Object>>>();
            dataCheck = container.Resolve<IDataCheck>();
            userRepository = container.Resolve<IUserRepository<User>>();
            userDataCaster = container.Resolve<IDataCaster<User>>();
        }

        public User CreateUser(string u, string p, string e, int roleNo, string n, string pr, Adresa a, int v)
        {
            List<User> aux = userRepository.getAllUsers();
            if (aux == null)
            {
                aux = new List<User>();
                User userNou = new User(u, p, e, 0);
                personFactory.CreatePersoana(userNou.UserId, n, pr, a, v);
                aux.Add(userNou);
                fileManager.WriteToFile(userDataCaster.CastTypeListToObjectList(aux), filePath);
                return userNou;
            }
            else
            {
                if (!dataCheck.CheckDuplicateUsername(u, aux))
                {
                    User userNou = new User(u, p, e, 0);
                    personFactory.CreatePersoana(userNou.UserId, n, pr, a, v);
                    aux.Add(userNou);
                    fileManager.WriteToFile(userDataCaster.CastTypeListToObjectList(aux), filePath);
                    return userNou;
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
