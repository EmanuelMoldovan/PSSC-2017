using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.Magazin
{
   public class LocationAlreadyTakenException: System.Exception
    {
        public LocationAlreadyTakenException(string message)
             : base(message)
         {
 
         }
    }
}
