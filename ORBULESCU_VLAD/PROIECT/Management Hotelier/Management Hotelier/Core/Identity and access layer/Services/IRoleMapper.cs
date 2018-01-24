using Core.Identity_and_access_layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Identity_and_access_layer.Services
{
    internal interface IRoleMapper
    {
        Role.RoleTypes MapRole();
    }
}
