using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Masina;
using Brand;
using Disciplina;

namespace DisciplinaFactory
{
    public class DisciplinaFactory
    {
        public static readonly DisciplinaFactory Instance = new DisciplinaFactory();

        
        public Disciplina.Disciplina CreareDisciplina(string Nume)
        {
            var disciplina = new Disciplina.Disciplina(Nume);

            return disciplina;
        }

        public Brand.Brand CreareBrand(string Nume)
        {
            var brand = new Brand.Brand(Nume);
           
            return brand;
        }


        public Masina.Masina CreareMasina(string Model, int CapMotor, int Hp, string Culoare, int Pret)
        {
            var masina = new Masina.Masina(Model, CapMotor, Hp, Culoare, Pret);

            return masina;
        }

        public void AfisareDisciplina(Disciplina.Disciplina disciplina)
        {
            var dis = disciplina;
            
            Console.WriteLine(dis.ToString());
            Console.WriteLine("Press any key to terminate.");
            Console.ReadLine();
        }

        private int NrTotalMasinivandute(Disciplina.Disciplina disciplina)
        {
            int nrmasini=0;
            foreach (Brand.Brand b in disciplina.Inventar.ListaInventar)
            {
               foreach(Masina.Masina m in b.ListaMasini)
                {
                    nrmasini++;
                }
               
            }
            return nrmasini;
        }
        private int SumaTotalVanzari(Disciplina.Disciplina disciplina)
        {
            int sum = 0;
            foreach (Brand.Brand b in disciplina.Inventar.ListaInventar)
            {
                foreach (Masina.Masina m in b.ListaMasini)
                {
                    sum += m.Pret;
                }
            }
            return sum;
        }

        public void AfisareInventar(Disciplina.Disciplina disciplina)
        {
            if (disciplina.Stare == State.Stare.Inventar)
            {
                Console.WriteLine("\n   Inventarul:\n");
                Console.WriteLine(disciplina.Inventar.ToString());

                Console.WriteLine("Numarul total de masini vandute: "+ NrTotalMasinivandute(disciplina));
               
                Console.WriteLine("Suma total de vanzari: "+ SumaTotalVanzari(disciplina));
                Console.WriteLine("\n\n");

            }
            else
            {
                Console.WriteLine("Nu suntem in perioada de inventar\n");
            }
        }

    }
}
