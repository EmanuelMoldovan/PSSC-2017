using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapostFry
{
    class rasa
    {
        static void Main(string[] args)
        {
             public string Nume;
        public List<Animal.Animal> Listavietati;

        internal rasa(string Nume)
        {
            this.Nume = Nume;
            this.Listavietati = new List<Animal.Animal>();
        }

        internal rasa(string Nume,List<Animal.Animal> ListaAnimal)
        {
            this.Nume = Nume;
            this.Listavietati = ListaAnimal;
        }

        public override string ToString()
        {
            string sir;
            sir = " rasa:"+Nume.ToString()+"\n";
            foreach (Animal.Animal b in Listavietati)
            {
                sir += b.ToString();
            }
            return sir;
        }
    }
}
