using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSSC_DDDModel.Modele.Farmacie
{
    class Farmacia
    {
        public PlainText nume { get; set; }
        public Adresa adresa { get; set; }
        public List<Medicament> medicamente;

        public Farmacia(string nume)
        {
            this.nume = new PlainText(nume);
            this.medicamente = new List<Medicament>();
        }

        public int StocMedicamente()
        {
            return medicamente.Count;
        }

        public int CautaStocMedicamente(string denumire)
        {
            var nr = medicamente.Count(m => m.denumire.Text == denumire);
            return nr;
        }

        public int CautaStocMedicamenteDupaBarcode(string codDeBare)
        {
            var nr = medicamente.Count(m => m.codDeBare.Value == codDeBare);
            return nr;
        }

        public void AdaugareMedicament(string denumire, string codDeBare)
        {
            Medicament med = new Medicament(denumire, codDeBare);
            medicamente.Add(med);
        }

    }
}
