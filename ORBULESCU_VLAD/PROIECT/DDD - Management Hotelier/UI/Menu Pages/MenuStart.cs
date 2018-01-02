using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Menus
{
    static class MenuStart
    {
        public static void Show()
        {
            Console.Clear();
            Console.WriteLine("1.Login");
            Console.WriteLine("2.Register");
            Console.WriteLine("Press 0 to exit ...");
            Console.WriteLine("Care este optiunea dvs ? ");
        }
    }
}
