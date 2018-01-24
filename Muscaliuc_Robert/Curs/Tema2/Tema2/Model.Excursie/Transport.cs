using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.Excursie
{
    public class Transport
    {
        private string tipTransport;
        private int durataTransport;
        public string TipTransport { get { return tipTransport; } }


        internal Transport(string tip, int durata)
        {
            tipTransport = tip;
            durataTransport = durata;
        }
    }
}
