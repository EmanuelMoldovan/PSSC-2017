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
    public class CartiTest
    {
        [Fact]
        public void Empty()
        {
            Carte carte = new Carte(new ISSN("123-A34f-34"), new Text("Titlu1"), Gen_tip.dramatic, Gen_continut.Aventură);
            Carti lista = new Carti();
            Assert.Empty(lista.lista_carti);
        }
        [Fact]
        public void NotEmpty()
        {
            Carte carte = new Carte(new ISSN("123-A34f-34"), new Text("Titlu1"), Gen_tip.dramatic, Gen_continut.Aventură);
            Carti lista = new Carti();
            lista.Adauga_carte(carte);
            Assert.NotEmpty(lista.lista_carti);
        }
    }
}
