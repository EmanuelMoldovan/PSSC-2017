using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.Meci
{
    class Campionat:Meci
    {
        public int etapa;
        public Campionat(string gazda,string oaspete,DateTime data,string stadion,int etapa):base(gazda,oaspete,data,stadion)
        {
            this.etapa = etapa;
        }
    }
}
