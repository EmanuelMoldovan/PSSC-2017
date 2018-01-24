using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventar
{
    public class Inventar
    {
        public List<Brand.Brand> ListaInventar;
        
        public Inventar()
        {
            
            ListaInventar = new List<Brand.Brand>();
        }
        
        public Inventar(Brand.Brand masina)
        {
            ListaInventar.Add(masina);
        }

        public override string ToString()
        {
            string sir="";
            foreach (Brand.Brand b in ListaInventar)
            {
                sir += b.ToString();
            }
            return sir;
        }
    }
}
