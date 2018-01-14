using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSSC_DDDModel.Modele.Farmacie
{
    class Medicament
    {
        public PlainText denumire { get; set; }
        public CodDeBare codDeBare { get; set; }
        public CategorieMedicament categorie { get; set; }


        public Medicament(string denumire, string codDeBare)
        {
            this.denumire = new PlainText(denumire);
            this.codDeBare = new CodDeBare(codDeBare);
        }

        #region override objects
        public override bool Equals(object obj)
        {
            var medicament = (Medicament)obj;
            return medicament.denumire.Equals(this.denumire)
                && medicament.codDeBare.Equals(this.codDeBare);
        }

        public override string ToString()
        {
            return this.denumire.ToString() + this.codDeBare.ToString();
        }

        public override int GetHashCode()
        {
            return this.codDeBare.GetHashCode()+
                this.denumire.GetHashCode();
        }
        #endregion
    }
}
