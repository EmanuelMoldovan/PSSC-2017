using Core.Identity_and_access_layer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Identity_and_access_layer.Models
{
    public class User
    {
        public Guid UserId { get ; set; }
        public String Username { get; set; }
        public String Password { get; set; }
        public String EmailAddress { get; set; }
        public byte[] PasswordSalt { get; set; } //TODO
        public Role.RoleTypes Tip { get; set; }
        internal IRoleMapper roleMapper;

        public User(String u, String p, String e, int roleNo)
        {
            UserId = GuidGenerator.Generate();
            Username = u;
            Password = p;
            EmailAddress = e;
            roleMapper = new RoleMapper(roleNo);
            Tip = roleMapper.MapRole();
        }
    }
}
