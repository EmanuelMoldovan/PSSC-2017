using FastFood.Domain;
using FastFood.Models;
using FastFood.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FastFood.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult AddProduct()
        {
            var categoriiRepository = new CategoriiRepository();
            var model = new AddProductModel()
            {
                Product = new Produs() { Categorie = new Categorie() },
                Categorii = new List<object>()
            };

            categoriiRepository.GetCategorii().ForEach(c => { model.Categorii.Add(new { value = c.Id, text = c.Nume });});

            return View("AddProduct", model);
        }

        [HttpPost]
        public ActionResult AddProduct(AddProductModel model)
        {
            var produseRepository = new ProduseRepository();
            produseRepository.AdaugaProdus(model.Product, model.IdCategorie);
            return View("Index","Food");
        }
    }
}