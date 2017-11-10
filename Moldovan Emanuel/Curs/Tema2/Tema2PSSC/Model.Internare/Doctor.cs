using Model.Generic;
using Model.Generic.Exceptions;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Internare
{
    public class Doctor
    {
        public PlainText Nume { get; internal set; }
        public PlainText Prenume { get; internal set; }
        public Semnatura Semnatura { get; internal set; }
        public PlainText CodParafa { get; internal set; }
        private List<Asistent> _asistenti;

        public Doctor(PlainText nume, PlainText prenume, Semnatura semnatura, PlainText codParafa)
        {
            Contract.Requires(nume != null, "nume");
            Contract.Requires(prenume != null, "prenume");
            Contract.Requires(semnatura != 0, "semnatura");
            Nume = nume;
            Prenume = prenume;
            Semnatura = semnatura;
        }

        #region operatii
        public void AdaugaAsistent(Asistent asistent)
        {
            Contract.Requires(asistent != null, "asistent");

            var gasit = _asistenti.FirstOrDefault(s => s.Equals(asistent));
            if (gasit == null)
            {
                _asistenti.Add(asistent);
            }
            else
            {
                throw new AsistentExistaExceptions();
            }
        }
        public void EfectuareAnamneza(Pacient pacient)
        {

        }

        public List<Asistent> GetAsistente()
        {
            return _asistenti;
        }

        public void CoordoneazaAsistentul(Pacient pacient, Asistent asistent)
        {
            asistent.InregistrarePacient(pacient);
        }

        public void InternarePacient(Pacient pacient)
        {
            pacient.ActualizareEvolutiePacient(EvolutiePacient.Internare);
        }

        public void ExternarePacient(Pacient pacient, Asistent asistent)
        {
            asistent.InchideFisa(pacient);
        }

        public void ActualizareStarePacient(Pacient pacient, Asistent asistent, StarePacient stare)
        {
            asistent.ModificareStarePacient(stare, pacient);
        }

        public Investigatii Auscultatie(Pacient pacient)
        {
            Contract.Requires(pacient.Investigatii != null, "investigatiile nu au fost efectuate");
            return pacient.Investigatii;
        }
        #endregion

        #region override object
        public override string ToString()
        {
            return Nume.ToString();
        }

        public override bool Equals(object obj)
        {
            var disciplina = (Doctor)obj;

            if (disciplina != null)
            {
                return Nume.Equals(disciplina.Nume);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Nume.GetHashCode();
        }
        #endregion
    }
}
