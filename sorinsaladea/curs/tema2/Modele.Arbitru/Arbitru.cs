using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modele.Comisie;

namespace Modele.Arbitru
{
    public class Arbitru:Membru
    {
        public int anObtinereCateg1;
        public int meciuri;
        public Arbitru(string nume,string prenume,string studii,DateTime dataN,int anObtinereCateg1,int meciuri):base(nume,prenume,studii,dataN)
        {
            this.anObtinereCateg1 = anObtinereCateg1;
            this.meciuri = meciuri;
        }
        public int ReturnMeciuri(Arbitru arbitru)
        {
            return arbitru.meciuri;
        }
    }
}
