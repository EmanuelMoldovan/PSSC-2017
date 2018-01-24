using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    * Programul este fosit pentru a tine evidenta cartior din mai multe librarii
    * Utilizatorul poate:
    * -sa adauge o librarie
    * -sa vizualizeze toate librariile si adresa lor
    * -sa adauge o carte la o anumita librarie
    * -sa vzualizeze toate cartile ce se gasesc intr-o librarie
    * Pentru a comunica cu baza de date se foloseste LibraryRepository
*/

namespace PSSC_tema_2
{
    class Program
    {
        static void Main(string[] args)
        {
            LibraryService.LibraryService l = new LibraryService.LibraryService();
            string ch = "0";
            Console.WriteLine("----------------------------MENU-----------------------------------------");
            Console.WriteLine("1.Add library");
            Console.WriteLine("2.See all libraries");
            Console.WriteLine("3.Add book");
            Console.WriteLine("4.See all books in a library");
            Console.WriteLine("Option:");
            ch = Console.ReadLine();
            while (!ch.Equals("0"))
            {
                switch (ch) {
                    case "1":   Console.WriteLine("Library name:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Library city:");
                        string city = Console.ReadLine();
                        LibraryModel.Library lib = new LibraryModel.Library(name, city);
                        l.insertLibrary(lib);
                        Console.WriteLine("Library added");
                        break;
                    case "2":   Console.WriteLine("Library list:");
                        List<string> list = l.allLibraries();
                        Console.WriteLine("NAME          ||         CITY");
                        for (int i=0; i<list.Count; i+=2)
                        {
                            Console.WriteLine(list.ElementAt(i) + "  ||  " + list.ElementAt(i+1));
                        }
                        break;
                    case "3":
                        Console.WriteLine("Book title:");
                        string title = Console.ReadLine();
                        Console.WriteLine("Book author:");
                        string author = Console.ReadLine();
                        Console.WriteLine("Book library:");
                        string library = Console.ReadLine();
                        LibraryModel.Book book = new LibraryModel.Book(title, author, library);
                        l.addBook(book);
                        Console.WriteLine("Book added");
                        break;
                    case "4":
                        Console.WriteLine("Choose library:");
                        string libr = Console.ReadLine();
                        Console.WriteLine("Book list:");
                        Console.WriteLine("TITLE      ||     AUTHOR     ||       LIBRARY");

                        List<string> listbooks = l.allBooks(libr);
                        for (int i = 0; i < listbooks.Count; i += 3)
                        {
                            Console.WriteLine(listbooks.ElementAt(i) + "  ||  " + listbooks.ElementAt(i + 1) + "  ||  " + listbooks.ElementAt(i + 2));
                        }
                        break;
                    case "0":   break;
                }
                Console.WriteLine("----------------------------MENU-----------------------------------------");
                Console.WriteLine("0.Exit");
                Console.WriteLine("1.Add library");
                Console.WriteLine("2.See all libraries");
                Console.WriteLine("3.Add book");
                Console.WriteLine("4.See all books in a library");
                Console.WriteLine("Option:");
                ch = Console.ReadLine();
            }
        }
    }
}
