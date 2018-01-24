using Modele.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modele.Agent
{
    class CumparatorDTO
    {
        public PlainText NumeCumparator { get; set; }
        public PlainText PrenumeCumparator { get; set; }
        public Email AdresaEmail { get; set; }
        public Telefon NumarTelefon { get; set; }

        public override string ToString()
        {
            return string.Format("{0} - {1} - {2} - {3}", NumeCumparator, PrenumeCumparator, AdresaEmail, NumarTelefon);
        }
    }
}
