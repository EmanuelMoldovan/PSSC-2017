using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Persons_layer.Models
{
    public class Adresa
    {
        public String Strada { get; set; }
        public int Numar { get; set; }
        public String Tara { get; set; }
        public String Oras { get; set; }
        public String Judet { get; set; }

        public Adresa(String s, int n, String t, String o, String j)
        {
            Strada = s;
            Numar = n;
            Tara = t;
            Oras = o;
            Judet = j;
        }

        public Adresa() { }

        public override string ToString()
        {
            return Strada + " nr." + Numar + ", " + Tara + ", " + Oras + ", " + Judet;
        }
    }
}
