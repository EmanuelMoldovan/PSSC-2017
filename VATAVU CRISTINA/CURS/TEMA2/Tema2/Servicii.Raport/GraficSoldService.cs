using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modele.Generic;
using Modele.Cont;
using Infrastructura.Grafice;
using Infrastructura.Raport;

namespace Servicii.Conturi
{
    public class GraficSoldService
    {
        List<Suma> solduri;

        public void GraficSoldInTimp(Cont cont)
        {
            solduri = new List<Suma>();
            solduri.Add(new Suma(0.0)); //incepe de la 0
            Suma soldPrecedent = new Suma(0.0);
            foreach (Tranzactie t in cont.IstoricTranzactii.getTranzactii)
            {
                if(t.Tip.Equals(TipTranzactie.Depunere))
                {
                    Suma soldAux = new Suma(soldPrecedent.getSuma + t.Suma.getSuma);
                    soldPrecedent.getSuma += t.Suma.getSuma;
                    solduri.Add(soldAux);
                }
                else if (t.Tip.Equals(TipTranzactie.Transfer))
                {
                    Suma soldAux = new Suma(soldPrecedent.getSuma - t.Suma.getSuma);
                    soldPrecedent.getSuma -= t.Suma.getSuma;
                    solduri.Add(soldAux);
                }
                else if (t.Tip.Equals(TipTranzactie.Factura))
                {
                    Suma soldAux = new Suma(soldPrecedent.getSuma - t.Suma.getSuma);
                    soldPrecedent.getSuma -= t.Suma.getSuma;
                    solduri.Add(soldAux);
                }
            }

            //apeleaza infrastructura
            GenereazaGrafic grafic = new GenereazaGrafic();
            grafic.GenereazaGraficSold(solduri);
            //Console.WriteLine("s-a generat un grafic");



        }
    }
}
