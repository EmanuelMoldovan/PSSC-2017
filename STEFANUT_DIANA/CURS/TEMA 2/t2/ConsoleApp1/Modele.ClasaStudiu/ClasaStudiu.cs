using Modele.Generic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using Modele.Generic.Exceptions;

namespace Modele.ClasaStudiu
{
    public class ClasaStudiu
    {
        public PlainText NumeClasa { get; internal set; }

        private List<Elev> _elevi;
        public ReadOnlyCollection<Elev> Elevi { get { return _elevi.AsReadOnly(); } }

        internal ClasaStudiu(PlainText nume)
        {
            Contract.Requires(nume != null, "nume");

            NumeClasa = nume;

            _elevi = new List<Elev>();

        }

        internal ClasaStudiu(PlainText nume, List<Elev> elevi) : this(nume)
        {
            Contract.Requires(elevi != null, "Elevi existenti");
            _elevi = elevi;
        }




        public void InscrieNotaElev(Elev elev)
        {
            Contract.Requires(elev != null, "elev");

            var gasit = _elevi.FirstOrDefault(s => s.Equals(elev));
            if (gasit == null)
            {
                _elevi.Add(elev);
            }
            else
            {
                throw new Exception("Elevul exista");
            }
        }
    }
}
