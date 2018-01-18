using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models.Entities
{
    public class Scrisoare
    {
        private string destinatar;
        private string expeditor;
        private string data_sosire;
        private bool recomandata;

        public Scrisoare(string destinatar, string expeditor, string data, bool recomandata)
        {
            this.destinatar = destinatar;
            this.expeditor = expeditor;
            this.data_sosire = data;
            this.recomandata = recomandata;
        }
        public Scrisoare() { }
        override
        public string ToString()
        {
            string tip_srisoare;
            if (this.recomandata == false)  tip_srisoare = "Scrisoare fara regim special";
            else tip_srisoare = "Scrisoare in regim RECOMANDAT";

            return "Destinatar: " + this.destinatar + ", Expeditor: " + this.expeditor + "\nData sosire:  " + this.data_sosire
                + ", " + tip_srisoare + "\n";
        }
        public string Destinatar { get => destinatar; set => destinatar = value; }
        public string Expeditor { get => expeditor; set => expeditor = value; }
        public string Data_sosire { get => data_sosire; set => data_sosire = value; }
        public bool Recomandata { get => recomandata; set => recomandata = value; }
    }
}
