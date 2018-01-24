using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapostFry
{
    class Animal
    {
        public string rasa;
        public int varsta;
        public string Culoare;
        public int Pret;

        internal Animal(string rasa,int varsta,string Culoare,int Pret)
        {
            this.rasa = rasa;
            this.varsta = varsta;
         
            this.Culoare = Culoare;
            this.Pret = Pret;
        }

        public override string ToString()
        {
            return "  rasa: " + rasa.ToString() + "\n" + "   VARSTA: "+ varsta.ToString() + "\n" + "   luni: " + Hp.ToString()+"Hp" + "\n" + "   Culoare: " + Culoare.ToString() + "\n" + "   Pret: " + Pret.ToString()+"E" + "\n\n";
        }
    }
}
