using Core.Identity_and_access_Layer;
using Core.Identity_and_access_Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class User
    {
        public Guid Id { get; set; }
        public String Username { get; set; }
        public String Password { get; set; }
        public Role.RoleType Tip { get; set; }

        internal User(Guid id, String u, String p, int roleNo, IRoleMapper roleMapper)
        {
            Id = id;
            Username = u;
            Password = p;
            roleMapper = new RoleMapper(roleNo);
            Tip = roleMapper.mapRole();
        }
    }
}
