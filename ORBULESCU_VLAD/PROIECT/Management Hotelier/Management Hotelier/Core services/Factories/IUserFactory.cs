using Core.Identity_and_access_layer.Models;
using Core.Persons_layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Identity_and_access_layer
{
    public interface IUserFactory<T> where T : User
    {
        T CreateUser(String u, String p, String e, int roleNo, String n, String pr, Adresa a, int v);
    }
}
