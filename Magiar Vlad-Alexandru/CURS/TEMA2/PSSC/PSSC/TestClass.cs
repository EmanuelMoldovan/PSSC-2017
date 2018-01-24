using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSSC
{
    [TestFixture]
    class TestClass
    {

        [TestCase(25, 3, "occupied", "Victor", "29 octombrie 2017", "29 octombrie 2017")]
        public void ROom(int a, int b, string c, string d, string e, string f)
        {
            Room r = new Room(25, 3, "occupied", "Victor", "29 octombrie 2017", "29 octombrie 2017");

            Assert.AreEqual(a, r.Number);
            Assert.AreEqual(b, r.Pers);
            Assert.AreEqual(c, r.Vacancy);
            Assert.AreEqual(d, r.Name);
            Assert.AreEqual(e, r.Start_date);
            Assert.AreEqual(f, r.End_date);

            Assert.AreNotEqual(a+1, r.Number);
            Assert.AreNotEqual(b+1, r.Pers);
            Assert.AreNotEqual(c+"asd", r.Vacancy);
            Assert.AreNotEqual(d+"dww", r.Name);
            Assert.AreNotEqual(e+"gd", r.Start_date);
            Assert.AreNotEqual(f+"fds", r.End_date);

           

        }

        [TestCase(3, 25, 3, "occupied", "Victor", "29 octombrie 2017", "29 octombrie 2017")]
        public void FLoor(int a, int a1, int b, string c, string d, string e, string f)
        {
            Room r = new Room(25, 3, "occupied", "Victor", "29 octombrie 2017", "29 octombrie 2017");
            List<Room> rooms= new List<Room>();
                rooms.Add(r);
              Floor fl = new Floor(3, rooms);

            Assert.AreEqual(a, fl.Number);
            Assert.AreEqual(rooms, fl.Rooms);

            Assert.AreEqual(a1, fl.Rooms[0].Number);
            Assert.AreEqual(b, fl.Rooms[0].Pers);
            Assert.AreEqual(c, fl.Rooms[0].Vacancy);
            Assert.AreEqual(d, fl.Rooms[0].Name);
            Assert.AreEqual(e, fl.Rooms[0].Start_date);
            Assert.AreEqual(f, fl.Rooms[0].End_date);

        }

        [TestCase(3, 25, 3, "occupied", "Victor", "29 octombrie 2017", "29 octombrie 2017")]
        public void HOtel(int a, int a1, int b, string c, string d, string e, string f)
        {
            Room r = new Room(25, 3, "occupied", "Victor", "29 octombrie 2017", "29 octombrie 2017");
            List<Room> rooms = new List<Room>();
            rooms.Add(r);
            Floor fl = new Floor(3, rooms);
            List<Floor> floors = new List<Floor>();
            floors.Add(fl);
            Hotel h1 = new Hotel(floors);

            Assert.Contains(r, h1.floors[0].Rooms);
       
            Assert.AreEqual(fl, h1.floors[0]);

            Assert.AreEqual(a, h1.floors[0].Number);
            Assert.AreEqual(rooms, h1.floors[0].Rooms);

            Assert.AreEqual(a1, h1.floors[0].Rooms[0].Number);
            Assert.AreEqual(b, h1.floors[0].Rooms[0].Pers);
            Assert.AreEqual(c, h1.floors[0].Rooms[0].Vacancy);
            Assert.AreEqual(d, h1.floors[0].Rooms[0].Name);
            Assert.AreEqual(e, h1.floors[0].Rooms[0].Start_date);
            Assert.AreEqual(f, h1.floors[0].Rooms[0].End_date);

        }
        

        [TestCase(5,7)]
        public void BillingPositiveResponseExpected(int a, int b)
        {
            CalculateBill calc= new CalculateBill(a,b);
            Assert.AreEqual( 3500,calc.Total());
            
        }

        [TestCase(5, 7)]
        public void BillingNegativeResponseExpected(int a, int b)
        {
            CalculateBill calc = new CalculateBill(a, b);
            Assert.AreNotEqual(350, calc.Total());
           
        }

       

    }
}
