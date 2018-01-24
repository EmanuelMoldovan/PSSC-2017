using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Preparate
    {
        public List<Ingredient> ingrediente = new List<Ingredient>();
        public int pret;
        public string nume;
        public int gramaj;
        public Preparate(List<Ingredient> ingrediente,int pret,string nume,int gramaj)
        {
            this.ingrediente = ingrediente;
            this.pret = pret;
            this.nume = nume;
            this.gramaj = gramaj;
        }
        public List<Ingredient> getIngrediente()
        {
            return ingrediente;
        }
        public void  setIngrediente(List<Ingredient> ingrediente)
        {
            this.ingrediente = ingrediente;
        }
        public int getPret()
        {
            return pret;
        }
        public void setPret(int pret)
        {
            this.pret = pret;
        }
        public string getNume()
        {
            return nume;

        }
        public void setNume(string nume)
        {
            this.nume = nume;
        }
        public int getGramaj()
        {
            return gramaj;
        }
        public void setGramaj(int gramaj)
        {
            this.gramaj = gramaj;
        }
    }

}
