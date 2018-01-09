using FastFood.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FastFood.Models
{
    public class AddProductModel
    {
        public Produs Product{ get; set; }

        public List<Object> Categorii { get; set; }

        public int IdCategorie { get; set; }
    }
}