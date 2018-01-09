using FastFood.Domain;
using FastFood.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FastFood.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddCategory()
        {

            return View("AddCategory", new Categorie());
        }

        [HttpPost]
        public ActionResult AddCategory(Categorie categorie)
        {
            var categoryRepository = new CategoriiRepository();
            categoryRepository.AdaugaCategorie(categorie);
            return View();
        }
    }
}