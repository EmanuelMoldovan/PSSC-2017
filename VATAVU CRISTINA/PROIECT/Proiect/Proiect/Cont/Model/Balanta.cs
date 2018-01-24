using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modele.Generic;

namespace Modele.Cont
{
    class Balanta
    {
        private Suma sold;
        public Suma Sold { get { return sold; } set { sold = value; } }

        public Balanta(Suma sold)
        {
            this.sold = sold;
        }

    }
}
