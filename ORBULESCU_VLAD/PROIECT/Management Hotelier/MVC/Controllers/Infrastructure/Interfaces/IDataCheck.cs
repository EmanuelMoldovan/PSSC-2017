using Core.Identity_and_access_layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Interfaces
{
    public interface IDataCheck
    {
        bool CheckDuplicateUsername(String username, List<User> users);
        bool CheckFileEmpty(String filePath);
    }
}
