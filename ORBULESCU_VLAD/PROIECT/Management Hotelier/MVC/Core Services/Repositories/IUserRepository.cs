using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Identity_and_access_layer.Models;

namespace Core_services.Repositories
{
    public interface IUserRepository<T> where T : User
    {
        List<T> getAllUsers();
        T GetUserByUserId(Guid id);
        T GetUserByUsernameAndPassword(String u, String p);
        bool DeleteUserByUserId(Guid id);
    }
}
