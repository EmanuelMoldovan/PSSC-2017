using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Modele.Generic;

namespace Test
{
    public class AdresaTest
    {
        [Fact]
        public void Succes()
        {
            AdresaContact adr = new AdresaContact("Str.ABC, nr.1");
            Assert.NotEqual("", adr.Adresa);
        }
    }
}
