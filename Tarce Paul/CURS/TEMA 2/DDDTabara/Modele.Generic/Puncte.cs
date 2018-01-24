using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;

namespace Modele.Generic
{
    public class Puncte
    {
        private int _puncte;
        public int Valoare { get { return _puncte; } }

        public Puncte(int puncte)
        {

            Contract.Requires<ArgumentException>(puncte > -10, "valoare prea mica");
            Contract.Requires<ArgumentException>(puncte < 10, "valoare prea mare");

            _puncte = puncte;
        }
    }
}
