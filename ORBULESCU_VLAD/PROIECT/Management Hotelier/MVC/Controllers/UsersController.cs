using Application.Services;
using Core.Identity_and_access_layer;
using Core.Identity_and_access_layer.Models;
using Core.Persons_layer.Models;
using Infrastructure.Exceptions;
using Infrastructure.Services;
using MVC.Controllers.Infrastructure.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers 
{
    public class UsersController : Controller
    {
        UserService service;
        private static IDataValidation _validation;
        

        public UsersController()
        {
            service = new UserService(_validation);
        }

        public ActionResult Login(User u)
        {
            try
            {
                User loggedInUser = service.Login(u.Username, u.Password);
                if (loggedInUser != null)
                {
                    Request.Cookies.Add(new HttpCookie("UserId", loggedInUser.UserId.ToString()));
                }
                return View("~/Views/Application/Main.cshtml", service.GetLoggedInPerson());
            }
            catch (WrongCredentialsException ex)
            {
                ViewBag.Message = string.Format("Wrong credentials, pease try again!");
                return View("~/Views/Home/Index.cshtml");
            }
        }

        public ActionResult Register(UserPersonTuple model)
        {
            try
            {
                service.Register(model.ModelUser.Username, model.ModelUser.Password, model.ModelUser.EmailAddress, model.ModelPersoana.Nume, model.ModelPersoana.Prenume, new Adresa(), model.ModelPersoana.Varsta);
                ViewBag.Message = string.Format("Success!");
                return View("~/Views/Home/Index.cshtml");
            }
            catch(Exception ex)
            {
                if (ex is PasswordTooShortException)
                    ViewBag.Message = string.Format("Password is too short!");
                else if (ex is PasswordTooLongException)
                    ViewBag.Message = string.Format("Password is too long!");
                else if (ex is PasswordCharsNotMetException)
                    ViewBag.Message = string.Format("Password must have an uppercase, a lowercase and a number!");
                else if (ex is UsernameExistsException)
                    ViewBag.Message = string.Format("Username already exists! Please chose another one.");
                return View("~/Views/Home/Index.cshtml");
            }
        }
    }
}