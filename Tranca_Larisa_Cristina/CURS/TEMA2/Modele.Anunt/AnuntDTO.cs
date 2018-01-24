using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modele.Anunt
{
    class AnuntDTO
    {
        public List<Locuinta> Locuinte { get; set; }
        public string Descriere { get; set; }
        public DateTime Data { get; set; }
        public float pretul { get; set; }
        public string locatia { get; set; }
        public Email AdresaEmail { get; set; }
        public Telefon NumarTelefon { get; set; }
        public override string ToString()
        {
            return string.Format("{0} - {1} - {2} - {3} - {4}", Descriere, Data, pretul, AdresaEmail, NumarTelefon);
        }
    }
}
