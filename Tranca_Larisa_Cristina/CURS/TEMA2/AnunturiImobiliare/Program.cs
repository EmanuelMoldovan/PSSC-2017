using Modele.Disciplina;
using Modele.Generic;
using Repositories.Anunt;
using Servicii.Disciplina;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoDdd
{
    class Program
    {
        static void Main(string[] args)
        {
            //creare disciplina
            var anunt = AnuntFactory.Instance.CreeazaAnunt("Vand casa", "Circumvalatiunii", 60000, "Mall", "larisa.tranca15@gmail.com", 017856);
            var repository = new AnuntRepository();
            repository.AdaugaAnunt(anunt);
            
            anunt.InscrieStudent(DisciplinaFactory.Instance.CreeazaStudnet("1234567", "test1"));
            //inscrierea aceluias student arunca exceptie
            //discilina.InscrieStudent(DisciplinaFactory.Instance.CreeazaStudnet("1234567", "test1"));

            discilina.IncepeSemestru();

            //nota activitate
            discilina.NoteazaActivitateStudent(new Modele.Generic.NumarMatricol("1234567"), new Modele.Generic.Telefon(8));
            discilina.NoteazaActivitateStudent(new Modele.Generic.NumarMatricol("1234567"), new Modele.Generic.Telefon(10));

            var noteExamen = new Dictionary<Modele.Generic.NumarMatricol, Modele.Generic.Telefon>();
            noteExamen.Add(new NumarMatricol("1234567"), new Telefon(7));
            discilina.TreceNoteExamen(noteExamen);

            discilina.IncheieSemestru();

            //publica notele
            var publish = new PublicareAnuntService();
            publish.PublicareNotePeWebSite("PSSC");

            repository.ActualizeazaDisciplina(discilina);

            Console.WriteLine("Press any key to terminate.");
            Console.ReadLine();
        }
    }
}
