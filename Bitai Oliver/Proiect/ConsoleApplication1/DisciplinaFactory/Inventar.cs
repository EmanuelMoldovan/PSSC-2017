using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisciplinaFactory
{
    public class Inventar
    {
        public List<Tip> ListaInventar;

        public Inventar()
        {

            ListaInventar = new List<Tip>();
        }

        public Inventar(Tip produs)
        {
            ListaInventar = new List<Tip>();
            ListaInventar.Add(produs);
        }

        public override string ToString()
        {
            string sir = "";
            foreach (Tip b in ListaInventar)
            {
                sir += b.ToString();
            }
            return sir;
        }
    }
}
