using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Menu_Pages
{
    static class MenuRegister
    {
        public static List<String> Show()
        {
            Console.Clear();
            Console.WriteLine("Va rugam introduceti toate datele care urmeaza sa vi se ceara:");
            Console.WriteLine("Introduceti username-ul dorit:");
            var username = Console.ReadLine();
            Console.WriteLine("Introduceti parola dorita:");
            var password = Console.ReadLine();
            Console.WriteLine("Introduceti numele dvs:");
            var nume = Console.ReadLine();
            Console.WriteLine("Introduceti prenumele dvs:");
            var prenume = Console.ReadLine();
            Console.WriteLine("Introduceti varsta dvs:");
            var varsta = Console.ReadLine();
            List<String> listaParametrii = new List<String>();
            listaParametrii.Add(username);
            listaParametrii.Add(password);
            listaParametrii.Add(nume);
            listaParametrii.Add(prenume);
            listaParametrii.Add(varsta);
            return listaParametrii;
        }
    }
}
