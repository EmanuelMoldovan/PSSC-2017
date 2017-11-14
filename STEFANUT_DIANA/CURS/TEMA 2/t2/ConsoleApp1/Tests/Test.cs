using Modele.ClasaStudiu;
using Modele.Generic;
using System;
using Xunit;

namespace Tests
{
    public class Test
    {
        [Fact]
        public void VerificaInstantiereClasaStudiu()
        {
            var clasaStudiu = ClasaStudiuFactory.Instance.CreeazaClasaStudiu("clasa 5A");
        }

        [Fact]
        public void VerificaCreareNotaElev()
        {
            Elev elev = new Elev(new NumarMatricol("ab12345"), new PlainText("Andrei"), new Nota(5), "biologie");
        }

    }
}
