using Modele.Generic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;

namespace Modele.Etaj
{
    public class Etaj
    {
        public PlainText Numar { get; internal set; }
        public int PretMediu { get; internal set; }

        private List<Oaspete> _listaOaspeti;
        public ReadOnlyCollection<Oaspete> RezervariOaspeti { get { return _listaOaspeti.AsReadOnly(); } } 
        
        public StareRezervari Stare { get; internal set; }
        public CamereEtaj CamereEtaj { get; internal set; }
        
        internal Etaj(PlainText numar, int mediePret)
        {
            Contract.Requires(numar != null, "numar");

            Numar = numar;
            PretMediu = mediePret;
            _listaOaspeti = new List<Oaspete>();
            Stare = StareRezervari.Rezervare;
            CamereEtaj = new CamereEtaj();
        }

        internal Etaj(PlainText numar, int mediePret, List<Oaspete> listaOaspeti)
            :this(numar, mediePret)
        {
            Contract.Requires(listaOaspeti != null, "lista de oaspeti inscrisi");
            _listaOaspeti = listaOaspeti;
        }

        #region operatii
        public void RezervareOaspeti(Oaspete oaspete)
        {
            Contract.Requires(oaspete != null, "oaspete");
            Contract.Requires(Stare == StareRezervari.Rezervare, "nu suntem in perioada in care se fac rezervari");

            var gasit = _listaOaspeti.FirstOrDefault(s => s.Equals(oaspete));
            if (gasit == null)
            {
                _listaOaspeti.Add(oaspete);
            }
            else
            {
                throw new OaspeteleExistaExceptions();
            }
        }

        public void IncepeSezonul()
        {
            Contract.Requires(Stare == StareRezervari.Rezervare, "nu suntem in perioada in care se fac rezervari");
            Stare = StareRezervari.Cazat;
        }

        public void inchidereSezon()
        {
            Contract.Requires(Stare == StareRezervari.Cazat, "cazarea nu a inceput");

            foreach (var oaspete in _listaOaspeti)
            {
                oaspete.CalculeazaNotaDePlataFinala();
            }
            Stare = StareRezervari.Plecat;
        }

        public void SetareAvans(long cnp, int avas)
        {
            Contract.Requires(Stare == StareRezervari.Cazat, "cazarea nu a inceput");

            var oaspete = _listaOaspeti.First(s => s.CNP.Equals(cnp));
            oaspete.Avans = avas;
        }

        #endregion

        #region override object
        public override string ToString()
        {
            return Numar.ToString();
        }

        public override bool Equals(object obj)
        {
            var etaj = (Etaj)obj;

            if (etaj != null)
            {
                return Numar.Equals(etaj.Numar);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Numar.GetHashCode();
        }
        #endregion
    }
}
