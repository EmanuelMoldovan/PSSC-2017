using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Modele.Librarie;
using Modele.Generic;

namespace Test
{
    public class UtilizatorTest
    {
        [Fact]
        public void Imprumutat()
        {
            Utilizator utiliz = new Utilizator(new Text("Nume"), new AdresaContact("Adr.1"));
            Carte carte = new Carte(new ISSN("23-EFF-344"), new Text("Titlu"), Gen_tip.liric, Gen_continut.Mister);
            Stare s =Stare.imprumutata;
            Assert.Equal(s, utiliz.Alege_carte(carte));
        }

        [Fact]
        public void Restituit()
        {
            Utilizator utiliz = new Utilizator(new Text("Nume"), new AdresaContact("Adr.2"));
            Carte carte = new Carte(new ISSN("2454-EFf-334"), new Text("Titlu2"), Gen_tip.liric, Gen_continut.Mister);
            carte.stare = utiliz.Alege_carte(carte);
            Stare s = Stare.disponibila;
            Assert.Equal(s, utiliz.Restituie_carte(carte));
        }

        [Fact]
        public void Cautare_lista()
        {
            Utilizator utiliz = new Utilizator(new Text("Nume"), new AdresaContact("Adr.3"));
            string s = utiliz.Cauta_carte(new Text("This"), new Carti());
            Assert.Equal("Cartea nu exista", s);
        }
        [Fact]
        public void Cautare_lista_carti()
        {
            Utilizator utiliz = new Utilizator(new Text("Nume"), new AdresaContact("Adr.4"));
            Carte carte1 = new Carte(new ISSN("221-455f-fr3"), new Text("Titlu3"), Gen_tip.liric, Gen_continut.Mister);
            Carte carte2 = new Carte(new ISSN("556-hh-67r"), new Text("Titlu3"), Gen_tip.liric, Gen_continut.Filozofic);
            Carti lista = new Carti();
            lista.Adauga_carte(carte1);
            lista.Adauga_carte(carte2);
            string s = utiliz.Cauta_carte(new Text("Titlu3"), lista);
            Assert.Equal(carte1.nr + " " + carte1.titlu, s);
        }
    }
}
