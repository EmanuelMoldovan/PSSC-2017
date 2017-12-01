using System.Collections.Generic;
using Modele.Generic;
using Modele.Librarie;
using System.IO;
using Newtonsoft.Json;

namespace Repositories.Lib
{
    public class LibrarieRepos : ILibrarieRepos
    {
        private static List<Librarie> lista_librarii= new List<Librarie>();
        public LibrarieRepos() { }
        public void Adauga_librarie(Librarie librarie)
        {
            var f = lista_librarii.Find(l => l.Equals(librarie));
            if (f == null)
                lista_librarii.Add(librarie);
            else
                throw new LibrarieDuplicat(librarie.nume.Numesimplu);
        }
        public void Actualizeaza_librarie(Librarie librarie)
        {
            using (StreamWriter file = File.CreateText(@"C:\Users\Bianca\Desktop\f.txt"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, lista_librarii);
            }
        }

        public string Inchide_librarie(Text nume)
        {
            var f = lista_librarii.Find(l => l.nume.Equals(nume));
            if (f != null)
            {
                lista_librarii.Remove(f);
                return "Inchis";
            }
            else
                return "Librarie inexistenta";

        }
    }
}
