using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Lib
{
    public class LibrarieDuplicat : Exception
    {
        private string nume;
        public LibrarieDuplicat(string nume)
        {
            this.nume = nume;
            ToString();
        }
        public override string ToString()
        {
            return "Librarie existenta: " + nume;
        }
    }
}
