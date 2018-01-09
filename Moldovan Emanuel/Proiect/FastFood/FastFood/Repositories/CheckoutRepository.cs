using FastFood.Domain;
using FastFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FastFood.Repositories
{
    public class CheckoutRepository
    {
        public void AdaugaCheckout(CheckoutModel checkout)
        {
            using (var model = new Entities())
            {
                model.Comenzi.Add(checkout.Order);
                model.SaveChanges();
            }
        }

        public List<Comanda> GetOrders()
        {
            using (var model = new Entities())
            {
                return model.Comenzi.Include("Produs").ToList();
            }
        }

        public Comanda GetOrder(int id)
        {
            using (var model = new Entities())
            {
                return model.Comenzi.Include("Produs").Where(w => w.Id == id).FirstOrDefault();
            }
        }
    }
}