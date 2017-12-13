using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.Meci
{
    class Cupa:Meci
    {
        public string faza;
        public Cupa(string gazda,string oaspete,DateTime data,string stadion,string faza):base(gazda,oaspete,data,stadion)
        {
            this.faza = faza;
        }
    }
}
