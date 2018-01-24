using Modele.Generic;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;

namespace Modele.Consultatie
{
    public class Consultatie
    {
        public int NrConsultatie { get; internal set; }
        public PlainText NumePacient { get; internal set; }
        public PlainText NumeMedic { get; internal set; }

        internal Consultatie(int _nrconsultatie, PlainText _numepacient, PlainText _numemedic)
        {
            Contract.Requires(_nrconsultatie != 0, "nrconsultatie");
            NumePacient = _numepacient;

            Contract.Requires(_numepacient != null, "numepacient");
            NrConsultatie = _nrconsultatie;

            Contract.Requires(_numemedic != null, "numemedic");
            NumeMedic = _numemedic;

        }

        #region override object
        public override string ToString()
        {
            return NrConsultatie.ToString() + NumeMedic.ToString() + NumePacient.ToString();
        }

        public override bool Equals(object obj)
        {
            var consultatie = (Consultatie)obj;

            if (consultatie != null)
            {
                return Equals(consultatie.NrConsultatie) && Equals(consultatie.NumeMedic) &&
                    Equals(consultatie.NumePacient);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return NrConsultatie.GetHashCode();
        }
        #endregion

    }
}
