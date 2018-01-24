using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositories.Workshop;
using Modele.Workshop;
using Modele.Generic;

namespace ModelDDD
{
    class Program
    {
        static void Main(string[] args)
        {
            //creeaza workshop
            var workshop = WorkshopFactory.Instance.CreeazaWorkshop("Vector");
            var repository = new WorkshopRepository();
            repository.AdaugaWorkshop(workshop);

            //inscrie firma - gresit se poate adauga firma in doua workshopuri, 
            //crearea obiecului firma ar trebui sa fie facuta intern in model (aici firma este o entitate)
            workshop.InscrieFirma(WorkshopFactory.Instance.CreeazaFirma("10", "Autoliv"));
            workshop.InscrieFirma(WorkshopFactory.Instance.CreeazaFirma("11", "Continental"));
            workshop.InscrieFirma(WorkshopFactory.Instance.CreeazaFirma("12", "Hella"));
            //inscrierea aceleias firme arunca exceptie

            workshop.IncepeWorkshop();

            //pret activitate
            workshop.NoteazaActivitateFirma(new Modele.Generic.IdParticipare("10"), new Modele.Generic.Pret(5));
            workshop.NoteazaActivitateFirma(new Modele.Generic.IdParticipare("11"), new Modele.Generic.Pret(5));
            workshop.NoteazaActivitateFirma(new Modele.Generic.IdParticipare("12"), new Modele.Generic.Pret(5));

            var pretPachet = new Dictionary<Modele.Generic.IdParticipare, Modele.Generic.Pret>();
            pretPachet.Add(new IdParticipare("10"), new Pret(30));
            workshop.TrecePretPachet(pretPachet);
            pretPachet.Add(new IdParticipare("11"), new Pret(40));
            workshop.TrecePretPachet(pretPachet);
            pretPachet.Add(new IdParticipare("12"), new Pret(30));
            workshop.TrecePretPachet(pretPachet);

            workshop.IncheieWorkshop();

            repository.ActualizeazaWorkshop(workshop);
            Console.WriteLine("Press any key to terminate");
            Console.ReadLine();
        }
    }
}
