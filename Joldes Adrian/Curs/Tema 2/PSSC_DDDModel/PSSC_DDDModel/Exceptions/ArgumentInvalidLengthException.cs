using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSSC_DDDModel.Exceptions
{
    class ArgumentInvalidLengthException:ArgumentException
    {
        public ArgumentInvalidLengthException(string message)
            : base(message)
        {

        }
    }
}
