using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Persons_layer.Models
{
    public class Persoana
    {
        public Guid UserId;
        public String Nume { get; set; }
        public String Prenume { get; set; }
        public Adresa Adresa { get; set; }
        public int Varsta { get; set; }

        public Persoana() { }
        
        public Persoana (Guid id, String n, String p, Adresa a, int v)
        {
            UserId = id;
            Nume = n;
            Prenume = p;
            Adresa = a;
            Varsta = v;
        }
    }
}
