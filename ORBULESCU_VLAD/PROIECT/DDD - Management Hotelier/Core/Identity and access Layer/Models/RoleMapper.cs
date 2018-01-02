using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Identity_and_access_Layer.Models;

namespace Core.Identity_and_access_Layer
{
    class RoleMapper : IRoleMapper
    {
        private int _RoleNo;
        public RoleMapper(int roleNo)
        {
            _RoleNo = roleNo;
        }

        public Role.RoleType mapRole()
        {
            switch(_RoleNo)
            {
                case 0: return Role.RoleType.Client;
                case 1: return Role.RoleType.Receptioner;
                case 2: return Role.RoleType.Manager;
                default: return 0;
            }
        }
    }
}
