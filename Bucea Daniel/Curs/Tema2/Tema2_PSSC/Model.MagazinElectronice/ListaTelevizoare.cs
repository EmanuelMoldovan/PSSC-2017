using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.MagazinElectronice
{
    public class ListaTelevizoare
    {

        public List<Televizor> Televizoare { get; internal set; }

        internal ListaTelevizoare()
        {
            Televizoare = new List<Televizor>();
        }

        internal void adaugaTelevizor(Televizor tel)
        {
            Contract.Requires(tel != null);
            Televizoare.Add(tel);
        }

        internal void stergeTV(Televizor tel)
        {
            Contract.Requires(tel != null);
            Televizoare.Remove(tel);
        }

        internal Object cautaTV(double dimEcran, TipTelevizor tipTV ,string firma)
        {
            // returns null in case no TV was found

            var televizor = Televizoare.Find(tel => tel.DimEcran.Equals(dimEcran) && tel.TipTelevizor.Equals(tipTV) && tel.firma.Equals(firma));
            return televizor;
        }


    }
}
