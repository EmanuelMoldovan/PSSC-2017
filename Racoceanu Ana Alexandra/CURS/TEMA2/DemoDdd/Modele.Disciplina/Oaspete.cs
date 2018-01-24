using Modele.Generic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;

namespace Modele.Etaj
{
    public class Oaspete
    {
        public long CNP { get; internal set; }
        public PlainText Nume { get; internal set; }
        public int Avans { get; internal set; }
        public int NotaDePlataFinala {get; internal set;}
        

        internal Oaspete(long cnp, PlainText nume)
        {
            Contract.Requires(nume != null, "nume");
            CNP = cnp;
            Nume = nume;
            Avans = 0;
        }

        #region operations
        internal void CalculeazaNotaDePlataFinala()
        {
            NotaDePlataFinala = NotaDePlataFinala - Avans;
        }

        #endregion

        #region object override
        public override string ToString()
        {
            return string.Format("{0}:{1}", CNP, Nume);
        }

        public override bool Equals(object obj)
        {
            var student = (Oaspete)obj;

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
        public int getNotaDePlata()
        {
            return NotaDePlataFinala;
        }
    }
}
