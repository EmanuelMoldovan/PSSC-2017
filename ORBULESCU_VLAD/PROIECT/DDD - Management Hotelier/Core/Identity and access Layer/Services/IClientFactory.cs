using Core.Identity_and_access_Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Identity_and_access_Layer.Services
{
    public interface IClientFactory<T> where T : Client
    {
        T createClient(string u, string p, int roleNo, string n, string pr, int v, float tp);
    }
}
