using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsscT2.Modele.ModeleSocietate
{
    class CapitalPasiv
    {
        List<MijlocFix> mijloace_fixe = new List<MijlocFix>();
        int valoare_totala;

        public int Valoare_totala { get => valoare_totala; set => valoare_totala = value; }
        internal List<MijlocFix> Mijloace_fixe { get => mijloace_fixe; set => mijloace_fixe = value; }

        public void AddMijlocFix(MijlocFix mijloc_fix)
        {
            Mijloace_fixe.Add(mijloc_fix);
            Valoare_totala = Valoare_totala + mijloc_fix.getValoare();
        }
    }
}
