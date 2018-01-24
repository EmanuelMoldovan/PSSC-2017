using System;
using System.Collections.Generic;
using System.Linq;
using Modele.Camin;
using Modele.Camin.DTO;
using Repositories.Camin;
using Servicii.Repartizare;
using Servicii.StartInscrieri;
using Servicii.StopInscrieri;
using Servicii.StudentInscris;

namespace RepartizareStudentiCamine
{
    class Program
    {
        static void Main(string[] args)
        {
            //Camin cu 2 camere de 2 locuri
            List<Student> ListaStudenti = new List<Student>();
            Camera camera1 = new Camera(ListaStudenti, 1, 2);
            Camera camera2 = new Camera(ListaStudenti, 2, 2);
            List<Camera> ListaCamere = new List<Camera>();
            ListaCamere.Add(camera1);
            ListaCamere.Add(camera2);
            Camin camin = new Camin(new Modele.Generic.PlainText("Camin 8C"), new Modele.Generic.PlainText("Popescu Elena"), 2, ListaCamere, new Modele.Generic.Nota(8), 2);

            //Sesiunea de inscrieri este programata
            var writeRepo = new WriteRepoCamin();
            var sesiuneNouaInscrieriDto = new SesiuneInscrieriCaminDTO()
            {
                DataStart = DateTime.Now,
                NumeCamin = camin,
                DurataZile = new Modele.Generic.Durata(15)
            };
            writeRepo.ProgrameazaSesiuneInscriere(sesiuneNouaInscrieriDto);

            //Sesiunea de inscrieri este preluata
            var readRepo = new ReadRepoCamin();
            var sesiune = readRepo.ObtineSesiuniInscrieri().FirstOrDefault();
            Console.WriteLine(sesiune);

            //Sesiunea de inscrieri incepe
            var commandStart = new ComandaStartInscrieri() { Sesiune = sesiune };
            var procesatorStart = new ProcesatorStartInscrieri();
            procesatorStart.Procesare(commandStart);

            //student
            var studentDto = new StudentDTO()
            {
                NumeStudent = new Modele.Generic.PlainText("Delia Moga"),
                NrMatricol = new Modele.Generic.NrMatricol("8866"),
                Facultate = new Modele.Generic.PlainText("AC"),
                Medie = new Modele.Generic.Nota(9),
                NumeCaminAles = camin
            };

            var command1 = new ComandaStudentInscris() { Student = studentDto };
            var procesator1 = new ProcesatorStudentInscris();
            procesator1.Procesare(command1);

            //Sesiunea de inscrieri se termina
            var commandStop = new ComandaStopInscrieri() { Sesiune = sesiune };
            var procesatorStop = new ProcesatorStopInscrieri();
            procesatorStop.Procesare(commandStop);

            //Repartizare studenti in camin
            var commandRepartizare = new ComandaRepartizare() { Sesiune = sesiune };
            var procesatorRepartizare = new ProcesatorRepartizare();
            procesatorRepartizare.Procesare(commandRepartizare);

            Console.ReadLine();
        }
    }
}
