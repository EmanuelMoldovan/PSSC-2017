using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantBL;
using Restaurant;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Afisare Restaurante");
            Console.WriteLine("2. Adaugare Restaurante");
            Console.WriteLine("3. Modificare Restaurante");
            Console.WriteLine("4. Stergere Restaurante");
            Console.WriteLine("0. Exit");
            Console.WriteLine("Alegeti Optiunea");
            string opt = Console.ReadLine();
            RestaurantBL.RestauranteBusinessLogic restaurantebl= new RestaurantBL.RestauranteBusinessLogic();
            while (!(string.Equals(opt, "0")))
            {
                if (string.Equals(opt, "1"))
                {
                    restaurantebl.AfisareRestaurante();
                }
                if (string.Equals(opt, "4"))
                {
                    string nume = Console.ReadLine();
                    restaurantebl.StergereRestaurant(nume);
                }
                if (string.Equals(opt, "2"))
                {
                    Console.WriteLine("dati ingredientul");
                    string ingredient = Console.ReadLine();
                    Restaurant.Ingredient i = new Restaurant.Ingredient(ingredient);
                    List<Restaurant.Ingredient> ingrediente = new List<Restaurant.Ingredient>();
                    ingrediente.Add(i);
                    Console.WriteLine("dati pretul");
                    string pret = Console.ReadLine();
                    Console.WriteLine("dati numele");
                    string nume = Console.ReadLine();
                    Console.WriteLine("dati gramaj");
                    string gramaj = Console.ReadLine();
                    Restaurant.Preparate preparat = new Restaurant.Preparate(ingrediente, Convert.ToInt16(pret), nume, Convert.ToInt16(gramaj));
                    List<Restaurant.Preparate> preparate = new List<Restaurant.Preparate>();
                    preparate.Add(preparat);
                    Console.WriteLine("dati ora deschidere");
                    string oraDeschidere = Console.ReadLine();
                    Console.WriteLine("dati ora inchidere");
                    string oraInchidere = Console.ReadLine();
                    Restaurant.Orar orar = new Restaurant.Orar(Convert.ToInt16(oraDeschidere), Convert.ToInt16(oraInchidere));
                    Console.WriteLine("dati pretul bauturii");
                    string pretBautura = Console.ReadLine();
                    Console.WriteLine("dati numele bauturii");
                    string numeBautura = Console.ReadLine();
                    Console.WriteLine("dati cantitatea");
                    string cantitate = Console.ReadLine();
                    Restaurant.Bautura bautura = new Restaurant.Bautura(Convert.ToInt16(pret), nume, Convert.ToInt16(cantitate));
                    List<Restaurant.Bautura> bauturi = new List<Restaurant.Bautura>();
                    bauturi.Add(bautura);
                    Restaurant.Meniu meniu = new Restaurant.Meniu(preparate, bauturi);
                    Console.WriteLine("dati numarul de mese ");
                    string nrMese = Console.ReadLine();
                    Console.WriteLine("dati adresa");
                    string adresa = Console.ReadLine();
                    Console.WriteLine("dati numele restaurantului");
                    string numeRestaurant = Console.ReadLine();
                    Restaurant.Restaurant restaurant = new Restaurant.Restaurant(meniu, orar, Convert.ToInt16(nrMese), adresa, numeRestaurant);
                    restaurantebl.AdaugareRestaurante(restaurant);
                }
                if (string.Equals(opt, "3"))
                {
                    Console.WriteLine("dati ingredientul");
                    string ingredient = Console.ReadLine();
                    Restaurant.Ingredient i = new Restaurant.Ingredient(ingredient);
                    List<Restaurant.Ingredient> ingrediente = new List<Restaurant.Ingredient>();
                    ingrediente.Add(i);
                    Console.WriteLine("dati pretul");
                    string pret = Console.ReadLine();
                    Console.WriteLine("dati numele");
                    string nume = Console.ReadLine();
                    Console.WriteLine("dati gramaj");
                    string gramaj = Console.ReadLine();
                    Restaurant.Preparate preparat = new Restaurant.Preparate(ingrediente, Convert.ToInt16(pret), nume, Convert.ToInt16(gramaj));
                    List<Restaurant.Preparate> preparate = new List<Restaurant.Preparate>();
                    preparate.Add(preparat);
                    Console.WriteLine("dati ora deschidere");
                    string oraDeschidere = Console.ReadLine();
                    Console.WriteLine("dati ora inchidere");
                    string oraInchidere = Console.ReadLine();
                    Restaurant.Orar orar = new Restaurant.Orar(Convert.ToInt16(oraDeschidere), Convert.ToInt16(oraInchidere));
                    Console.WriteLine("dati pretul bauturii");
                    string pretBautura = Console.ReadLine();
                    Console.WriteLine("dati numele bauturii");
                    string numeBautura = Console.ReadLine();
                    Console.WriteLine("dati cantitatea");
                    string cantitate = Console.ReadLine();
                    Restaurant.Bautura bautura = new Restaurant.Bautura(Convert.ToInt16(pret), nume, Convert.ToInt16(cantitate));
                    List<Restaurant.Bautura> bauturi = new List<Restaurant.Bautura>();
                    bauturi.Add(bautura);
                    Restaurant.Meniu meniu = new Restaurant.Meniu(preparate, bauturi);
                    Console.WriteLine("dati numarul de mese ");
                    string nrMese = Console.ReadLine();
                    Console.WriteLine("dati adresa");
                    string adresa = Console.ReadLine();
                    Console.WriteLine("dati numele restaurantului");
                    string numeRestaurant = Console.ReadLine();
                    Restaurant.Restaurant restaurant = new Restaurant.Restaurant(meniu, orar, Convert.ToInt16(nrMese), adresa, numeRestaurant);
                    restaurantebl.ModificareRestaurant(restaurant);
                }
                Console.WriteLine("Dati optiunea");
                opt = Console.ReadLine();
            }



        }
    }
}
