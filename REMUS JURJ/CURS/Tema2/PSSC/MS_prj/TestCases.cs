using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace PSSC
{
    [TestFixture]
    class TestCases
    {
        [TestCase("Wine","2",1)]
        public void Set_Drinks(string drink, string amount, int order_nr)
        {
            Drinks new_drink = new Drinks(drink, amount, order_nr);
            Assert.AreEqual("Wine", drink);
            Assert.AreNotEqual("3", amount);
            Assert.AreEqual(1, order_nr);
        }

        [TestCase("Pizza", "4", 2)]
        public void Set_Food(string food, string amount, int order_nr)
        {
            Food new_food = new Food(food, amount, order_nr);
            Assert.IsNotEmpty(food);
            Assert.AreEqual("Pizza", food);
            Assert.Greater(3, order_nr);
            Assert.IsNotNull(amount);
            Assert.AreNotEqual(amount,"3");
        }

        [TestCase("Remus Jurj", "10", 5)]
        public void Set_Order(string waiter, string table, int order_nr)
        {
            Order new_order = new Order(waiter, table, order_nr);
            Assert.IsNotNull(waiter);
            Assert.AreEqual("Remus Jurj", waiter);
            Assert.AreNotEqual("100", table);
            Assert.Less(4, order_nr);
        }

        [TestCase("Remus Jurj", "10", "5", "pizza","2")]
        public void Get_Data(string waiter, string table, string order_nr, string order, string amount)
        {
            GetXmlData new_data = new GetXmlData(waiter, order_nr, table, order, amount);
            Assert.IsNotNull(waiter);
            Assert.AreEqual("Remus Jurj", waiter);
            Assert.AreNotEqual("100", table);
            Assert.AreNotEqual("4", order_nr);
            Assert.AreEqual(order,"pizza");
            Assert.AreEqual(amount,"2");
        }
    }
}