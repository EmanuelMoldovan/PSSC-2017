using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Repositories.StudentiInscrisi;
using Modele.Camin;
using Modele.Camin.DTO;

namespace RepartizareStudentiCamin.Tests
{
    public class RepartizareTests
    {
        [Fact]
        public void VerificareRepartizareCorectaStudentAdmis()
        {
            // arrange
            List<Student> ListaStudenti = new List<Student>();
            Camera camera1 = new Camera(ListaStudenti, 1, 2);
            Camera camera2 = new Camera(ListaStudenti, 2, 2);
            List<Camera> ListaCamere = new List<Camera>();
            ListaCamere.Add(camera1);
            ListaCamere.Add(camera2);
            Camin camin = new Camin(new Modele.Generic.PlainText("Camin 8C"), new Modele.Generic.PlainText("Popescu Elena"), 2, ListaCamere, new Modele.Generic.Nota(8), 2);
            var sesiuneNouaInscrieriDto = new SesiuneInscrieriCaminDTO()
            {
                DataStart = DateTime.Now,
                NumeCamin = camin,
                DurataZile = new Modele.Generic.Durata(15)
            };
            var studentDto = new StudentDTO()
            {
                NumeStudent = new Modele.Generic.PlainText("Delia Moga"),
                NrMatricol = new Modele.Generic.NrMatricol("8866"),
                Facultate = new Modele.Generic.PlainText("AC"),
                Medie = new Modele.Generic.Nota(9),
                NumeCaminAles = camin
            };

            // act
            var repo = new ReadRepoStudentiInscrisiCamin();
            var testResult = repo.Repartizare(studentDto, sesiuneNouaInscrieriDto);
            
            // assert
            Assert.Equal(testResult, RezultatRepartizare.Admis); // success
        }

        [Fact]
        public void VerificareRepartizareCorectaStudentRespinsMedieMica()
        {
            // arrange
            List<Student> ListaStudenti = new List<Student>();
            Camera camera1 = new Camera(ListaStudenti, 1, 2);
            Camera camera2 = new Camera(ListaStudenti, 2, 2);
            List<Camera> ListaCamere = new List<Camera>();
            ListaCamere.Add(camera1);
            ListaCamere.Add(camera2);
            Camin camin = new Camin(new Modele.Generic.PlainText("Camin 8C"), new Modele.Generic.PlainText("Popescu Elena"), 2, ListaCamere, new Modele.Generic.Nota(8), 2);
            var sesiuneNouaInscrieriDto = new SesiuneInscrieriCaminDTO()
            {
                DataStart = DateTime.Now,
                NumeCamin = camin,
                DurataZile = new Modele.Generic.Durata(15)
            };
            var studentDto = new StudentDTO()
            {
                NumeStudent = new Modele.Generic.PlainText("Delia Moga"),
                NrMatricol = new Modele.Generic.NrMatricol("8866"),
                Facultate = new Modele.Generic.PlainText("AC"),
                Medie = new Modele.Generic.Nota(7),
                NumeCaminAles = camin
            };

            // act
            var repo = new ReadRepoStudentiInscrisiCamin();
            var testResult = repo.Repartizare(studentDto, sesiuneNouaInscrieriDto);

            // assert
            Assert.Equal(testResult, RezultatRepartizare.RespinsMedieMica); // success
        }

        [Fact]
        public void VerificareRepartizareCorectaStudentRespinsLocuriOcupate()
        {
            // arrange
            //camin cu o camera cu doar 2 locuri
            List<Student> ListaStudenti = new List<Student>();
            Camera camera1 = new Camera(ListaStudenti, 1, 2);
            List<Camera> ListaCamere = new List<Camera>();
            ListaCamere.Add(camera1);
            Camin camin = new Camin(new Modele.Generic.PlainText("Camin 8C"), new Modele.Generic.PlainText("Popescu Elena"), 2, ListaCamere, new Modele.Generic.Nota(8), 2);
            
            var sesiuneNouaInscrieriDto = new SesiuneInscrieriCaminDTO()
            {
                DataStart = DateTime.Now,
                NumeCamin = camin,
                DurataZile = new Modele.Generic.Durata(15)
            };
            //sesiuneNouaInscrieriDto.NumeCamin.estePlin = true;
            var studentDto1 = new StudentDTO()
            {
                NumeStudent = new Modele.Generic.PlainText("Popescu Andrei"),
                NrMatricol = new Modele.Generic.NrMatricol("8346"),
                Facultate = new Modele.Generic.PlainText("AC"),
                Medie = new Modele.Generic.Nota(9),
                NumeCaminAles = camin
            };
            var studentDto2 = new StudentDTO()
            {
                NumeStudent = new Modele.Generic.PlainText("Delia Moga"),
                NrMatricol = new Modele.Generic.NrMatricol("8866"),
                Facultate = new Modele.Generic.PlainText("AC"),
                Medie = new Modele.Generic.Nota(10),
                NumeCaminAles = camin
            };
            var studentDto3 = new StudentDTO()
            {
                NumeStudent = new Modele.Generic.PlainText("Andreea"),
                NrMatricol = new Modele.Generic.NrMatricol("8436"),
                Facultate = new Modele.Generic.PlainText("AC"),
                Medie = new Modele.Generic.Nota(10),
                NumeCaminAles = camin
            };

            // act
            var repo = new ReadRepoStudentiInscrisiCamin();
            var testResult1 = repo.Repartizare(studentDto1, sesiuneNouaInscrieriDto);
            var testResult2 = repo.Repartizare(studentDto2, sesiuneNouaInscrieriDto);
            var testResult3 = repo.Repartizare(studentDto3, sesiuneNouaInscrieriDto);

            // assert
            Assert.Equal(testResult3, RezultatRepartizare.RespinsLocuriOcupate); // success
        }       
    }
}
