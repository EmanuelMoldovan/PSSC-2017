using Core;
using Core.Identity_and_access_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public interface IUserSession<User> : Core.Identity_and_access_Layer.Services.IRoleService<Role>
    {
        void login(String U, String P);
        void logout();
        void register( String u, String p, int roleNo, String n, String pr, int v, float tp);
    }
}
