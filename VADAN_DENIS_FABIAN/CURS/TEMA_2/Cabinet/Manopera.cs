using Modele.Generic;
using System;
using System.Diagnostics.Contracts;


namespace Modele.Cabinet
{
    public class Manopera
    {
        public PlainText Nume { get; internal set; }
        

        internal Manopera(PlainText nume)
        {
            Contract.Requires(nume != null, "nume");
            Nume = nume;
        }


        #region override object
        public override string ToString()
        {
            return Nume.ToString();
        }

        public override bool Equals(object obj)
        {
            var manopera = (Manopera)obj;

            if (manopera != null)
            {
                return Nume.Equals(manopera.Nume);
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
