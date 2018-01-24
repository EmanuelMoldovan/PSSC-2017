using Core.Identity_and_access_layer.Models;
using Core.Persons_layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public interface IUserSession<T> where T : User
    {
        T Login(String u, String p);
        T Register(String u, String p, String e, String n, String pr, Adresa a, int v);
        bool RemoveUser(Guid id);
        Persoana GetLoggedInPerson();
    }
}
