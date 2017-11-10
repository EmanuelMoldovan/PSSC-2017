using Model.Generic;
using Model.Internare;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitTests.Tests
{
    public class PacientClass
    {
        [Fact]
        public void VerificareAdaugarePacient()
        {
            // arrange
            Pacient pacient = new Pacient(new PlainText("Popa"), new PlainText("Mircea"), 30, new Cnp("1902334122311"), Mediu.Rural, StarePacient.Critic, new Investigatii(true, 34, true)); 

            Asistent asistent = new Asistent(new PlainText("Mihai"), new PlainText("Ana"), Semnatura.Neresponsabil);

            var testList = new List<Pacient>();

            // act
            asistent.InregistrarePacient(pacient);
            testList.Add(pacient);
            // assert
            Assert.Equal(testList, asistent.GetPacienti()); // success
        }

        [Fact]
        public void VerificareNumePacient()
        {
            // arrange
            Pacient pacient = new Pacient(new PlainText("Popa"), new PlainText("Mircea"), 30, new Cnp("1902334122311"), Mediu.Rural, StarePacient.Critic, new Investigatii(true, 34, true));

            // act
            var nume = pacient.ToString();

            // assert
            Assert.Equal("Popa", nume); // success
        }

        [Fact]
        public void VerificareActualizareEvolutiePacient()
        {
            // arrange
            Pacient pacient = new Pacient(new PlainText("Popa"), new PlainText("Mircea"), 30, new Cnp("1902334122311"), Mediu.Rural, StarePacient.Critic, new Investigatii(true, 34, true));

            // act
            pacient.ActualizareEvolutiePacient(EvolutiePacient.Anamneza);

            // assert
            Assert.Equal(EvolutiePacient.Anamneza, pacient.EvolutiePacient); // success
        }
    }
}
