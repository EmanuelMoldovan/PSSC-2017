using Model.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ParcAuto
{
    public class Masina
    {
        public TipMasina Tip { get; private set; }
        public PlainText Marca { get; private set; }
        public PlainText An { get; private set; }
        public PlainText kilometraj { get; private set; }
        public PlainText Descriere { get; private set; }

        public Masina(TipMasina tip,PlainText marca,PlainText an, PlainText km,PlainText descriere)
        {
            Tip = tip;
            Marca = marca;
            An = an;
            kilometraj = km;
            Descriere = descriere;
        }

        public override string ToString()
        {
            return Tip + ", " + Marca + ", " + An + ", " + kilometraj + ", " + Descriere;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }


    }
}
