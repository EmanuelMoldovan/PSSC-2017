using Modele.Generic;
using Modele.Consultatie;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;

namespace Modele.Cabinet
{
    public class Cabinet
    {
        public PlainText NumeCabinet { get; internal set; }

        private List<Pacient> _pacientiProgramati;
        public ReadOnlyCollection<Pacient> PacientiProgramati
        {
            get
            {
                return _pacientiProgramati.AsReadOnly();
            }
        }

        public StareCabinet Stare { get; internal set; }
        public Manopera Manopere { get; internal set; }
        public Consultatii Consultatii { get; internal set; }

        internal Cabinet(PlainText numecabinet)
        {
            Contract.Requires(numecabinet != null, "numecabinet");

            NumeCabinet = numecabinet;
            _pacientiProgramati = new List<Pacient>();
            Stare = StareCabinet.Disponibil;
            Manopere = new Manopere();
            Consultatii = new Consultatii();
        }

        internal Cabinet(PlainText NumeCabinet, List<Pacient> PacientiProgramati)
            : this(NumeCabinet)
        {
            Contract.Requires(PacientiProgramati != null, "lista de pacienti programati");
            _pacientiProgramati = PacientiProgramati;
        }

        #region operatii
        public void ProgramarePacient(Pacient pacient)
        {
            Contract.Requires(pacient != null, "pacient");
            Contract.Requires(Stare == StareCabinet.Disponibil, "alta persoana este programata la acea ora");

            var gasit = _pacientiProgramati.FirstOrDefault(s => s.Equals(pacient));
            if (gasit == null)
            {
                _pacientiProgramati.Add(pacient);
            }
            else
            {
                throw new PacientulExistaExceptions();
            }
        }

        public void IncepeConsultatie()
        {
            Contract.Requires(Stare == StareCabinet.Disponibil, "Cabinetul nu este disponibil!");
            Stare = StareCabinet.Ocupat;
        }

        public void IncheieConsultatie()
        {
            Contract.Requires(Stare == StareCabinet.Ocupat, "Cabinetul nu este disponibil!");


            foreach (var pacient in _pacientiProgramati)
            {
                pacient.CalculeazaPret();
            }
            Stare = StareCabinet.Disponibil;
        }


        #endregion

        #region override object
        public override string ToString()
        {
            return NumeCabinet.ToString();
        }

        public override bool Equals(object obj)
        {
            var disciplina = (Cabinet)obj;

            if (disciplina != null)
            {
                return NumeCabinet.Equals(disciplina.NumeCabinet);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return NumeCabinet.GetHashCode();
        }
        #endregion
    }
}
