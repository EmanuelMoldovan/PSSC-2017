using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Moq;
using Modele.Activitate;
using Modele.Generic;
using Modele.Organizator;
using Model.TabaraSportiva;
using Repositories.Activitate;

namespace UnitTests
{
    public class TestTabara
    {
        private Mock<IDataSource> _externalMock;
        Activitate activitate;
        Taberist taberist1;
        Taberist taberist2;
        List<Taberist> listTaberisti1;
        Echipe echipa1, echipa2;
        Organizator organizator1;

        public TestTabara()
        {
            _externalMock = new Mock<Modele.Activitate.IDataSource>();
            _externalMock.Setup(m => m.getEchipaCastigatoare()).Returns(new TextNume(""));
            organizator1 = new Organizator(new TextNume("Tarce Paul"), 22, GradOrganizator.ResponsabilTabara);
            activitate = ActivitateFactory.Instance.CreeazaActivitate(new TextNume("Shaolin Game"), 120, new Puncte(8));
            taberist1 = new Taberist() { Id = new IdTaberist("0001"), puncte = new Puncte(0) };
            taberist2 = new Taberist() { Id = new IdTaberist("0002"), puncte = new Puncte(3) };
            listTaberisti1 = new List<Taberist>() { taberist1, taberist2 };
            echipa1 = new Echipe(new TextNume("Alpha"), listTaberisti1);
            echipa2 = new Echipe(new TextNume("Beta"), listTaberisti1);
        }

        [Fact]
        public void CreateActivitate()
        {
            //arrange +act
            //done in the constructor TestTabara()

            //assert
            Assert.Equal("Shaolin Game", activitate.nume.Text);
            Assert.Equal(120, activitate.Durata);
            Assert.Equal(8, activitate.PunctajCastigator.Valoare);
            Assert.Equal(StareActivitate.Creeata, activitate.stareActivitate);
        }
        [Fact]
        public void ShouldCreateTheObjects()
        {
            //arrange 
            TabaraSportiva tabara = new TabaraSportiva();

            //assert + arrange
            Assert.IsType<TabaraSportiva>(tabara);
        }

        [Fact]
        public void echipaCastigatoare()  // folosire Mock's
        {
            //arrange
            TextNume echipa = new TextNume("Alpha");
            _externalMock
                .Setup(m => m.calculPunctajMaxEchipa())
                .Returns(echipa);

            var classTested = activitate;

            //act 
            TextNume echipaWinning = classTested.getEchipaCastigatoare();

            //assert 
            Assert.Equal("Alpha", echipaWinning.Text);
        }

        [Fact]
        public void testFeedback()
        {
            //arrange
            //done in constructor

            //act
            organizator1.getFeedback("Foarte bine");

            //assert 
            Assert.Equal("Foarte bine", organizator1.feedBack[0].ToString());
        }

        [Fact]
        public void numarEchipeTest()
        {
            //arrange
            var echipa1 = new Echipe(new TextNume("Alpha"), listTaberisti1);
            var echipa2 = new Echipe(new TextNume("Beta"), listTaberisti1);
            activitate.adaugaEchipa(echipa1);
            activitate.adaugaEchipa(echipa2);

            //act
            var nrEchipe = Activitate.nrEchipe;

            //assert
            Assert.Equal(2, nrEchipe); //succes      
        }

        [Fact]
        public void testEchipe()
        {
            //arrange + act
            var echipa1 = new Echipe(new TextNume("Alpha"), listTaberisti1);
            var echipa2 = new Echipe(new TextNume("Beta"), listTaberisti1);

            //assert
            Assert.Equal("Alpha", echipa1.nume.Text);
            Assert.Equal("Beta", echipa2.nume.Text);
            Assert.NotNull(echipa1.taberisti);
            Assert.NotNull(echipa2.taberisti);

        }

        [Fact]
        public void stareActivitati()
        {
            //arrange
            var act1 = ActivitateFactory.Instance.CreeazaActivitate(new TextNume("Game of Bats"), 25, new Puncte(7));
            var act2 = ActivitateFactory.Instance.CreeazaActivitate(new TextNume("Game of "), 25, new Puncte(7));
            var act3 = ActivitateFactory.Instance.CreeazaActivitate(new TextNume("Game"), 25, new Puncte(7));
            var act4 = ActivitateFactory.Instance.CreeazaActivitate(new TextNume("Ga"), 25, new Puncte(7));


            //act
            act1.StartActivitate();
            act2.StopActivitate();
            act3.adaugaEchipa(null);

            //assert
            Assert.Equal(StareActivitate.Creeata, act4.stareActivitate);
            Assert.Equal(StareActivitate.Pregatire, act3.stareActivitate);
            Assert.Equal(StareActivitate.Incheiata, act2.stareActivitate);
            Assert.Equal(StareActivitate.InDesfasurare, act1.stareActivitate);

        }
        [Fact]

        public void mediePuncteEchipa()
        {
            //arrange 
            var echipa1 = new Echipe(new TextNume("Alpha"), listTaberisti1);
            echipa1.addPunctaj(new Puncte(4));
            echipa1.addPunctaj(new Puncte(10));
            echipa1.addPunctaj(new Puncte(2));

            //act
            double medie = echipa1.MediePunctaje();
            double valAsteptata = 16 / 3;
            //asset
            Assert.Equal(valAsteptata, medie);
        }
    }
}
