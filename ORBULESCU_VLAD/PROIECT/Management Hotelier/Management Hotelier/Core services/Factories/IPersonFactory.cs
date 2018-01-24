using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Persons_layer.Models;

namespace Core_services.Factories
{
    public interface IPersonFactory<T> where T : Persoana
    {
        T CreatePersoana(Guid id, String n, String p, Adresa a, int v);
    }
}
