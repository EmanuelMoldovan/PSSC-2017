using Modele.Cursanti;
using Modele.LimbaStraina;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pssc_tema2
{
    class Program
    {
        static void Main(string[] args)
        {
            NivelLimba Nivel = new NivelLimba("Engleza","A1") ;
            Nivel.RepartizareCursanti("Maria", new Modele.Generic.Punctaj(20));//Adauga cursant pentru Nivelul A, limba Engleza
            Nivel.RepartizareCursanti("Maria", new Modele.Generic.Punctaj(27));
            Nivel.RepartizareCursanti("Maria", new Modele.Generic.Punctaj(34));
            Nivel.RepartizareCursanti("Maria", new Modele.Generic.Punctaj(11));
            Nivel.ActivareCurs();
            Nivel.RepartizareCursanti("Ioana", new Modele.Generic.Punctaj(99));
            
            // var curs = new LimbaStrainaFactory.Instance.CreeazaLimbaStraina();
        }
    }
}
