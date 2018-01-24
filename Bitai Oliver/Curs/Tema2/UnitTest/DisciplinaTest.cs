using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using DisciplinaFactory;
using State;

namespace UnitTest
{
    public class DisciplinaTest
    {
        [Fact]
        public void VerificareAdaugareBrand()
        {
            // arrange
            var disciplina = DisciplinaFactory.DisciplinaFactory.Instance.CreareDisciplina("Autoturisme");
            disciplina.IncepeCumpararea();
            disciplina.AdaugaBrand(DisciplinaFactory.DisciplinaFactory.Instance.CreareBrand("BMW"));

            //act
           bool testResult = disciplina.BrandExist("BMW");

            // assert
            Assert.True(testResult); // success
        }

        [Fact]
        public void VerificareStergereBrand()
        {
            // arrange
            var disciplina = DisciplinaFactory.DisciplinaFactory.Instance.CreareDisciplina("Autoturisme");
            disciplina.IncepeCumpararea();
            disciplina.AdaugaBrand(DisciplinaFactory.DisciplinaFactory.Instance.CreareBrand("BMW"));
            disciplina.IncepeVanzarea();
            disciplina.StergeBrand("BMW");

            //act
            bool testResult = disciplina.BrandExist("BMW");

            // assert
            Assert.False(testResult); // success
        }

        [Fact]
        public void VerificareIncepeCumpararea()
        {
            // arrange
            State.Stare stare = new Stare();
            stare = Stare.Cumparare;

            //act
            bool testResult =(stare==Stare.Cumparare);

            // assert
            Assert.True(testResult); // success
        }

        [Fact]
        public void VerificareIncepeVinzarea()
        {
            // arrange
            State.Stare stare = new Stare();
            stare = Stare.Vanzare;

            //act
            bool testResult = (stare == Stare.Vanzare);

            // assert
            Assert.True(testResult); // success
        }

        [Fact]
        public void VerificareIncepeInventarul()
        {
            // arrange
            State.Stare stare = new Stare();
            stare = Stare.Inventar;

            //act
            bool testResult = (stare == Stare.Inventar);

            // assert
            Assert.True(testResult); // success
        }

        [Fact]
        public void VerificareAdaugareMasina()
        {
            // arrange
            var disciplina = DisciplinaFactory.DisciplinaFactory.Instance.CreareDisciplina("Autoturisme");
            disciplina.IncepeCumpararea();
            disciplina.AdaugaBrand(DisciplinaFactory.DisciplinaFactory.Instance.CreareBrand("BMW"));
            disciplina.AdaugaMasini("BMW", DisciplinaFactory.DisciplinaFactory.Instance.CreareMasina("320", 1998, 132, "Alb", 10000));

            //act
            bool testResult = disciplina.MasinaExist("BMW","320");

            // assert
            Assert.True(testResult); // success
        }

        [Fact]
        public void VerificareStergereMasina()
        {
            // arrange
            var disciplina = DisciplinaFactory.DisciplinaFactory.Instance.CreareDisciplina("Autoturisme");
            disciplina.IncepeCumpararea();
            disciplina.AdaugaBrand(DisciplinaFactory.DisciplinaFactory.Instance.CreareBrand("BMW"));
            disciplina.AdaugaMasini("BMW", DisciplinaFactory.DisciplinaFactory.Instance.CreareMasina("320", 1998, 132, "Alb", 10000));
            disciplina.IncepeVanzarea();
            disciplina.StergeMasina("BMW", "320");
            //act
            bool testResult = disciplina.MasinaExist("BMW", "320");

            // assert
            Assert.False(testResult); // success
        }

        [Fact]
        public void VerificareCreareMasina()
        {
            // arrange
            bool testResult = false;
           Masina.Masina masina = DisciplinaFactory.DisciplinaFactory.Instance.CreareMasina("320", 1998, 132, "Alb", 10000);

            //act
            if (masina.Model == "320" && masina.CapMotor == 1998 && masina.Hp == 132 && masina.Culoare == "Alb" && masina.Pret == 10000)
            {
                testResult = true;
            }
            else
            {
                testResult = false;
            }

            // assert
            Assert.True(testResult); // success
        }

        [Fact]
        public void VerificareCreareBrand()
        {
            // arrange
            bool testResult = false;
            Brand.Brand brand = DisciplinaFactory.DisciplinaFactory.Instance.CreareBrand("Audi");

            //act
            if (brand.Nume=="Audi"&&brand.ListaMasini!=null)
            {
                testResult = true;
            }
            else
            {
                testResult = false;
            }

            // assert
            Assert.True(testResult); // success
        }

        [Fact]
        public void VerificareCreareDisciplina()
        {
            // arrange
            bool testResult = false;
            var disciplina = DisciplinaFactory.DisciplinaFactory.Instance.CreareDisciplina("Autoturisme");

            //act
            if (disciplina.NumeDisciplina=="Autoturisme"&&disciplina.NumeDisciplina!=null&&disciplina.Inventar!=null)
            {
                testResult = true;
            }
            else
            {
                testResult = false;
            }

            // assert
            Assert.True(testResult); // success
        }

    }
}
