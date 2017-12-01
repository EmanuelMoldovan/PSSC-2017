using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.Librarie
{
    public class Carti
    {
        private List<Carte> carti;
        public ReadOnlyCollection<Carte> lista_carti
        {
            get { return carti.AsReadOnly(); }
        }
        public Carti()
        {
            carti = new List<Carte>();
        }
        internal Carti(List<Carte> carti)
        {
            Contract.Requires(carti != null, "Lista necesar nenula");
            this.carti = carti;
        }
        public void Adauga_carte(Carte carte)
        {
            Contract.Requires(carte != null, "Cartea adaugata necesita caractere");
            carti.Add(carte);
        }
        public override string ToString()
        {
            foreach (Carte c in carti)
            {
                if (c != null)
                    return c.ToString();
            }
            return "";
        }
    }
}
