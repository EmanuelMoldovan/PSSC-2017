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
    public class FoodController : Controller
    {
        // GET: Food
        public ActionResult Index(int CategoryId)
        {
            var categorie = new CategoriiRepository();
            var produseRepository = new ProduseRepository();
            var produse = produseRepository.GetProduseCategorie(categorie.GetCategorie(CategoryId));

            return View(produse);
        }

        [HttpPost]
        public ActionResult SingleBuy(int SingleProdId)
        {
            var produseRepository = new ProduseRepository();
            var produs = produseRepository.GetProdus(SingleProdId);
            return View(produs);
        }

        public ActionResult Checkout(int SingleProdId)
        {
            var produseRepository = new ProduseRepository();
            var categorie = new CategoriiRepository();
            var checkoutRepository = new CheckoutRepository();

            var produs = produseRepository.GetProdus(SingleProdId);

            var checkout = new CheckoutModel();
            checkout.Produse = new List<Produs>();
            checkout.Produse.Add(produs);

            return View(checkout);
        }

        [HttpPost]
        public ActionResult Checkout(CheckoutModel checkoutModel)
        {
            //trebuie pus un hidden sau cu viewbag pentru produse (de mai sus)

            var produseRepository = new ProduseRepository();
            var categorie = new CategoriiRepository();
            var checkoutRepository = new CheckoutRepository();

            checkoutRepository.AdaugaCheckout(checkoutModel);
            
            var produse = produseRepository.GetProduseCategorie(categorie.GetCategorie(checkoutModel.Produse.FirstOrDefault().Categorie.Id));

            return View("Index", "Food", produse);
        }

        

        // GET: Food/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Food/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Food/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Food/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Food/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Food/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Food/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
