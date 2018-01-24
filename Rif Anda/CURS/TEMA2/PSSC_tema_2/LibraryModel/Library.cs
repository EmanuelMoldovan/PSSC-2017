using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryModel
{
    public class Library
    {
        public string Name { get; internal set; }
        public string City { get; internal set; }
        private List<Book> BookList;

        public Library(string name, string city)
        {
            Name = name;
            City = city;
            BookList = new List<Book>();
        }

        public string getName()
        {
            return Name;
        }

        public string getCity()
        {
            return City;
        }
    }
}
