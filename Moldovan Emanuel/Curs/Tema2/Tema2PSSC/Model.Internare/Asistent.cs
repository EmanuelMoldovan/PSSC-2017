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
    public class Asistent
    {
        public PlainText Nume { get; internal set; }
        public PlainText Prenume { get; internal set; }
        public Semnatura Semnatura { get; internal set; }
        private List<Pacient> _pacientiInregistrati = new List<Pacient>();

        public Asistent(PlainText nume, PlainText prenume, Semnatura semnatura)
        {
            Contract.Requires(nume != null, "nume");
            Contract.Requires(prenume != null, "prenume");
            Contract.Requires(semnatura != 0, "semnatura");
            Nume = nume;
            Prenume = prenume;
            Semnatura = semnatura;
        }

        #region operatii
        public void InregistrarePacient(Pacient pacient)
        {
            Contract.Requires(pacient != null, "pacient");
            Contract.Requires(pacient.Stare == StarePacient.Minor, "mai asteapta");

            var gasit = _pacientiInregistrati.FirstOrDefault(s => s.Equals(pacient));
            if (gasit == null)
            {
                _pacientiInregistrati.Add(pacient);
            }
            else
            {
                throw new PacientulExistaExceptions();
            }
        }

        public List<Pacient> GetPacienti()
        {
            return _pacientiInregistrati;
        }

        public void ModificareStarePacient(StarePacient stare, Pacient pacient)
        {
            pacient.ActualizareStarePacient(stare);
        }

        public Pacient EfectuareInvestigatii(Pacient pacient, Investigatii investigatii)
        {
            Contract.Requires(EvolutiePacient.Externare == pacient.EvolutiePacient, "pacientul a fost externat");
            pacient.ActualizareEvolutiePacient(EvolutiePacient.Anamneza);
            pacient.Investigatii = investigatii;

            return pacient;
        }

        public void InchideFisa(Pacient pacient)
        {
            Contract.Requires(pacient.EvolutiePacient == EvolutiePacient.Anamneza, "nu se poate face inchiderea");

            pacient.ActualizareEvolutiePacient(EvolutiePacient.Externare);
        }
        #endregion

        #region override object
        public override string ToString()
        {
            return Nume.ToString();
        }

        public override bool Equals(object obj)
        {
            var disciplina = (Asistent)obj;

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
