using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.Cont
{
    
    public class Tranzactii
    {
        private List<Tranzactie> tranzactii;
        public List<Tranzactie> getTranzactii { get { return tranzactii; } }

        public Tranzactii()
        {
            tranzactii = new List<Tranzactie>();
        }

        public void AdaugaTranzactie(Tranzactie tranzactie)
        {
            tranzactii.Add(tranzactie);
        }
    }
}
