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
    public class Tests
    {
        [Fact]
        public void VerificareAdaugareTip()
        {
            // arrange
            var disciplina = DisciplinaFactory.Factory.Instance.CreareDisciplina("Magazin");
            disciplina.IncepeCumpararea();
            disciplina.AdaugaTip(DisciplinaFactory.Factory.Instance.CreareTip("Lactate"));

            //act
            bool testResult = disciplina.TipExist("Lactate");

            // assert
            Assert.True(testResult); // success
        }

        [Fact]
        public void VerificareStergereTip()
        {
            // arrange
            var disciplina = DisciplinaFactory.Factory.Instance.CreareDisciplina("Magazin");
            disciplina.IncepeCumpararea();
            disciplina.AdaugaTip(DisciplinaFactory.Factory.Instance.CreareTip("Lactate"));
            disciplina.IncepeVanzarea();
            disciplina.StergeTip("Lactate");

            //act
            bool testResult = disciplina.TipExist("Lactate");

            // assert
            Assert.False(testResult); // success
        }

        [Fact]
        public void VerificareIncepeCumpararea()
        {
            // arrange
            Stare stare = new Stare();
            stare = Stare.Cumparare;

            //act
            bool testResult = (stare == Stare.Cumparare);

            // assert
            Assert.True(testResult); // success
        }

        [Fact]
        public void VerificareIncepeVinzarea()
        {
            // arrange
            Stare stare = new Stare();
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
            Stare stare = new Stare();
            stare = Stare.Inventar;

            //act
            bool testResult = (stare == Stare.Inventar);

            // assert
            Assert.True(testResult); // success
        }

        [Fact]
        public void VerificareAdaugareProdus()
        {
            // arrange
            var disciplina = DisciplinaFactory.Factory.Instance.CreareDisciplina("Magazin");
            disciplina.IncepeCumpararea();
            disciplina.AdaugaTip(DisciplinaFactory.Factory.Instance.CreareTip("Lactate"));
            disciplina.AdaugaProdus("Lactate", DisciplinaFactory.Factory.Instance.CreareProdus("Lapte", 3.49, "1l", "05/05/2018", 30));

            //act
            bool testResult = disciplina.ProdusExist("Lactate", "Lapte");

            // assert
            Assert.True(testResult); // success
        }

        [Fact]
        public void VerificareStergereProdus()
        {
            // arrange
            var disciplina = DisciplinaFactory.Factory.Instance.CreareDisciplina("Magazin");
            disciplina.IncepeCumpararea();
            disciplina.AdaugaTip(DisciplinaFactory.Factory.Instance.CreareTip("Lactate"));
            disciplina.AdaugaProdus("Lactate", DisciplinaFactory.Factory.Instance.CreareProdus("Lapte", 3.49, "1l", "05/05/2018", 30));
            disciplina.IncepeVanzarea();
            disciplina.StergeProdus("Lactate", "Lapte");
            //act
            bool testResult = disciplina.ProdusExist("Lactate", "Lapte");

            // assert
            Assert.False(testResult); // success
        }

        [Fact]
        public void VerificareCreareProdus()
        {
            // arrange
            bool testResult = false;
            Produs produs = DisciplinaFactory.Factory.Instance.CreareProdus("Lapte", 3.49, "1l", "05/05/2018", 30);

            //act
            if (produs.Nume == "Lapte" && produs.Pret == 3.49 && produs.Cantitate == "1l" &&  produs.DataExpirari.ToShortDateString().Equals("2018-05-05") && produs.NrBucati == 30)
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
        public void VerificareCreareTip()
        {
            // arrange
            bool testResult = false;
            Tip tip = DisciplinaFactory.Factory.Instance.CreareTip("Lactate");

            //act
            if (tip.Nume == "Lactate" && tip.ListaProduse != null)
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
            var disciplina = DisciplinaFactory.Factory.Instance.CreareDisciplina("Magazin");

            //act
            if (disciplina.NumeDisciplina == "Magazin" && disciplina.NumeDisciplina != null && disciplina.Inventar != null)
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
