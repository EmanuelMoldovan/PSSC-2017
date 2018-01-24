using Modele.Generic;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Modele.LimbaStraina
{
    public class NivelLimba
    {
        private string LimbaSt { get;  set; }
        private enum Nivel { A,B,C};
        private string Nume { get;  set; }
        public List<string> nivelLimbaListA = new List<string>();
        List<string> nivelLimbaListB = new List<string>();
        List<string> nivelLimbaListC = new List<string>();
        NivelCursant NivelC;
        Cursuri cursActivat;
        List<Cursuri> CursuriActivate = new List<Cursuri>();
        NivelLimba NivelL;
        private string limbaS;

        public NivelLimba(string limbaS, string nume)
        {
            LimbaSt = limbaS;
            Nume = nume;

        }
        
        public void RepartizareCursanti(string nume, Punctaj punctaj)
        {
            if (punctaj.ValoareNota > 0 && punctaj.ValoareNota < 35)
            {
                nivelLimbaListA.Add(nume);
                NivelC = NivelCursant.A;
            }
            else
               if (punctaj.ValoareNota >= 35 && punctaj.ValoareNota < 80)
            {
                nivelLimbaListB.Add(nume);
                NivelC = NivelCursant.B;
            }
            else
               if (punctaj.ValoareNota >= 80 && punctaj.ValoareNota <= 100)
            {
                nivelLimbaListC.Add(nume);
                NivelC = NivelCursant.C;
            }
            else
                if(punctaj.ValoareNota < 0 && punctaj.ValoareNota > 100)
            {
                Console.WriteLine("Punctajul nu este intre 0 si 100");
            }

        }
        public void ActivareCurs()
        {
            if(nivelLimbaListA.Count>3)
            {
                
                cursActivat = new Cursuri(NivelL);
                CursuriActivate.Add(cursActivat.CreareCurs(LimbaSt, "NivelA"));
            }
            if(nivelLimbaListB.Count>3)
            {
                cursActivat.CreareCurs(LimbaSt, "NivelB");
            }
            if(nivelLimbaListC.Count>3)
            {
                cursActivat.CreareCurs(LimbaSt, "NivelC");
            }

        }
    }
}
