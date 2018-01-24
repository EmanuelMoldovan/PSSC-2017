using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSSC
{
    public class Hotel
    {
        public List<Floor> floors;
        public Hotel(List<Floor>floors)
        {
            this.floors = floors;
        }
    }
}
