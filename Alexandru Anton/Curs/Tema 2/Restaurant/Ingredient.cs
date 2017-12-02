using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
   public class Ingredient
    {
        public string nume;
        public Ingredient (string nume)
        {
            this.nume = nume;
        }
        public string getNume()
        {
            return nume;
        }
        public void setNume(string nume)
        {
            this.nume = nume;
        }
    }
}
