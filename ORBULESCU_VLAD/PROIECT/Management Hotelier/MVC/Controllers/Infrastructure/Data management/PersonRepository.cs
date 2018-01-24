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
    public class PersonRepository : IPersonRepository<Persoana>
    {
        protected String filePath = @"C:\Users\Vlad Orbulescu\Documents\Facultate\DDD\Management Hotelier\Management Hotelier\MVC\Controllers\Infrastructure\Storage\Persoane.json";
        IFileManager<List<Object>> fileManager;
        IDataCheck dataCheck;
        IDataCaster<Persoana> userDataCaster;
        private List<Persoana> Persoane { get; set; }

        public PersonRepository()
        {
            var container = new Castle.Windsor.WindsorContainer();
            container.Register(Castle.MicroKernel.Registration.Component.For<IFileManager<List<object>>>().ImplementedBy<FileManager>());
            container.Register(Castle.MicroKernel.Registration.Component.For<IDataCheck>().ImplementedBy<DataCheck>());
            container.Register(Castle.MicroKernel.Registration.Component.For<IDataCaster<Persoana>>().ImplementedBy<DataCaster<Persoana>>());
            fileManager = container.Resolve<IFileManager<List<Object>>>();
            dataCheck = container.Resolve<IDataCheck>();
            userDataCaster = container.Resolve<IDataCaster<Persoana>>();
            Persoane = GetAllPersons();
        }

        public List<Persoana> GetAllPersons()
        {
            if (dataCheck.CheckFileEmpty(filePath))
            {
                return null;
            }
            else
            {
                List<Object> listaPersoane = fileManager.ReadFromFile(filePath);
                Persoane = userDataCaster.CastObjectListToTypeList(listaPersoane);
                return Persoane;
            }
        }

        public Persoana GetPersonByUserId(Guid id)
        {
            Persoane = GetAllPersons();
            return Persoane.Find(x => x.UserId == id);
        }

        public bool DeletePersonByUserId(Guid id)
        {
            Persoana persoana;
            if ((persoana = GetPersonByUserId(id)) != null)
            {
                Persoane.Remove(persoana);
                fileManager.WriteToFile(userDataCaster.CastTypeListToObjectList(Persoane), filePath);
                return true;
            }
            else return false;
        }
    }
}
