using FastFood.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FastFood.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var categoriiRepository = new CategoriiRepository();
            var categorii = categoriiRepository.GetCategorii();

            return View(categorii);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}