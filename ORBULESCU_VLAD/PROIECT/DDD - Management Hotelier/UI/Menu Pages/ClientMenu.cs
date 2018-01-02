using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Menus;

namespace UI.Menu_Pages
{
    static class ClientMenu
    {
        public static void Show()
        {
            Console.Clear();
            Console.WriteLine("Aceasta este pagina principala pentru clienti!");
            Console.WriteLine("Alegeti o actiune:");
            Console.WriteLine("1.Logout");
            while(true)
            {
                switch(Console.ReadLine())
                {
                    case "1": MenuStart.Show(); return;
                    case "2": break;
                    default: Console.WriteLine("Comanda eronata!"); break;
                }
            }
        }
    }
}
