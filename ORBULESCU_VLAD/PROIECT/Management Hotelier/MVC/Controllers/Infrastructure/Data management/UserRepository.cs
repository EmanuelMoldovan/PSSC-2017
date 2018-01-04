using Core.Identity_and_access_layer.Models;
using Core.Persons_layer.Models;
using Core_services.Repositories;
using Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data_management
{
    public class UserRepository : IUserRepository<User>
    {
        protected String filePath = @"C:\Users\Vlad Orbulescu\Documents\Facultate\DDD\Management Hotelier\Management Hotelier\MVC\Controllers\Infrastructure\Storage\Users.json";
        IFileManager<List<Object>> fileManager;
        IDataCheck dataCheck;
        IDataCaster<User> userDataCaster;
        IPersonRepository<Persoana> personRepository;
        private List<User> Useri { get; set; }
        public UserRepository()
        {
            var container = new Castle.Windsor.WindsorContainer();
            container.Register(Castle.MicroKernel.Registration.Component.For<IFileManager<List<object>>>().ImplementedBy<FileManager>());
            container.Register(Castle.MicroKernel.Registration.Component.For<IDataCheck>().ImplementedBy<DataCheck>());
            container.Register(Castle.MicroKernel.Registration.Component.For<IDataCaster<User>>().ImplementedBy<DataCaster<User>>());
            container.Register(Castle.MicroKernel.Registration.Component.For<IPersonRepository<Persoana>>().ImplementedBy<PersonRepository>());
            fileManager = container.Resolve<IFileManager<List<Object>>>();
            dataCheck = container.Resolve<IDataCheck>();
            userDataCaster = container.Resolve<IDataCaster<User>>();
            personRepository = container.Resolve<IPersonRepository<Persoana>>();
            Useri = getAllUsers();
        }
        public List<User> getAllUsers()
        {
            if(dataCheck.CheckFileEmpty(filePath))
            {
                return null;
            }
            else
            {
                List<Object> listaUseri = fileManager.ReadFromFile(filePath);
                Useri = userDataCaster.CastObjectListToTypeList(listaUseri);
                return Useri;
            }
        }

        public User GetUserByUserId(Guid id)
        {
            Useri = getAllUsers();
            return Useri.Find(x => x.UserId.Equals(id));
        }

        public User GetUserByUsernameAndPassword(string u, string p)
        {
            return Useri.Find(x => x.Username.Equals(u) && x.Password.Equals(p));
        }

        public bool DeleteUserByUserId(Guid id)
        {
            User user;
            if ((user = GetUserByUserId(id)) != null)
            {
                Useri.Remove(user);
                fileManager.WriteToFile(userDataCaster.CastTypeListToObjectList(Useri), filePath);
                if (personRepository.DeletePersonByUserId(id))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else return false;
        }
    }
}
