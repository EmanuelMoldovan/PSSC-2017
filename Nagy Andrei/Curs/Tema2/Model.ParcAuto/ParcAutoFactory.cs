using Model.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ParcAuto
{
    public class ParcAutoFactory
    {
        public static readonly ParcAutoFactory Instance = new ParcAutoFactory();
        public static List<Model.ParcAuto.Masina> _masina = new List<Model.ParcAuto.Masina>();

        private ParcAutoFactory()
        {
            
        }

      

        public ParcAuto CreeazaParcAuto(string nume, string judet,string localitate, string strada, int numar)
        {
            var parc = new ParcAuto(new PlainText(nume),new Adresa(new PlainText(localitate),new PlainText(judet),new PlainText(strada),numar));
            return parc;
        }

        public Masina CreeazaMasina(TipMasina tip, string marca, string an, string km, string descriere)
        {
            var masina = new Masina(tip,new PlainText(marca),new PlainText(an),new PlainText(km),new PlainText(descriere));
            _masina.Add(masina);
            return masina;
        }

        public Dealer CreeazaDealer(string nume, string prenume, string cnp)
        {
            var dealer = new Dealer(new PlainText(nume),new PlainText(prenume),cnp);
            return dealer;
        }

       
    }
}
