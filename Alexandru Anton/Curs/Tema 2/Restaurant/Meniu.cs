using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Meniu
    {
         List<Preparate> preparate = new List<Preparate>();
        public List<Bautura> bauturi = new List<Bautura>();
          public Meniu(List<Preparate> preparate, List<Bautura> bauturi)
        {
            this.preparate = preparate;
            this.bauturi = bauturi;
        }
    }
}
