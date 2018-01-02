using Core.Identity_and_access_Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Identity_and_access_Layer.Services
{
    public interface IClientRepository<T> where T : Client
    {
        List<T> getAllClients();
        T getClientByUserId(Guid id);
        T getClientByUsernameAndPassWord(String u, String p);
        void removeClientByUserId(Guid id);
    }
}
