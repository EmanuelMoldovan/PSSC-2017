using Infrastructure.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    class FileManager : IFileManager<List<Object>>
    {
        IDataCheck dataCheck;
        public FileManager()
        {
            var container = new Castle.Windsor.WindsorContainer();
            container.Register(Castle.MicroKernel.Registration.Component.For<IDataCheck>().ImplementedBy<DataCheck>());
            dataCheck = container.Resolve<IDataCheck>();
        }

        public List<object> ReadFromFile(string filePath)
        {
                string listaObiecteJson = File.ReadAllText(filePath);
                var listaObiecte = JsonConvert.DeserializeObject<List<object>>(listaObiecteJson);
                return listaObiecte;
        }

        public void WriteToFile(List<object> listaObiecte, string filePath)
        {
            var test = JsonConvert.SerializeObject(listaObiecte);
            File.WriteAllText(filePath, JsonConvert.SerializeObject(listaObiecte));
        }
    }
}
