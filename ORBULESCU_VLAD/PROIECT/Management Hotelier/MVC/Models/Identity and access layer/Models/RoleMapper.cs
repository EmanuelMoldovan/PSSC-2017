using Core.Identity_and_access_layer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Identity_and_access_layer.Models
{
    class RoleMapper : IRoleMapper
    {
        private int _RoleNo;

        public RoleMapper(int roleNo)
        {
            _RoleNo = roleNo;
        }

        public Role.RoleTypes MapRole()
        {
            switch (_RoleNo)
            {
                case 0: return Role.RoleTypes.Client;
                case 1: return Role.RoleTypes.Receptioner;
                case 2: return Role.RoleTypes.Manager;
                default: return 0;
            }
        }
    }
}
