using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PSSCWeb.Models;
using PSSC;
using PSSC.Models;
using PSSC.Models.DTO;
using PSSC.Repositories;

namespace PSSCWeb.Controllers
{
    public class AccountController : Controller
    {
        private string path = @"D:\Anul4\PSSC\Proiect\Proiect\PSSCWeb\";
        private ReadRepository _readRepo;
        private WriteRepository _writeRepo;

        public AccountController()
        {
            _readRepo = new ReadRepository(path);
            _writeRepo = new WriteRepository(path);
        }
        // GET: Account
        public ActionResult Index()
        {

            return View();
            //using (OurDbContext db = new OurDbContext())
            //{
            //    return View(db.userAccount.ToList());
            //}
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(UserAccount account)
        {
            if (ModelState.IsValid)
            {
                var client = new ClientDTO()
                {
                    Id = Guid.NewGuid(),
                    LastName = account.LastName,
                    FirstName = account.FirstName,
                    Username = account.Username,
                    Password = account.Password
                };
                _writeRepo.adaugaClient(client);
                
                ModelState.Clear();
                ViewBag.Message = account.FirstName + " " + account.LastName + " succesfully registered"; 
            }
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(UserAccount user)
        {
            var found = false;
            var clienti = _readRepo.CitesteClienti();
 
                if (clienti != null)
                {
                    foreach (ClientDTO client in clienti)
                    {
                        if (client.Username.Equals(user.Username))
                        {
                            found = true;
                            if (client.Password.Equals(user.Password))
                            {
                                Session["UserID"] = client.Id;
                                Session["Username"] = client.Username;
                                return RedirectToAction("LoggedIn", "Account");
                            }
                            else
                            {
                                ModelState.Clear();
                                ViewBag.Message = "Password is wrong";
                                //ModelState.AddModelError("", "Password is wrong");
                            }
                        }
                    }
                    if (found == false)
                    {
                        ModelState.Clear();
                        ViewBag.Message = "User not registered";
                        //ModelState.AddModelError("", "User not registered");
                    }
                }
            
            
            return View();
        }

        
        public ActionResult LoggedIn()
        {
            if (Session["UserID"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        public ActionResult LogOut()
        {
            Session.Abandon();
            return RedirectToAction("Index", "Home");
        }
    }
}