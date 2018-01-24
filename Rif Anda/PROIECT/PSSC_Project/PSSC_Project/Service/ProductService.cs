using PSSC_Project.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSSC_Project.Service
{
    class ProductService
    {
        ProductRepository pr = new ProductRepository();
        public void addProduct(string id, string name, string price, string quantity, string iduser, string idpickup)
        {
            pr.insertProduct(Int32.Parse(id), Int32.Parse(price), name, Int32.Parse(quantity), Int32.Parse(iduser), Int32.Parse(idpickup));
        }
    }
}
