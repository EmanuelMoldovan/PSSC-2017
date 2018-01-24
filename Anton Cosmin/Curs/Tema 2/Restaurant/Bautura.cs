using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
     public class Bautura
    {
        public int pret;
        public string nume;
        public int cantitate;
        public Bautura(int pret, string nume,int cantitate)
        {
            this.pret = pret;
            this.nume = nume;
            this.cantitate = cantitate;
        }
        public int getPret()
        {
            return this.pret;

        }
        void setPret(int pret)
        {
            this.pret = pret;
        }
        public string getNume()
        {
            return this.nume;

        }
        void setNume(string nume)
        {
            this.nume = nume;
        }
        public int getCantitate()
        {
            return this.cantitate;
        }
        void setCantitate(int cantitate)
        {
            this.cantitate = cantitate;
        }
    }
}
