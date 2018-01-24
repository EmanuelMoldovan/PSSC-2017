using Models.Generic;
using System.Diagnostics.Contracts;

namespace Models
{
    public class CodPostal
    {
        private PlainText _cod;
        public PlainText Cod
        {
            get
            {
                return _cod;
            }
        }

        public CodPostal(PlainText cod)
        {
            Contract.Requires(cod.Text.Length == 6, "Codul postal trebuie sa contina 6 caractere!");
            _cod = cod;
        }
    }
}