using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PSSCWeb.Models;
using PSSC.Repositories;
using PSSC.Models.DTO;

namespace PSSCWeb.Controllers
{
    public class HomeController : Controller
    {
        private string path = @"D:\Anul4\PSSC\Proiect\Proiect\PSSCWeb\";
        private ReadRepository _readRepo;
        private WriteRepository _writeRepo;

        public HomeController()
        {
            _readRepo = new ReadRepository(path);
            _writeRepo = new WriteRepository(path);
        }
        public ActionResult Index()
        {
            
            return View();
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
        private static ContModel GenereazaContModelView(ContDTO cont)
        {
            return new ContModel()
            {
                Id = cont.Id,
                AccountNumber = cont.AccountNumber,
                Currency = cont.Currency,
                MoneyDeposited = cont.MoneyDeposited,
                User = cont.User,
                myAction = cont.ActionList
                
            };
        }

        private static ActionModel GenereazaActionModelView(ActionDTO action)
        {
            return new ActionModel()
            {
                Id = action.Id,
                DateForAction = action.DateForAction,
                _ActionType = (ActionTypeWeb)action._ActionType,
                Money = action.Money
            };
        }

        public ActionResult Deposit(Guid id)
        {
            return View(id);
        }

        [HttpPost]
        public ActionResult Deposit(Guid id,string s)
        {
            if (Session["UserID"] != null)
            {
                float sumToDeposit = Convert.ToInt64(Request["txtAmount"].ToString());
                ActionDTO action = new ActionDTO()
                {
                    Money = sumToDeposit,
                    DateForAction = DateTime.Now,
                    _ActionType = PSSC.Models.ActionType.Deposit,
                    Id = Guid.NewGuid()

                };
                _writeRepo.adaugaAction(action, id, Session["Username"].ToString());
            }
            return RedirectToAction("ShowAccounts");
        }

        public ActionResult Withdraw(Guid id)
        {
            if (Session["UserID"] != null)
                return View();
            else
                return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Withdraw(Guid id,string s)
        {
            bool ok = true;
            if (Session["UserID"] != null)
            {
                float sumToWithdraw = Convert.ToInt64(Request["txtAmount"].ToString());
                ActionDTO action = new ActionDTO()
                {
                    Money = sumToWithdraw,
                    DateForAction = DateTime.Now,
                    _ActionType = PSSC.Models.ActionType.Withdraw,
                    Id = Guid.NewGuid()
                };
                ok = _writeRepo.adaugaAction(action, id, Session["Username"].ToString());
            }
            if (!ok)
            {
                ViewBag.Message = "Not enough money to withdraw in this account";
                return View("ShowAccounts");
            }
            return RedirectToAction("ShowAccounts");
        }

        public ActionResult Delete(Guid id)
        {
            _writeRepo.deleteAccount(id,Session["Username"].ToString());
            return RedirectToAction("ShowAccounts");
        }

        public ActionResult History(Guid id)
        {
            var actionList = _readRepo.CitesteActiuni(id, Session["Username"].ToString());
            var thisActionList = new List<ActionModel>();
            if (actionList != null)
            {
                foreach (ActionDTO action in actionList)
                {
                    thisActionList.Add(GenereazaActionModelView(action));
                }
                return View("History", thisActionList);
            }
            
            return View();
        }

        public ActionResult Edit(Guid id)
        {
            Guid myId = id;
            return View();
        }
        public ActionResult ShowAccounts()
        {
            if (Session["UserID"] != null)
            {
                var userAccounts = _readRepo.CitesteConturi(Session["Username"].ToString());
                if (userAccounts != null)
                {
                    List<ContModel> contModelList = new List<ContModel>();
                    foreach (ContDTO cont in userAccounts)
                    {
                        contModelList.Add(GenereazaContModelView(cont));
                    }
                    return View("ShowAccounts", contModelList);
                }
                else
                {
                    return View();
                }

            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        public ActionResult AddAccount()
        {
            if (Session["UserID"] != null)
            {
                return View();
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult AddAccount(ContModel cont)
        {
            if (ModelState.IsValid)
            {
                var newAccount = new ContDTO()
                {
                    Id = Guid.NewGuid(),
                    AccountNumber = cont.AccountNumber,
                    Currency = cont.Currency,
                    MoneyDeposited = cont.MoneyDeposited,
                    User = Session["Username"].ToString()
                };
                _writeRepo.adaugaCont(newAccount,Session["Username"].ToString());
                var userAccounts = _readRepo.CitesteConturi(Session["Username"].ToString());

                ModelState.Clear();
                if (userAccounts != null)
                {
                    List<ContModel> contModelList = new List<ContModel>();
                    foreach (ContDTO UserCont in userAccounts)
                    {
                        contModelList.Add(GenereazaContModelView(UserCont));
                    }
                    return View("ShowAccounts", contModelList);
                }
            }
            return View();
        }
    }
}