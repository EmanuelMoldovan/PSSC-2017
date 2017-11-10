using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Generic;
using System.Diagnostics.Contracts;

namespace Model.Internare
{
    public class Pacient
    {
        public PlainText Nume { get; internal set; }
        public PlainText Prenume { get; internal set; }
        public int Varsta { get; internal set; }
        public Cnp Cnp { get; internal set; }
        public Mediu Mediu { get; internal set; }
        public StarePacient Stare { get; internal set; }
        public Investigatii Investigatii { get; internal set; }
        public EvolutiePacient EvolutiePacient { get; internal set; }

        public Pacient(PlainText nume, PlainText prenume, int varsta, Cnp cnp, Mediu mediu, StarePacient stare, Investigatii investigatii)
        {
            Contract.Requires(nume != null, "nume");
            Contract.Requires(prenume != null, "prenume");
            Contract.Requires(varsta != 0, "varsta");
            Contract.Requires(cnp != null, "cnp");
            Contract.Requires(investigatii != null, "investigatii");
            Nume = nume;
            Prenume = prenume;
            Varsta = varsta;
            Cnp = cnp;
            Mediu = mediu;
            Stare = stare;
            Investigatii = investigatii;
        }

        #region operatii
        public void ActualizareEvolutiePacient(EvolutiePacient evolutie)
        {
            this.EvolutiePacient = evolutie;
        }

        public void ActualizareStarePacient(StarePacient stare)
        {
            this.Stare = stare;
        }
        #endregion

        #region override object
        public override string ToString()
        {
            return Nume.ToString();
        }

        public override bool Equals(object obj)
        {
            var cnp = (Cnp)obj;

            if (cnp != null)
            {
                return Cnp.Equals(cnp);
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
