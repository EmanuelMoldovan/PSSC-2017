using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSSC_Project.Entity
{
    class User
    {
        string name;
        int id;
        string phone;
        string city;

        public User(string name, int id, string phone, string city)
        {
            this.name = name;
            this.id = id;
            this.phone = phone;
            this.city = city;
        }
    }
}
