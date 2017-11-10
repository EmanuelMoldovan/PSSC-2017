using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modele.Librarie;
using Modele.Generic;
using Repositories.Lib;
using System.Collections.ObjectModel;

namespace CartiDDD
{
    class Program
    {
        static void Main(string[] args)
        {
            var librarie = new LibrarieFactory();
            Librarie lib1 = librarie.Creaza("Librarie1");
            Librarie lib2 = LibrarieFactory.instance.Creaza("Librarie2");
            LibrarieRepos librepos = new LibrarieRepos();
            Console.WriteLine(lib1.ToString() + "  " + "librarie adaugata");
            Console.WriteLine(lib2.ToString() + "  " + "librarie adaugata");
            librepos.Adauga_librarie(lib1);
            librepos.Adauga_librarie(lib2);
            librepos.Actualizeaza_librarie(lib1);
            librepos.Actualizeaza_librarie(lib2);

            Text titlu1 = new Text("Titlu1");
            ISSN issn1 = new ISSN("0923-234-A34V");
            Gen_tip gent1 = Gen_tip.dramatic;
            Gen_continut genc1 = Gen_continut.Aventură;
            Text titlu2 = new Text("Titlu2");
            ISSN issn2 = new ISSN("0923-234-A34V");
            Gen_tip gent2 = Gen_tip.epic;
            Gen_continut genc2 = Gen_continut.Istoric;
            Carte carte1 = new Carte(issn1, titlu1, gent1, genc1);
            Carte carte2 = new Carte(issn2, titlu2, gent2, genc2);
            Carti carti = new Carti();
            carti.Adauga_carte(carte1);
            carti.Adauga_carte(carte2);
            Console.WriteLine("Lista carti " + carti.ToString());

            Text nume_utilizator = new Text("Nume_utilizator1");
            AdresaContact adresa = new AdresaContact("Email1");
            Utilizator cititor = new Utilizator(nume_utilizator, adresa);
            cititor.Alege_carte(carte1);
            Console.WriteLine(carte1.titlu + " " + carte1.stare);
            string s = cititor.Cauta_carte(titlu2, carti);
            Console.WriteLine(s);
            cititor.Restituie_carte(carte1);
            Console.WriteLine(carte1.titlu + " " + carte1.stare);

            lib1.Adauga_membru(cititor);
            Console.WriteLine(lib1.ToString() + " " + cititor.ToString());
            lib2.Adauga_membru(cititor);
            Console.WriteLine(lib2.ToString() + " " + cititor.ToString());

            ReadOnlyCollection<Utilizator> lista_utiliz_roc = lib1.cititori;
            List<Utilizator> lista_utiliz = new List<Utilizator>(lista_utiliz_roc);
            Librarie lib3 = LibrarieFactory.instance.Creaza("Librarie3", carti, lista_utiliz);
            Console.WriteLine(lib3.ToString() + " " + "librarie adaugata");
            librepos.Adauga_librarie(lib3);
            librepos.Actualizeaza_librarie(lib3);
            Console.ReadLine();
        }
    }
}
