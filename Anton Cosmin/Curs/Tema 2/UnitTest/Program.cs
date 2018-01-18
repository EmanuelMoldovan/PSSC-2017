using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantBL;
using Xunit;

namespace UnitTest
{
    class Program
    {
        public void testAdaugareRestaurant()
        {
            RestaurantBL.RestauranteBusinessLogic restaurante = new RestaurantBL.RestauranteBusinessLogic();
            Restaurant.Restaurant restaurant = new Restaurant.Restaurant();
            restaurante.AdaugareRestaurante(restaurant);
            List<Restaurant.Restaurant> test = restaurante.getRestaurante();
            Assert.Equal(1, test.Count);

        }
        public void testStergereRestaurant()
        {
            RestaurantBL.RestauranteBusinessLogic restaurante = new RestaurantBL.RestauranteBusinessLogic();
            Restaurant.Restaurant restaurant = new Restaurant.Restaurant();
            restaurant.setNume("nume1");
            restaurante.AdaugareRestaurante(restaurant);
            Restaurant.Restaurant restaurant1 = new Restaurant.Restaurant();
            restaurant.setNume("nume2");
            restaurante.AdaugareRestaurante(restaurant1);
            Restaurant.Restaurant restaurant2 = new Restaurant.Restaurant();
            restaurant.setNume("nume3");
            restaurante.AdaugareRestaurante(restaurant2);
            List<Restaurant.Restaurant> test = restaurante.getRestaurante();
            Assert.Equal(3, test.Count);
            Assert.Equal("nume2", test[1].getNume());
            restaurante.StergereRestaurant("Nume2");
            List<Restaurant.Restaurant> test1 = restaurante.getRestaurante();
            Assert.Equal(2, test1.Count);
            Assert.Equal("nume3", test1[1].getNume());
        }
        public void testModificareRestaurant()
        {
            RestaurantBL.RestauranteBusinessLogic restaurante = new RestaurantBL.RestauranteBusinessLogic();
            Restaurant.Restaurant restaurant = new Restaurant.Restaurant();
            restaurant.setNrMese(5);
            restaurant.setNume("nume1");
            restaurante.AdaugareRestaurante(restaurant);
            Restaurant.Restaurant r = new Restaurant.Restaurant();
            r.setNrMese(8);
            restaurant.setNume("nume1");
            restaurante.ModificareRestaurant(r);
            List<Restaurant.Restaurant> test = restaurante.getRestaurante();
            Assert.Equal(test[0].getNrMese(), r.getNrMese());


        }
    }
}
