using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisciplinaFactory
{
    public class Factory
    {
        public static readonly Factory Instance = new Factory();


        public Disciplina CreareDisciplina(string Nume)
        {
            var disciplina = new Disciplina(Nume);

            return disciplina;
        }

        public Tip CreareTip(string Nume)
        {
            var tip = new Tip(Nume);

            return tip;
        }

        public Produs CreareProdus(string Nume, double Pret, string Cantitate, string data,int Bucati)
        {
            DateTime d = Convert.ToDateTime(data);
            var produs = new Produs(Nume,Pret,Cantitate,d,Bucati);

            return produs;
        }

        public void AfisareDisciplina(Disciplina disciplina)
        {
            var dis = disciplina;

            Console.WriteLine(dis.ToString());
            Console.WriteLine("Press any key to terminate.");
            Console.ReadLine();
        }

        private int NrTotalProduseVandute(Disciplina disciplina)
        {
            int nrprod = 0;
            foreach (Tip tp in disciplina.Inventar.ListaInventar)
            {
                foreach (Produs pr in tp.ListaProduse)
                {
                    nrprod+=pr.NrBucati;
                }

            }
            return nrprod;
        }

        private double SumaTotalVanzari(Disciplina disciplina)
        {
            double sum = 0;
            foreach (Tip tp in disciplina.Inventar.ListaInventar)
            {
                foreach (Produs pr in tp.ListaProduse)
                {
                    sum += pr.Pret*pr.NrBucati;
                }
            }
            return sum;
        }

        public void AfisareInventar(Disciplina disciplina)
        {
            if (disciplina.Stare == State.Stare.Inventar)
            {
                Console.WriteLine("\n   Inventarul:\n");
                Console.WriteLine(disciplina.Inventar.ToString());

                Console.WriteLine("Numarul total de produse vandute: " + NrTotalProduseVandute(disciplina));

                Console.WriteLine("Suma total de vanzari: " + SumaTotalVanzari(disciplina) + " lei");
                Console.WriteLine("\n\n");

            }
            else
            {
                Console.WriteLine("Nu suntem in perioada de inventar\n");
            }
        }

    }
}
