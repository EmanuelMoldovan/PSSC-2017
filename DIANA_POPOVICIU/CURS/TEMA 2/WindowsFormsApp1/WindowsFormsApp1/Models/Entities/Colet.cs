using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models.Entities
{
    public class Colet
    {
        private string destinatar;
        private string expeditor;
        private string data_sosire;
        private string numar_inregistrare;
        private bool depozitat;
        private string greutate;

        public Colet(string destinatar, string expeditor, string data_sosire, string numar_inregistrare, bool depozitat, string greutate)
        {
            this.destinatar = destinatar;
            this.expeditor = expeditor;
            this.data_sosire = data_sosire;
            this.numar_inregistrare = numar_inregistrare;
            this.depozitat = depozitat;
            this.greutate = greutate;
        }
        public Colet() { }
        override
       public string ToString()
        {
            string stare_depozit;
            if (this.depozitat == false)
            {
                stare_depozit = "in sucursala";
            }
            else
                stare_depozit = "in depozit";

            return "Destinatar: "+ this.destinatar + ", Expeditor: " + this.expeditor + "\nData sosire:  " + this.data_sosire
                + " , Numar inregistrare:" + this.numar_inregistrare + "\nGreutate: " + this.greutate + "; Stare: " + stare_depozit + "\n";
        }

        public string Destinatar { get => destinatar; set => destinatar = value; }
        public string Expeditor { get => expeditor; set => expeditor = value; }
        public string Data_sosire { get => data_sosire; set => data_sosire = value; }
        public string Numar_inregistrare { get => numar_inregistrare; set => numar_inregistrare = value; }
        public bool Depozitat { get => depozitat; set => depozitat = value; }
        public string Greutate { get => greutate; set => greutate = value; }


    }
}
