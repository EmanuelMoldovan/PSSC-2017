using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSSC_Project.Entity
{
    class Pickup
    {
        string city;
        string street;
        int nr;
        int id;
        string name;

        public Pickup(string city, string street, int nr, int id, string name)
        {
            this.city = city;
            this.street = street;
            this.nr = nr;
            this.id = id;
            this.name = name;
        }
    }
}
