using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.Cont
{
    public class ContFactory
    {
        //Un obiect din clasa Cont nu se poate instantia decat prin aceasta metoda a clasei ContFactory
        public static Cont CreeazaCont(String Valuta, float Suma)
        {
            return new Cont(Valuta, Suma);
        }
    }
}
