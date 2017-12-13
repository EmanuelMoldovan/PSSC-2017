using External;
using Modele.Arbitru;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XUnit;

namespace XUnit
{
    class Program
    {
        private Mock<IExternalItem> _externalItemMock;
        
        public void ShouldThrowNullException()
        {
            var arbitru = new Arbitru();
            Assert.Throws<NullReferenceException>(() => arbitru.ReturnMeciuri(arbitru));
        }
    }
}
