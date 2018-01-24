using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //creare repo
            var repository = new DisciplinaRepository.Repository();

            //creare disciplina
            var disciplina = DisciplinaFactory.Factory.Instance.CreareDisciplina("Alimentara");

            //adaugare disciplina in repository
            repository.AdaugaDisciplina(disciplina);

            //Incepem cumparaturile
            disciplina.IncepeCumpararea();

            //adaugare tipuri de alimente
            disciplina.AdaugaTip(DisciplinaFactory.Factory.Instance.CreareTip("Lactate"));
            disciplina.AdaugaTip(DisciplinaFactory.Factory.Instance.CreareTip("Carne"));
            disciplina.AdaugaTip(DisciplinaFactory.Factory.Instance.CreareTip("Peste"));

            //adaugare produse
            disciplina.AdaugaProdus("Lactate", DisciplinaFactory.Factory.Instance.CreareProdus("Lapte", 3.49 , "1l", "05/05/2018", 30));
            disciplina.AdaugaProdus("Lactate", DisciplinaFactory.Factory.Instance.CreareProdus("Iaurt", 2.29, "200ml", "07/20/2018", 40));
            disciplina.AdaugaProdus("Carne", DisciplinaFactory.Factory.Instance.CreareProdus("Costita de porc", 14.99, "1kg", "02/10/2018", 8));
            disciplina.AdaugaProdus("Carne", DisciplinaFactory.Factory.Instance.CreareProdus("Piept de pui", 12.49, "1kg", "03/17/2018", 12));
            disciplina.AdaugaProdus("Peste", DisciplinaFactory.Factory.Instance.CreareProdus("Somon", 25.30, "300gr", "10/22/2018", 15));
            disciplina.AdaugaProdus("Peste", DisciplinaFactory.Factory.Instance.CreareProdus("Crap", 16.78, "1kg", "11/11/2018", 6));

            //afisare repository
            Console.WriteLine("Repository complet: \n");
            Console.WriteLine(repository.ToString());

            //Incepem vanzarile
            disciplina.IncepeVanzarea();

            //stergem tipul de alimente Carne
            disciplina.StergeTip("Carne");

            //stergem produsul Iaurt
            disciplina.StergeProdus("Lactate","Iaurt",20);
            disciplina.StergeProdus("Lactate", "Iaurt", 5);

            //Incepem inventarul
            disciplina.IncepeInventarul();
            DisciplinaFactory.Factory.Instance.AfisareInventar(disciplina);

            Console.WriteLine("Repository ramas dupa vanzari: \n");
            Console.WriteLine(repository.ToString());

            Console.WriteLine("Press any key to terminate.");
            Console.ReadLine();
        }
    }
}
