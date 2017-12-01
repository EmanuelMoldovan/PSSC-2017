using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using rasa;
using Adapost ;

namespace AdapostFry
{
    class AdapostFry
    {
         public static readonly AdapostFactory Instance = new AdapostFactory();

        
        public Adapost.Adapost CreareAdapost(string Nume)
        {
            var Adapost = new Adapost.Adapost(Nume);

            return Adapost;
        }

        public rasa.rasa Crearerasa(string Nume)
        {
            var rasa = new rasa.rasa(Nume);
           
            return rasa;
        }


        public Animal.Animal CreareAnimal(string rasa,  int varsta, string Culoare, int Pret)
        {
            var Animal = new Animal.Animal(rasa, varsta, Culoare, Pret);

            return Animal;
        }

        public void AfisareAdapost(Adapost.Adapost Adapost)
        {
            var dis = Adapost;

            Console.WriteLine(dis.ToString());
            Console.WriteLine("Press any key to terminate.");
            Console.ReadLine();
        }

    }
}
