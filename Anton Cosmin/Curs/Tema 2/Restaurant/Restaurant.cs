using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
     public class Restaurant
    {
         Meniu meniu;
         Orar orar;
        public int nrMese;
        public string adresa;
        public string nume;
        public Restaurant() { }
         public Restaurant(Meniu meniu, Orar orar, int nrMese, string adresa, string nume  )
        {
            this.meniu = meniu;
            this.orar = orar;
            this.nrMese = nrMese;
            this.adresa = adresa;
            this.nume = nume;
        }
         Meniu getMeniu()
        {
            return meniu;
        }
       public  Orar getOrar()
        {
            return orar;
        }
         void setMeniu(Meniu meniu)
        {
            this.meniu = meniu;
        }
        void setOrar(Orar orar)
        {
            this.orar = orar;
        }
        public int getNrMese()
        {
            return nrMese;
        }
        public void setNrMese(int nrMese)
        {
            this.nrMese = nrMese;
        }
        public string getAdresa()
        {
            return adresa;
        }
        public void setAdresa(string adresa)
        {
            this.adresa = adresa;
        }
        public string getNume()
        {
            return nume;
        }
        public void setNume(string nume)
        {
            this.nume = nume;
        }
        
    }
}
