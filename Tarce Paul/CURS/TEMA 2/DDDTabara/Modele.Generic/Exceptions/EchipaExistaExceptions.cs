using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.Generic.Exceptions
{
    public class EchipaExistaExceptions : Exception
    {
        public EchipaExistaExceptions(string message) : base(message)
        {
            Console.WriteLine("Echipa exista!!!");
        }
    }
}
