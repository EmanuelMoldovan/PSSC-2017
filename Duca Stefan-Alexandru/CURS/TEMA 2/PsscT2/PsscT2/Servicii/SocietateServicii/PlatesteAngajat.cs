using PsscT2.Modele.ModeleSalariati;
using PsscT2.ModelGeneric;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsscT2.Servicii.SocietateServicii
{
    class PlatesteAngajat
    {
        public void PlatesteAngajati(Cont cont_firma, List<Salariat> salariat)
        {
            foreach (Salariat s in salariat)
            {
                cont_firma.TransferFunds(s.Cont, s.Salariu);
            }
        }

    }
}
