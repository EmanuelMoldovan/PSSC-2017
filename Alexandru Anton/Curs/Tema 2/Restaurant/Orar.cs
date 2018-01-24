using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Orar
    {
        public int oraDeschidere;
        public int oraInchidere;
        public Orar(int oraDeschidere, int oraInchidere)
        {
            this.oraDeschidere = oraDeschidere;
            this.oraInchidere = oraInchidere;
        }
         public int getOraDeschidere()
        {
            return oraDeschidere;
        }
        public void setOraDeschidere(int oraDeschidere)
        {
            this.oraDeschidere = oraDeschidere;
        }
        public int getOraInchidere()
        {
            return oraInchidere;
        }
        public void setOraInchidere(int oraInchidere)
        {
            this.oraInchidere = oraInchidere;
        }
    }
}
