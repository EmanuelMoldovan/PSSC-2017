using Model.Generic;
using Model.Internare;
using Repositories.Urgente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema2PSSC
{
    class Program
    {
        static void Main(string[] args)
        {
            var fisaPacient = new FisaPacient(new PlainText("123123"));
            var repository = new UrgenteRepository();
            repository.AdaugaUrgenta(fisaPacient);

            fisaPacient.ActualizeazaDoctor(new Doctor(new PlainText("Ion"), new PlainText("Pop"),Semnatura.Responsabil, new PlainText("3434")));
            fisaPacient.GetDoctor().AdaugaAsistent(new Asistent(new PlainText("Mihai"), new PlainText("Ana"), Semnatura.Neresponsabil));
            fisaPacient.GetAsistent("Ana").InregistrarePacient(new Pacient(new PlainText("Popa"), new PlainText("Mircea"), 30, new Cnp("1902334122311"), Mediu.Rural, StarePacient.Critic, new Investigatii(true,34,true)));

            fisaPacient.GetDoctor().EfectuareAnamneza(fisaPacient.GetPacient("Ana","Popa"));
            fisaPacient.GetDoctor().CoordoneazaAsistentul(fisaPacient.GetPacient("Ana", "Popa"), fisaPacient.GetAsistent("Ana"));
            fisaPacient.GetDoctor().ActualizareStarePacient(fisaPacient.GetPacient("Ana", "Popa"), fisaPacient.GetAsistent("Ana"), StarePacient.Minor);

            fisaPacient.GetDoctor().ExternarePacient(fisaPacient.GetPacient("Ana", "Popa"), fisaPacient.GetAsistent("Ana"));

            repository.ActualizeazaUrgenta(fisaPacient);

            Console.WriteLine("Press any key to terminate.");
            Console.ReadLine();
        }
    }
}
