using Modele.Generic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;

namespace Modele.Cabinet
{
    public class Pacient
    {
        private string v1;
        private string v2;

        public CNP_Pacient CNP { get; internal set; }
        public PlainText Nume { get; internal set; }
        public Materiale MaterialeConsumate { get; internal set; }

        public Material PretFinal { get; internal set; }


        internal Pacient(CNP_Pacient cnpPacient, PlainText nume)
        {
            Contract.Requires(cnpPacient != null, "CNP Pacient");
            Contract.Requires(nume != null, "nume");
            CNP = cnpPacient;
            Nume = nume;
            MaterialeConsumate = new Materiale();
       
        }

        public Pacient(string v1, string v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        #region operations
        internal void CalculeazaPret()
        {
            Contract.Requires(MaterialeConsumate != null, "materiale consumate");

            PretFinal = new Material(MaterialeConsumate.PretTotal.Pret);


        }
        #endregion

        #region object override
        public override string ToString()
        {
            return string.Format("{0}:{1}", CNP, Nume);
        }

        public override bool Equals(object obj)
        {
            var student = (Pacient)obj;

            if (student != null)
            {
                return CNP.Equals(student.CNP);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return CNP.GetHashCode();
        }
        #endregion
    }
}
