using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Masina;
namespace Brand
{
    public class Brand
    {
        public string Nume;
        public List<Masina.Masina> ListaMasini;

        internal Brand(string Nume)
        {
            this.Nume = Nume;
            this.ListaMasini = new List<Masina.Masina>();
        }

        internal Brand(string Nume,List<Masina.Masina> ListaMasina)
        {
            this.Nume = Nume;
            this.ListaMasini = ListaMasina;
        }

        public override string ToString()
        {
            string sir;
            sir = " Marca:"+Nume.ToString()+"\n";
            foreach (Masina.Masina b in ListaMasini)
            {
                sir += b.ToString();
            }
            return sir;
        }
    }
}
