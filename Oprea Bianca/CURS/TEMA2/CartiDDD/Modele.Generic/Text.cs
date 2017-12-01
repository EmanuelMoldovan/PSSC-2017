using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.Generic
{
    public class Text
    {
        private string nume_utilizator;
        public string Numesimplu
        {
            get { return nume_utilizator; }
        }
        public Text()
        { }
        public Text(string nume)
        {
            Contract.Requires<ArgumentNullException>(nume != null, "Numele nu poate fi null");
            Contract.Requires(!string.IsNullOrEmpty(nume), "Numarul necesita caractere");
            nume_utilizator = nume;
        }
        
        public override string ToString()
        {
            return nume_utilizator;
        }
        public override int GetHashCode()
        {
            return Numesimplu.GetHashCode();
        }
    }
}
