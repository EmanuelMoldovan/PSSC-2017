using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class test
    {
        [Fact]
        public void VerificareAdaugarerasa()
        {
            // arrange
            var Animal = AnimalFactory.AnimalFactory.Instance.CreareAnimal("Padoc");
            Animal.Adaugarasa(AnimalFactory.AnimalFactory.Instance.Crearerasa("Beagle"));

     
            bool testResult = Adapost.RasaExist("Beagle");

            
            Assert.True(testResult); 
        }
        [Fact]
        public void animale()
        {
            string v = "eee";

            Assert.Equal("eee", v);
                    }
    }
}
