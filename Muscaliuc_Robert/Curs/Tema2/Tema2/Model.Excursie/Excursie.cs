
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Modele.Excursie
{
    public class Excursie
    {
        private string numeExcursie;
        public Cazare numeCazare { get; internal set; }
        public TipPret tipPret { get; internal set; }
        private float pret;
        public Perioada perioada { get; internal set; }
        public Transport transport { get; internal set; }

        internal Excursie(string nume,  float p, Cazare cazare)
        {
            numeExcursie = nume;
            numeCazare = cazare;
            pret = p;
            
        }

        public string seteazaTipPretInEuro()
        {
            tipPret = TipPret.Euro;
            return "euro";
        }
         public string seteazaTipPretInLei()
        {
            tipPret = TipPret.Lei;
            return "lei";
        }

         public void seteazaTipTransport(string tipTransport)
         {
             transport = new Transport(tipTransport,5);
             
         }





    }
}
