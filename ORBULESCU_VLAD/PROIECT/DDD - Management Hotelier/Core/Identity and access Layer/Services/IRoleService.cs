using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Identity_and_access_Layer.Services
{
    public interface IRoleService<T> where T : Role
    {
        T getUserRole(User u);
    }
}
