using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant;

namespace RestaurantBL
{
     public class RestauranteBusinessLogic
    {
        public RestauranteBusinessLogic() { }
        public static List<Restaurant.Restaurant> restaurante = new List<Restaurant.Restaurant>();
        public  void AfisareRestaurante()
        {
            if (restaurante.Count == 0)
            {
                Console.WriteLine("Nu sunt restaurante");
            }
            else
            {
                foreach (Restaurant.Restaurant r in restaurante)
                {
                    Console.WriteLine(r.getNume());
                    
                    Console.WriteLine(r.getNrMese());
                }
            }
            
        }
        public void AdaugareRestaurante(Restaurant.Restaurant restaurant)
        {
            restaurante.Add(restaurant);
        }
        public void ModificareRestaurant(Restaurant.Restaurant restaurant)
        {
            bool succes = false;

            for (int i=0;i<restaurante.Count;i++)
            {
                if(string.Equals(restaurante[i].getNume(),restaurant.getNume()))
                {
                    restaurante[i] = restaurant;
                    succes = true;
                }
            }
            if (succes == false)
            {
                Console.WriteLine("Nu exista restaurantul");
            }
        }
        public void StergereRestaurant(string nume)
        {
            bool succes = false;

            for (int i = 0; i < restaurante.Count; i++)
            {
                if (string.Equals(restaurante[i].getNume(), nume))
                {
                    restaurante.RemoveAt(i);
                    succes = true;
                }
            }
            if (succes == false)
            {
                Console.WriteLine("Nu exista restaurantul");
            }

        }
        public List<Restaurant.Restaurant> getRestaurante()
        {
            return restaurante;
        }

    }
}
