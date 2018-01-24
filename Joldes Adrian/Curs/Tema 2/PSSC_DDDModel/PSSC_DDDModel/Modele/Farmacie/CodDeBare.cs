using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PSSC_DDDModel.Modele.Farmacie
{
    class CodDeBare
    {
        private string value;

        public string Value
        {
            get { return value;  }
            set { this.value = value; }
        }

        public CodDeBare(string value)
        {
            this.value = value;
        }

    }
}
