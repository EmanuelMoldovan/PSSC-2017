using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryService
{
    public class LibraryService
    {
        public void insertLibrary(LibraryModel.Library l)
        {
            LibraryRepository.Library repo = new LibraryRepository.Library();
            repo.AddLibrary(l);
        }

        public List<string> allLibraries()
        {
            LibraryRepository.Library repo = new LibraryRepository.Library();
            return repo.listLibraries();
        }

        public void addBook(LibraryModel.Book b)
        {
            LibraryRepository.Library repo = new LibraryRepository.Library();
            repo.AddBook(b);
        }

        public List<string> allBooks(string library)
        {
            LibraryRepository.Library repo = new LibraryRepository.Library();
            return repo.listBooks(library);
        }
    }
}
