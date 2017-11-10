using Modele.Generic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.Librarie
{
    public class Librarie
    {
        public Text nume { get; internal set; }
        public Carti carti { get; internal set; }
        private List<Utilizator> lista_cititori { get; set; }
        public ReadOnlyCollection<Utilizator> cititori
        {
            get { return lista_cititori.AsReadOnly(); }
        }

        internal Librarie(Text nume)
        {
            Contract.Requires(nume != null, "nume librarie necesar nenul");
            this.nume = nume;
            carti = new Carti();
            lista_cititori = new List<Utilizator>();
        }
        internal Librarie(Text nume, Carti carti, List<Utilizator> membrii) : this(nume)
        {
            Contract.Requires(carti != null, "Lista de carti necesar nenula");
            Contract.Requires(membrii != null, "Lista membrii nula");
            this.carti = carti;
            lista_cititori = membrii;
        }
        public void Adauga_membru(Utilizator utilizator)
        {
            Contract.Requires(utilizator != null, "Utilizator adaugat null");
            var find = lista_cititori.Find(u => u.Equals(utilizator));
            if (find == null)
                lista_cititori.Add(utilizator);
            else
                throw new UtilizatorExceptie(utilizator); 

        }

        string afis()
        {
            foreach (Utilizator u in lista_cititori)
               return u.ToString();
            return "";
        }
        public override string ToString()
        {
            return nume.ToString() + " " + carti.ToString() + " " + afis();
        }
    }
}
