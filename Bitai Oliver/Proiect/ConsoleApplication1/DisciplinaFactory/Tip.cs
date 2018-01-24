using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisciplinaFactory
{
    public class Tip
    {
        public string Nume;
        public List<Produs> ListaProduse;

        internal Tip(string Nume)
        {
            this.Nume = Nume;
            this.ListaProduse = new List<Produs>();
        }
        internal Tip(string Nume, List<Produs> ListaProduse)
        {
            this.Nume = Nume;
            this.ListaProduse = ListaProduse;
        }

        public override string ToString()
        {
            string sir;
            sir = " Tip:" + Nume.ToString() + "\n";
            foreach (Produs b in ListaProduse)
            {
                sir += b.ToString();
            }
            return sir;
        }
    }
}
