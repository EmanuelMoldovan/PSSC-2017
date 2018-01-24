using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Disciplina
{
    public class Disciplina
    {
        public string NumeDisciplina;
        private List<Brand.Brand> ListaBranduri;

        internal Disciplina(string Nume)
        {
            this.NumeDisciplina = Nume;
            this.ListaBranduri = new List<Brand.Brand>();
        }

        internal Disciplina(string Nume, List<Brand.Brand> ListaBrand)
        {
            this.NumeDisciplina = Nume;
            this.ListaBranduri = ListaBrand;
        }
    }
}
