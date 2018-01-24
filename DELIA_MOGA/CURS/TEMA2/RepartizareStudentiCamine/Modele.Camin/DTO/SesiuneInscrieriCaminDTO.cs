using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modele.Generic;

namespace Modele.Camin.DTO
{
    public struct SesiuneInscrieriCaminDTO
    {
        public Camin NumeCamin { get; set; }
        public DateTime DataStart { get; set; }
        public DateTime DataStop { get; set; }
        public Durata DurataZile { get; set; } ///setata

        public override string ToString()
        {
            return string.Format("{0} - Inscrierile incep in data de {1} si se desfasoara pe durata a {2} zile.", NumeCamin.NumeCamin, DataStart.ToShortDateString(), DurataZile);
        }
    }
}
