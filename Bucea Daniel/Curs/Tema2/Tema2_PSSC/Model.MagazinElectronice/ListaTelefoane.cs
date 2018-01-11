using Model.Generic;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.MagazinElectronice
{
    public class ListaTelefoane
    {
        private List<Telefon> listaTelefon;

        public List<Telefon> ListaTElefon { get { return listaTelefon; } }

        internal ListaTelefoane()
        {
            listaTelefon = new List<Telefon>();
        }

        internal void adaugaTelefon(Telefon tel)
        {
            Contract.Requires(tel != null, "Telefonul adaugat trebuie sa existe");
            listaTelefon.Add(tel);
        }

        internal void stergeTelefon(Telefon tel)
        {
            Contract.Requires(tel != null, "Pentru a sterge telefonul acesta trebuie sa fie in stoc");
            listaTelefon.Remove(tel);
        }

        internal Object cautaTelefon(Procesor proc, int memorie, string firma)
        {
            // returns null in case no telefon was found


            var telefon = listaTelefon.Find(tel => tel.proc.Equals(proc) && tel.memorie == memorie && tel.firma.Equals(firma));
            return telefon;
        }
    }
}
