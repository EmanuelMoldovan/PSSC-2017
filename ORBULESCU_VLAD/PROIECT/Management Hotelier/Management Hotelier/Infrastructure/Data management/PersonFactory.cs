using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Persons_layer.Models;
using Core_services.Repositories;
using Infrastructure.Interfaces;
using Infrastructure;

namespace Core_services.Factories
{
    class PersonRepository : IPersonFactory<Persoana>
    {
        private String filePath = @"C:\Users\Vlad Orbulescu\Documents\Facultate\DDD\Management Hotelier\Management Hotelier\Infrastructure\Storage\Persoane.json";
        IFileManager<List<Object>> fileManager;
        IDataCheck dataCheck;
        IPersonRepository<Persoana> persoanaRepository;
        IDataCaster<Persoana> persoanaDataCaster;
        public PersonRepository()
        {
            var container = new Castle.Windsor.WindsorContainer();
            container.Register(Castle.MicroKernel.Registration.Component.For<IPersonFactory<Persoana>>().ImplementedBy<Core_services.Factories.PersonRepository>());
            container.Register(Castle.MicroKernel.Registration.Component.For<IFileManager<List<Object>>>().ImplementedBy<FileManager>());
            container.Register(Castle.MicroKernel.Registration.Component.For<IDataCheck>().ImplementedBy<DataCheck>());
            container.Register(Castle.MicroKernel.Registration.Component.For<Core_services.Repositories.IPersonRepository<Persoana>>().ImplementedBy<Infrastructure.Data_management.PersonRepository>());
            container.Register(Castle.MicroKernel.Registration.Component.For<IDataCaster<Persoana>>().ImplementedBy<DataCaster<Persoana>>());
            fileManager = container.Resolve<IFileManager<List<Object>>>();
            dataCheck = container.Resolve<IDataCheck>();
            persoanaRepository = container.Resolve<IPersonRepository<Persoana>>();
            persoanaDataCaster = container.Resolve<IDataCaster<Persoana>>();
        }
        public Persoana CreatePersoana(Guid id, string n, string p, Adresa a, int v)
        {
            List<Persoana> aux = persoanaRepository.GetAllPersons();
            if (aux == null)
            {
                aux = new List<Persoana>();
            }
            Persoana persoanaNoua = new Persoana(id,n,p,a,v);
            aux.Add(persoanaNoua);
            fileManager.WriteToFile(persoanaDataCaster.CastTypeListToObjectList(aux), filePath);
            return persoanaNoua;
        }
    }
}
