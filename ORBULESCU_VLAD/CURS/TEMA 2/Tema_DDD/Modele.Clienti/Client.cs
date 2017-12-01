using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modele.Generic;
using Modele.Cont;

namespace Modele.Clienti
{
    public class Client
    {
        public String Nume { get; internal set; }
        public String Prenume { get; internal set; }
        public String Cnp { get; internal set; }
        public String Adresa { get; internal set; }
        public String Email { get; internal set; }
        public float VenitLunar { get; internal set; }
        public RataCredit RataCredit { get; set; }
        public List<Modele.Cont.Cont> ListaConturi { get; set; }

        internal Client(String N, String P, String Cnp, String Ad, String Em, float Vl, RataCredit Rc)
        {
            Nume = N;
            Prenume = P;
            this.Cnp = Cnp;
            Adresa = Ad;
            Email = Em;
            RataCredit = Rc;
            VenitLunar = Vl;
        }

        //TODO : Bug la afisare. ListaConturi va afisa Object.object , trebuie implementata o clasa Conturi caruia i se face override
        //la metoda to string pentru a afisa fiecare cont intr-un foreach, asa cum s-a procedat pentru Clienti
        public override string ToString()
        {
            return Nume + " " + Prenume + " " + Cnp + " " + Adresa + " " +
                Email + " " + VenitLunar.ToString() + " " + RataCredit.Rata.ToString() +
                " " + ListaConturi.ToString();
        }
    }
}
