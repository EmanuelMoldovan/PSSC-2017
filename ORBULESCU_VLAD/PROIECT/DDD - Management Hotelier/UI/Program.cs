using Application.Services;
using Castle.Windsor;
using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Menu_Pages;
using UI.Menus;
using UI.Services;

namespace UI
{
    class Program
    {
        static IUserSession<User> userService;
        static void Main(string[] args)
        {
            SetUpDependencies();
            StartApplication();
        }

        internal static void SetUpDependencies()
        {
            var container = new WindsorContainer();
            container.Register(Castle.MicroKernel.Registration.Component.For<IUserSession<User>>().ImplementedBy<UserService>());
            userService = container.Resolve<IUserSession<User>>();
        }

        internal static void StartApplication()
        {
            Console.WriteLine("Bine ati venit!");
            Console.WriteLine("Va rugam sa alegeti o optiune pentru a continua:");
            MenuStart.Show();
            while(true)
            {
                switch (Console.ReadLine())
                {
                    case "0": return;
                    case "1":
                        var parametriiLogin = LoginMenu.Show();
                        userService.login(parametriiLogin.ElementAt(0), parametriiLogin.ElementAt(1));
                        break;
                    case "2":
                        var parametriiRegister = MenuRegister.Show();
                            userService.register(parametriiRegister.ElementAt(0), parametriiRegister.ElementAt(1), 0, parametriiRegister.ElementAt(2),
                                parametriiRegister.ElementAt(3), Convert.ToInt32(parametriiRegister.ElementAt(4)), 0);
                            MenuStart.Show();
                        break;
                    default: Console.WriteLine("Comanda ernoata, va rugam incercati din nou."); break;
                }
            }
        }
    }
}
