using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Gradina
{
    public class Gradina
    {
        public bool casaEsteDraguta = false;
        public int nrLocatie;
        public int locuriGradina = 10;

        public Flori Flori { get; internal set; }
        public Legume Legume { get; internal set; }
        public Pomi Pomi { get; internal set; }

        internal Gradina(int nrLocatie)
        {
            this.nrLocatie = nrLocatie;
            Flori = new Flori();
            Legume = new Legume();
            Pomi = new Pomi();
        }

        public void AdaugaFloare(string nume, string culoare, int numar)
        {
            var floare = Flori.Valori.FirstOrDefault(c => c.Nume.Equals(nume));
            if (locuriGradina > 0)
            {
                floare = new Floare(nume, culoare, numar);
                Flori.AdaugaFloare(floare);
                locuriGradina--;
            }
            else
            {
                Console.WriteLine("Nu mai sunt locuri in gradina");
            }
        }

        public void AdaugaLeguma(string nume, TipLeguma tip, int numar)
        {
            if (locuriGradina > 0)
            {
                var leguma = new Leguma(nume, tip, numar);
                Legume.AdaugaLeguma(leguma);
                locuriGradina--;
            }
            else
            {
                Console.WriteLine("Nu mai sunt locuri in gradina");
            }
        }

        public void AdaugaPom(string nume, int nota)
        {
            if (locuriGradina > 0)
            {
                var pom = new Pom(nume, nota);
                Pomi.AdaugaPom(pom);
                locuriGradina--;
            }
            else
            {
                Console.WriteLine("Nu mai sunt locuri in gradina");
            }
        }

        public void DecoreazaCasaCuFlori(string numeFloare, int numar)
        {
            var floare = Flori.Valori.FirstOrDefault(c => c.Nume.Equals(numeFloare));
            try
            {
                if (floare.Numar - numar < 0)
                    throw new NotEnoughFlowersException("Nu exista destule flori de tip " + floare.Nume);
                floare.Numar -= numar; 
                casaEsteDraguta = true;
                Console.WriteLine("Am decorat casa cu flori.");
            }
            catch (NotEnoughFlowersException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void AruncaFlorileDinCasa()
        {
            Console.WriteLine("Am aruncat florile.");
            casaEsteDraguta = false;
        }

        public void SalataDeNota10()
        {
            int count = 0;
            Console.Write("Am adaugat la salata fructe din urmatorii pomi: ");
            //primii 3 pomi cu nota mare
            foreach (Pom pom in Pomi.Valori)
            {
                if (count >= 3)
                    break;
                if (pom.Nota > 7)
                {
                    Console.Write(pom.Nume + " ");
                    count++;
                }               
            }
            Console.WriteLine();
        }

        public void LegumePentruCiorba()
        {
            //seleccteaza doar radacinoasele
            Console.Write("Am adaugat la ciorba: ");
            foreach (Leguma leguma in Legume.Valori)
            {               
                if (leguma.Tip == TipLeguma.Radacina)
                {
                    Console.Write(leguma.Nume + " ");
                }
            }
            Console.WriteLine();
        }

        #region override object
        public override string ToString()
        {
            return nrLocatie.ToString();
        }

        public override bool Equals(object obj)
        {
            var gradina = (Gradina)obj;

            if (gradina != null)
            {
                return nrLocatie.Equals(gradina.nrLocatie);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return nrLocatie.GetHashCode();
        }
        #endregion
    }
}
