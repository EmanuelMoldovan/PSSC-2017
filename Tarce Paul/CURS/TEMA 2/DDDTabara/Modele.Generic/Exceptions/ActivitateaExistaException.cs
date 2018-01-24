using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.Generic.Exceptions
{
    public class ActivitateaExistaException : Exception
    {
        public ActivitateaExistaException(string message) : base(message)
        {
            Console.WriteLine("Activitatea exista!!!");
        }
    }
}
