using PsscT2.Modele.ModeleClienti;
using PsscT2.Modele.ModeleSalariati;
using PsscT2.ModelGeneric;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsscT2.Modele.ModeleSocietate
{
    class FactorySocietate
    {

        //  public static readonly Societate Instance = new Societate();
        public Societate CreeazaSocietate(string nume, List<Salariat> salariati, List<Client> clienti,  CapitalActiv capitalActiv, CapitalPasiv capitalPasiv, Cont cont, int CUI)
        {

            Societate societate = new Societate(nume,salariati,clienti,capitalActiv,capitalPasiv,cont,CUI);
            return societate;
        }
    }
}
