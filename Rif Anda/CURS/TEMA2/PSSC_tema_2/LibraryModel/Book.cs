using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryModel
{
    public class Book
    {
        public string Title { get; internal set; }
        public string Author { get; internal set; }
        public string Library { get; internal set; }

        public Book(string title, string author, string library)
        {
            Title = title;
            Author = author;
            Library = library;
        }

        public string getTitle()
        {
            return Title;
        }

        public string getAuthor()
        {
            return Author;
        }

        public string getLibrary()
        {
            return Library;
        }
    }
}
