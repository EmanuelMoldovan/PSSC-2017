using FastFood.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FastFood.Models
{
    public class CheckoutModel
    {
        public List<Produs> Produse { get; set; }

        public Comanda Order { get; set; }
    }
}