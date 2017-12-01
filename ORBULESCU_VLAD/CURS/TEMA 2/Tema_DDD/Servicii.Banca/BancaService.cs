using System;
using Modele.Generic;
using Modele.Clienti;
using Servicii.Clienti;

namespace Servicii.Banca
{
    class BancaService
    {
        public void EditareCreditare(Modele.Banca.Banca b, Boolean open)
        {
            b.AcordaCredite = open;
        }

        public void CalculeazaCoeficientDobanda(Modele.Banca.Banca b)
        {
            b.CoeficientDobanda = CoeficientDobanda.CalculeazaCoeficient(b.ListaClienti.Count, b.SumaTotalaRate);
        }

        public void AcordaCredit(Client c, Modele.Banca.Banca b, float SumaRata)
        {
            b.SumaTotalaRate += SumaRata;
            ClientiService.Crediteaza(c);
        }

        public void AdaugaClientBancii(Client c, Modele.Banca.Banca b)
        {
            b.ListaClienti.Add(c);
        }
    }
}
