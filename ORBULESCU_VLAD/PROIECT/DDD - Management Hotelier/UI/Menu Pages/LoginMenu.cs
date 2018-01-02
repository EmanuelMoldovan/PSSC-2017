using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Menu_Pages
{
    static class LoginMenu
    {
        public static List<String> Show()
        {
            Console.Clear();
            Console.WriteLine("Introduceti username:");
            String username = Console.ReadLine();
            Console.WriteLine("Introduceti parola:");
            String password = Console.ReadLine();
            List<String> parametrii = new List<String>();
            parametrii.Add(username);
            parametrii.Add(password);
            return parametrii;
        }
    }
}
