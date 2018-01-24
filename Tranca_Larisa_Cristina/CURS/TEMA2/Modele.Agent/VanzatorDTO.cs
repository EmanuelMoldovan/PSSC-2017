using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modele.Departament
{
    class VanzatorDTO
    {
        public PlainText NumeVanzator { get; set; }
        public PlainText PrenumeVanzator { get; set; }
        public Email AdresaEmail { get; set; }
        public Telefon NumarTelefon { get; set; }
        public Locuinta AdresaLocuinta { get; set; }
        public StareLocuinta stareLocuinta { get; set; }
        public override string ToString()
        {
           return string.Format("{0} - {1} - {2} - {3}", NumeVanzator, PrenumeVanzator, AdresaEmail, NumarTelefon);
        }
    }
}
