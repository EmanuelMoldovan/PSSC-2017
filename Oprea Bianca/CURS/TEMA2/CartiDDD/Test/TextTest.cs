using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Modele.Generic;
using Modele.Librarie;

namespace Test
{
    public class TextTest
    {
        [Fact]
        public void Succes()
        {
            Text text = new Text("test");
            Assert.Equal("test", text.Numesimplu);
        }
         
        public class EmptyArgumentException : Exception
        {
            public EmptyArgumentException()
            {
                ToString();
            }
            public override string ToString()
            {
                return "Empty argument";
            }
        }
    }
}
