using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public interface IDataValidation
    {
        bool CheckPasswordLength(String pass);
        bool CheckPasswordCharacters(String pass);
    }
}
