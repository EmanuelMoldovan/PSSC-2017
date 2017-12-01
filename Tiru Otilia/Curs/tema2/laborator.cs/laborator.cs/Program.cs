using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laborator 
{
    class Program
    {
        static void Main(string[] args)
        {

            //creare repo
            var repository = new AdapostRepository.AdapostRepository();

            //creare Adapost
            var Adapost = AdapostFactory.AdapostFactory.Instance.CreareAdapost("Padoc");

            //adaugare Adapost in repository
            repository.AdaugaAdapost(Adapost);

            //adaugare rasa
            Animal.Adaugarasa(AdapostFactory.AdapostFactory.Instance.Crearerasa("Bichon"));
            Animal.Adaugarasa(AdapostFactory.AdapostFactory.Instance.Crearerasa("Labrador"));

            //adaugare animal
            Adapost.AdaugaAnimal("Bichon", AdapostFactory.AdapostFactory.Instance.CreareAnimal("Azorel", 12,4,12.05.2017));
            Adapost.AdaugaAnimal("Labrador",AdapostFactory.AdapostFactory.Instance.CreareAnimal("Rita", 23,5,0));
            Adapost.AdaugaAnimal("Bichon",AdapostFactory.AdapostFactory.Instance.CreareAnimal("Asha", 54,22,0));
            Adapost.AdaugaAnimal("Labrador", AdapostFactory.AdapostFactory.Instance.CreareAnimal("Gina", 33,11,18.11.2016));

            //afisare repository
            Console.WriteLine("Repository complet: \n");
            Console.WriteLine(repository.ToString());

            if (Adapost.rasaExist("bichon"))
            {
                Console.WriteLine("Exista \n");
            }
            else
            {
                Console.WriteLine("Nu exista \n");
            }


            //stergem rasa bichon
            Console.WriteLine("Repository dupa stergerea rasei bichon: \n");
            disciplina.Stergerasa("Bichon");
            Console.WriteLine(repository.ToString());

            //stergem Animal
            Console.WriteLine("Repository dupa stergerea animal: \n");
            disciplina.StergeAnimal("Bichon", "3ani");
            Console.WriteLine(repository.ToString());

            //stergem adapost
            Console.WriteLine("Repository dupa stergerea adapost): \n");
            repository.StergeAdapost(adapost);
            Console.WriteLine(repository.ToString());

            Console.WriteLine("Press any key to terminate.");
            Console.ReadLine();
        }
    }
}
