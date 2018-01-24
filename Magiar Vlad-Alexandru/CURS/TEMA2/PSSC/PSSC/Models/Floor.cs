using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSSC
{
    public class Floor
    {
        private int number;
        private List<Room> rooms;

        public int Number { get => number; set => number = value; }
        public List<Room> Rooms { get => rooms; set => rooms = value; }

        public Floor(int number, List<Room> rooms)
        {
            this.Number = number;
            this.Rooms = rooms;
        }
    }
}
