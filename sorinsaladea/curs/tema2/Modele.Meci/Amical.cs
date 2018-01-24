using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.Meci
{
    class Amical:Meci
    {
        public int numar_schimbari;
        public Amical(string gazda, string oaspete, DateTime data, string stadion, int numar_schimbari) : base(gazda, oaspete, data, stadion)
        {
            this.numar_schimbari = numar_schimbari;
        }
    }
}
