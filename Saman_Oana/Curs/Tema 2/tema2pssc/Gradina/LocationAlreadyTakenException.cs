using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Gradina
{
    public class LocationAlreadyTakenException : SystemException
    {
        public LocationAlreadyTakenException(string message)
            : base(message)
        {
        }
    }
}
