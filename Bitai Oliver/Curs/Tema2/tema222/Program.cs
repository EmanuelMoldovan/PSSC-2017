using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DisciplinaFactory;
using DisciplinaRepository;

namespace tema222
{
    class Program
    {
        static void Main(string[] args)
        {
            //creare repo
            var repository = new DisciplinaRepository.DisciplinaRepository();

            //creare disciplina
            var disciplina = DisciplinaFactory.DisciplinaFactory.Instance.CreareDisciplina("Autoturisme");

            //adaugare disciplina in repository
            repository.AdaugaDisciplina(disciplina);

            //Incepem cumparaturile
            disciplina.IncepeCumpararea();

            //adaugare brand
            disciplina.AdaugaBrand(DisciplinaFactory.DisciplinaFactory.Instance.CreareBrand("BMW"));
            disciplina.AdaugaBrand(DisciplinaFactory.DisciplinaFactory.Instance.CreareBrand("Audi"));

            //adaugare modele de masina
            disciplina.AdaugaMasini("BMW", DisciplinaFactory.DisciplinaFactory.Instance.CreareMasina("320", 1998, 132, "Alb", 10000));
            disciplina.AdaugaMasini("BMW", DisciplinaFactory.DisciplinaFactory.Instance.CreareMasina("520", 2000, 152, "Negru", 15000));
            disciplina.AdaugaMasini("Audi", DisciplinaFactory.DisciplinaFactory.Instance.CreareMasina("A4", 1990, 126, "Rosu", 11000));
            disciplina.AdaugaMasini("Audi", DisciplinaFactory.DisciplinaFactory.Instance.CreareMasina("R8", 3600, 268, "Negru", 75000));

            //afisare repository
            Console.WriteLine("Repository complet: \n");
            Console.WriteLine(repository.ToString());

            //Incepem vanzarile
            disciplina.IncepeVanzarea();

            //stergem brandul BMW
            disciplina.StergeBrand("BMW");
           
            //stergem masina Audi A4
            disciplina.StergeMasina("Audi", "A4");

            //Incepem inventarul
            disciplina.IncepeInventarul();
            DisciplinaFactory.DisciplinaFactory.Instance.AfisareInventar(disciplina);

            //stergem disciplina
           // Console.WriteLine("Repository dupa stergerea disciplinei(repo gol): \n");
            //repository.StergeDisciplina(disciplina);
           // Console.WriteLine(repository.ToString());

            Console.WriteLine("Press any key to terminate.");
            Console.ReadLine();
            //DisciplinaFactory.DisciplinaFactory.Instance.AfisareDisciplina(disciplina);
        }
    }
}
