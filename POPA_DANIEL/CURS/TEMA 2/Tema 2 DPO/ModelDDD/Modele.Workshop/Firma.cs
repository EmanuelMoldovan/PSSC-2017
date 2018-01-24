using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modele.Generic;
using System.Diagnostics.Contracts;

namespace Modele.Workshop
{
    public class Firma
    {
        public IdParticipare IdParticipare { get; internal set; }

        public PlainText Nume { get; internal set; }
        public Preturi PreturiActivitati { get; internal set; }
        public Pret PretPachet { get; internal set; }
        public Pret PretTotal { get; internal set; }

        internal Firma(IdParticipare idParticipareFirma, PlainText nume)
        {
            Contract.Requires(idParticipareFirma != null, "Id participare");
            Contract.Requires(nume != null, "nume");
            IdParticipare = idParticipareFirma;
            Nume = nume;
            PreturiActivitati = new Preturi();
        }
        #region operations

        internal void CalculeazaPretTotal(Punctaj punctaj)
        {
            Contract.Requires(punctaj != null, "punctaj");
            Contract.Requires(PretPachet != null, "pret pachet");
            Contract.Requires(PreturiActivitati.Media.Valoare != null, "preturi activitati");

            var valPunctaj = punctaj.Calcul;         /////////////////////////////
            PretTotal = new Pret(Math.Round(valPunctaj * PretPachet.Valoare + (1 - valPunctaj) * PreturiActivitati.Media.Valoare));
        }
        #endregion

        #region object override
        public override string ToString()
        {
            return string.Format("{0}:{1}", IdParticipare, Nume);
        }

        public override bool Equals(object obj)
        {
            var firma = (Firma)obj;
            if (firma != null)
            {
                return IdParticipare.Equals(firma.IdParticipare);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return IdParticipare.GetHashCode();
        }
        #endregion
    }
}
