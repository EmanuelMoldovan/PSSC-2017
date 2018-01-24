using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modele.Cont;
using Modele.Generic;
using Infrastructura.Grafice;
using Infrastructura.Raport;

namespace Servicii.Conturi
{
    public class RaportTranzactiiService
    {
        public void RapoarteTranzactii(Cont cont)
        {
            StringBuilder raport = new StringBuilder();
            int i= 0;

            raport.AppendLine("     IBAN Client: " + cont.IBAN.getIBAN);
            raport.AppendLine("     Nume Client: " + cont.DateClient.Nume.ToString());
            raport.AppendLine(); //linie goala

            foreach (Tranzactie t in cont.IstoricTranzactii.getTranzactii)
            {
                raport.AppendLine("Tranzactia " + i + ":");
                raport.AppendLine(" ID:             " + t.ID.getID);
                
                if (t.Tip.Equals(TipTranzactie.Depunere))
                {
                    raport.AppendLine(" Tip Tranzactie: Depunere");
                    raport.AppendLine(" De la:          " + t.PartenerTranzactie.getIBAN);
                     
                }
                else if (t.Tip.Equals(TipTranzactie.Transfer))
                {
                    raport.AppendLine(" Tip Tranzactie: Transfer");
                    raport.AppendLine(" Catre:          " + t.PartenerTranzactie.getIBAN);
                    
                }
                else if (t.Tip.Equals(TipTranzactie.Factura))
                {
                    raport.AppendLine(" Tip Tranzactie: Factura");
                    raport.AppendLine(" Catre:          " + t.PartenerTranzactie.getIBAN);
                    
                }
                raport.AppendLine(" Suma:           " + t.Suma.getSuma);
                //raport.AppendLine();
                //raport.AppendLine();
                raport.AppendLine();

                //apeleaza infrastructura
                GenereazaRaport r = new GenereazaRaport();
                r.Equals(raport.ToString());
                i++;

            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("S-a generat raportul pentru:");
            Console.Write(raport);
        }
    }
}
