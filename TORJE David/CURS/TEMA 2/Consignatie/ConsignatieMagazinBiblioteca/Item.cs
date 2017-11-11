using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsignatieMagazinBiblioteca
{
    public class Item
    {
        public string Title { get; set; }
        public string Descriere { get; set; }
        public decimal Pret { get; set; }
        public bool Sold { get; set; }
        public int NumberOfItems { get; set; }
        public bool Duplicate { get; set; }
        public int SoldItems { get; set; }
        public Furnizor Owner { get; set; }

        public Item()
        {
            NumberOfItems = 1;
            Duplicate = false;
            SoldItems = 0;
        }

        public Item(string Title, string Descriere, decimal Pret, int NumberOfItems, 
            bool Duplicate, Furnizor Owner)
        {
            this.Title = Title;
            this.Descriere = Descriere;
            this.Pret = Pret;
            this.Sold = Sold;
            this.NumberOfItems = NumberOfItems;
            this.Duplicate = Duplicate;
            this.SoldItems = 0;
            this.Owner = Owner;
        }

        public string toString
        {
            get
            {
                return string.Format("{0} - ${1} -> Stoc: {2}", Title, Pret, NumberOfItems);
            }
        }

        public string Display
        {
            get
            {
                return string.Format("{0} - ${1} -> Total: {2}", Title, Pret, SoldItems);
            }
        }
    }
}
