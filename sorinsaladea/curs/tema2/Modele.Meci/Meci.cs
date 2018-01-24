using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.Meci
{
    public class Meci
    {
        public string gazda;
        public string oaspete;
        public DateTime data;
        public string stadion;
        private int numar;
        public Meci(string gazda, string oaspete,DateTime data, string stadion)
        {
            this.gazda = gazda;
            this.oaspete = oaspete;
            this.data = data;
            this.stadion = stadion;
            numar++;
        }
    }
}
