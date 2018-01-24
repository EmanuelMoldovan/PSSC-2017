using Modele.Generic;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.Librarie
{
    public class Utilizator
    {
        public Text nume { get; internal set; }
        public AdresaContact adresa { get; internal set; }
        int imprumut;
        public Utilizator(Text nume, AdresaContact adr)
        {
            Contract.Requires(nume != null, "Numele utilizatorului necesar nenul");
            Contract.Requires(adr != null, "Adresa de contact necesar nenula");
            this.nume = nume;
            adresa = adr;
        }
        public Stare Alege_carte(Carte carte)
        {
            Contract.Requires(carte.stare == Stare.disponibila, "Cartea nu este disponibila");
            if (imprumut == 0)
            {
                carte.stare = Stare.imprumutata;
                imprumut = 1;
            }
            return carte.stare;
        }
        public Stare Restituie_carte(Carte carte)
        {
            Contract.Requires(carte.stare == Stare.imprumutata, "Cartea este disponibila");
            carte.stare = Stare.disponibila;
            imprumut = 0;
            return carte.stare;
        }
        public string Cauta_carte(Text titlu, Carti carti)
        {
            Contract.Requires(titlu != null, "Titlul cartii invalid");
            List<Carte> lista_c = new List<Carte>(carti.lista_carti);
            var f = lista_c.Find(c => c.titlu.ToString().Equals(titlu.ToString()));
            if (f != null)
                return "Carte gasita: " + f.nr + " " + f.titlu;
            else
                return "Cartea nu exista";
        }
        public override string ToString()
        {
            return nume.ToString();
        }

    }
}
