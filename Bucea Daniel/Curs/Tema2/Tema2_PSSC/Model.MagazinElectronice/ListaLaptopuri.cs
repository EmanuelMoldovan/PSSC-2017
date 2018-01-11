using Model.Generic;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.MagazinElectronice
{
    public class ListaLaptopuri
    {
        private List<Laptop> listaLaptop;

        public List<Laptop> ListaLaptop { get { return listaLaptop; } }

        internal ListaLaptopuri()
        {
            listaLaptop = new List<Laptop>();
        }

        internal void adaugaLaptop(Laptop lap)
        {
            Contract.Requires(lap != null);
            listaLaptop.Add(lap);
        }

        internal void stergeLaptop(Laptop lap)
        {
            Contract.Requires(lap != null);
            listaLaptop.Remove(lap);
        }

        internal Object cautaLaptop(Procesor proc, PlacaVideo plaVid, string firma)
        {
            // returns null in case no laptop was found

            var laptop = listaLaptop.Find(lap => lap.proc.Equals(proc) && lap.placaVideo.Equals(plaVid) && lap.firma.Equals(firma));
            return laptop; 
        }
    }
}
