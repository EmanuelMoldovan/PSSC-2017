using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Generic;
using Models.Gradina;
using Repositories.Gradina;
using Services.Gradina;
namespace tema2pssc
{
    class Program
    {
        static void Main(string[] args)
        {
            var repository = new GradinaRepository();

            var gradina = GradinaFactory.Instance.CreeazaGradina(1);
            repository.AdaugaGradina(gradina);

            var gradina1 = GradinaFactory.Instance.CreeazaGradina(2);
            repository.AdaugaGradina(gradina1);

            var gradina2 = GradinaFactory.Instance.CreeazaGradina(0); //eroare 

            gradina.AdaugaFloare("Garoafa", "Galben", 12);
            gradina.AdaugaFloare("Lalea", "Rosie", 1);
            gradina.AdaugaFloare("Lacramioara", "Alba", 10);

            gradina.AdaugaLeguma("Morcov", TipLeguma.Radacina, 1);
            gradina.AdaugaLeguma("Telina", TipLeguma.Radacina, 12);
            gradina.AdaugaLeguma("Ceapa", TipLeguma.Bulb, 10);

            gradina.AdaugaPom("Mar", 10);
            gradina.AdaugaPom("Par", 8);
            gradina.AdaugaPom("Cires", 5);
            gradina.AdaugaPom("Piersic", 9);
            gradina.AdaugaPom("Gutui", 10);

            gradina.DecoreazaCasaCuFlori("Garoafa", 3);
            gradina.AruncaFlorileDinCasa();

            gradina.LegumePentruCiorba();

            gradina.SalataDeNota10();

            var toatePlantele = new ToatePlantele();
            toatePlantele.AfiseazaToatePlantele(1);
        }
    }
}
