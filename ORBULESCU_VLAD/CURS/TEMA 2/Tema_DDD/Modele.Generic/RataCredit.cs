using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.Generic
{
    public class RataCredit
    {
        public float Rata { get; set; }

        //Rata de credit se calculeaza pe baza venitului si perioada de creditare a clientului
        public RataCredit(float venit, float perioada)
        {
            Rata =  venit / perioada;
        }
    }
}
