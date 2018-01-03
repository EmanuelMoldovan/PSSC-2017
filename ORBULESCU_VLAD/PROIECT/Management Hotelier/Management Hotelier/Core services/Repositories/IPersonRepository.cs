using Core.Persons_layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_services.Repositories
{
    public interface IPersonRepository<T> where T : Persoana
    {
        T GetPersonByUserId(Guid id);
        List<T> GetAllPersons();
    }
}
