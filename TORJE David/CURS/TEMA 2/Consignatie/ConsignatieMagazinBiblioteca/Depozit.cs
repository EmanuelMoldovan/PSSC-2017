using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsignatieMagazinBiblioteca
{
    public class Depozit
    {
        public string Nume { get; set; }
        public List<Furnizor> Furnizori { get; set; }
        public List<Item> Items { get; set; }

        public Depozit()
        {
            Furnizori = new List<Furnizor>();
            Items = new List<Item>();
        }
    }
}
