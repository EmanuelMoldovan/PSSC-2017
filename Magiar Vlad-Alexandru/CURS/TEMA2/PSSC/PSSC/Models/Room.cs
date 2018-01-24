using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSSC
{
    public class Room
    {
        private int number;
        private int pers;
        private string vacancy;
        private string name;
        //public PlainText Name { get; internal set; }
        private string start_date;
        private string end_date;

        public int Number { get => number; set => number = value; }
        public int Pers { get => pers; set => pers = value; }
        public string Vacancy { get => vacancy; set => vacancy = value; }
        public string Name { get => name; set => name = value; }
        public string Start_date { get => start_date; set => start_date = value; }
        public string End_date { get => end_date; set => end_date = value; }

        public Room(int nr,int pers, string vacancy, string name, string start, string end)
        {
            Number = nr;
            this.Pers = pers;
            this.Vacancy = vacancy;
            this.Name = name;
            Start_date = start;
            End_date = end;
        }
    }
}
