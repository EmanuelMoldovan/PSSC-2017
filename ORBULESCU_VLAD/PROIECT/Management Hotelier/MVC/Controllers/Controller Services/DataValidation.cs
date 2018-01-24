using Application.Services;
using Infrastructure.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    class DataValidation : IDataValidation
    {
        public bool CheckPasswordCharacters(string pass)
        {
            if (pass.Any(char.IsUpper) &&
                   pass.Any(char.IsLower) &&
                   pass.Any(char.IsDigit))
                return true;
            else throw new PasswordCharsNotMetException();
        }

        public bool CheckPasswordLength(string pass)
        {
            if (pass.Length < 4) { throw new PasswordTooShortException(); }
            else if (pass.Length > 10) { throw new PasswordTooLongException(); }
            else if (pass.Length >= 4 && pass.Length <= 10) return true;
            return false;
        }
    }
}
