using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.Pachete
{
    public class Pachet
    {
        public string numePachet;
        public int greutateMax = 2000;
        public int greutatePachet;
        public tip_Pachet tipPachet;
        public int pretPachet;

        public Pungi_FructeUscate FructeUscate { get; internal set; }
        public Pungi_Seminte Seminte { get; internal set; }
        public Pungi_Nuci Nuci { get; internal set; }


        public Pachet(int greutatePachet)
        {
            this.greutatePachet = greutatePachet;
        }
        internal Pachet(string numePachet, int greutatePachet, tip_Pachet tipPachet )
        {
            this.numePachet = numePachet;
            this.greutatePachet = greutatePachet;
            FructeUscate = new Pungi_FructeUscate();
            Nuci = new Pungi_Nuci();
            Seminte = new Pungi_Seminte();
        }

        public void AdaugaFructeUscate(tip_FructeUscate tipFructe, int cantitate, int greutate, int pret)
        {
            if(greutate < greutateMax) 
            {
                var pungaFructeUscate = new Punga_FructeUscate(tipFructe, cantitate, greutate, pret);
                do
                { 
                FructeUscate.AdaugaFructeUscate(pungaFructeUscate);
                greutateMax = greutateMax - greutate;
                pretPachet += pret;
                cantitate -= 1;

            } while (cantitate != 0) ;
        }
            else
            {
                Console.WriteLine("Depaseste greutatea maxima a pachetului!");
            }
        }

        public void AdaugaNuci(tip_Nuci tipNuci, int cantitate, int greutate, int pret)
        {
            if (greutate < greutateMax)
            {
                var pungaNuci = new Punga_Nuci(tipNuci, cantitate, greutate, pret);
                do
                {
                Nuci.AdaugaNuci(pungaNuci);
                greutateMax = greutateMax - greutate;
                pretPachet += pret;
                cantitate -= 1;

                } while (cantitate != 0);
            }
            else
            {
                Console.WriteLine("Depaseste greutatea maxima a pachetului!");
            }
        }

        public void AdaugaSeminte(tip_Seminte tipSeminte, int cantitate, int greutate, int pret)
        {
            if (greutate < greutateMax)
            {
                var pungaSeminte = new Punga_Seminte(tipSeminte, cantitate, greutate, pret);
                do
                {
                    Seminte.AdaugaSeminte(pungaSeminte);
                    greutateMax = greutateMax - greutate;
                    pretPachet += pret;
                    cantitate -= 1;

                } while (cantitate != 0);
            }
            else
            {
                Console.WriteLine("Depaseste greutatea maxima a pachetului!");
            }
        }

        #region override object
        public override string ToString()
        {
            return greutatePachet.ToString();
        }

        public override bool Equals(object obj)
        {
            var pachet = (Pachet)obj;

            if (pachet != null)
            {
                return greutatePachet.Equals(pachet.greutatePachet);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return greutatePachet.GetHashCode();
        }
        #endregion

    }
}
