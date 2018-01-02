using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Identity_and_access_Layer.Models
{
     interface IRoleMapper
    {
        Role.RoleType mapRole();
    }
}
