using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSSC_Project.Entity
{
    class Product
    {
        string name;
        int id;
        int quantity;
        int price;

        public Product(string name, int id, int quantity, int price)
        {
            this.name = name;
            this.id = id;
            this.quantity = quantity;
            this.price = price;
        }
    }
}
