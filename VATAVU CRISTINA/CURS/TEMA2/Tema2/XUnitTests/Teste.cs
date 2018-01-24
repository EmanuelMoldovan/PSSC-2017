using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Modele.Cont;
using Modele.Generic;
using Repositories.Conturi;
using Modele.Generic.Exceptions;
using Servicii.Conturi;

namespace XUnitTests
{
    public class Teste
    {

        [Fact]
        public void VerificaIBANIncorect()
        {
            //test: se arunca exceptie cand IBAN-ul nu are formatul corect

            // arrange
            var client1 = ConturiFactory.Instance.CreazaClient(new PlainText("Ion"), new PlainText("Timisoara"));

            // act & assert
            //nu are primele 2 caractere litere
            Assert.Throws<IBANFormatNotOKException>(() => ConturiFactory.Instance.CreazaCont(new IBAN("R012RBND1234567890123456"), client1));
            //nu are o cifra ca al 3lea caracter
            Assert.Throws<IBANFormatNotOKException>(() => ConturiFactory.Instance.CreazaCont(new IBAN("ROO2RBND1234567890123456"), client1));
            //nu are nu are caracterele 5- 8 toate litere
            Assert.Throws<IBANFormatNotOKException>(() => ConturiFactory.Instance.CreazaCont(new IBAN("ROO2RB9D1234567890123456"), client1));

        }




        [Fact]
        public void VerificaIBANLungimeIncorecta()
        {
            //test: se arunca exceptie cand lungimea IBAN-ului e incorecta
            // arrange
            var client1 = ConturiFactory.Instance.CreazaClient(new PlainText("Ion"), new PlainText("Timisoara"));

            // act & assert
            //prea lung
            Assert.Throws<IBANLengthNotOKException>(() => ConturiFactory.Instance.CreazaCont(new IBAN("RO12RBND12345678901234567"), client1));
            //prea scurt
            Assert.Throws<IBANLengthNotOKException>(() => ConturiFactory.Instance.CreazaCont(new IBAN("RO12RBND123456789012345"), client1));

        }



        [Fact]
        public void VerificaIBANCorect()
        {
            //test: atunci cand IBAN-ul e corect utilizatorul se adauga in repository
            // arrange
            var client1 = ConturiFactory.Instance.CreazaClient(new PlainText("Ion"), new PlainText("Timisoara"));

            // act & assert
            Assert.NotNull( ConturiFactory.Instance.CreazaCont(new IBAN("RO12RBND1234567890123456"), client1));
        }



        [Fact]
        public void VerificaIBANUnic()
        {
            //test: nu poti adauga 2 conturi cu acelai IBAN

            // arrange
            var repo = new ConturiRepository();
            var client1 = ConturiFactory.Instance.CreazaClient(new PlainText("Ion"), new PlainText("Timisoara"));
            var client2 = ConturiFactory.Instance.CreazaClient(new PlainText("Vasile"), new PlainText("Arad"));
            var cont1 = ConturiFactory.Instance.CreazaCont(new IBAN("RO12RBND1234567890123456"), client1);
            var cont2 = ConturiFactory.Instance.CreazaCont(new IBAN("RO12RBND1234567890123456"), client2);
            repo.AdaugaCont(cont1);

            // act & assert
            Assert.Throws<IBANAlreadyExistingException>(() => repo.AdaugaCont(cont2));
        }



        [Fact]
        public void VerificaRespingeTransferFonduriInsuficiente()
        {
            //test: verifica ca se arunca o exceptie cand se vrea o tranzactie(transfer) pt care nu sunt fonduri insufuciente

            // arrange
            var repo = new ConturiRepository();
            var client1 = ConturiFactory.Instance.CreazaClient(new PlainText("Ion"), new PlainText("Timisoara"));
            var client2 = ConturiFactory.Instance.CreazaClient(new PlainText("Vasile"), new PlainText("Arad"));
            var cont1 = ConturiFactory.Instance.CreazaCont(new IBAN("RO12RBND1234567890123456"), client1);
            var cont2 = ConturiFactory.Instance.CreazaCont(new IBAN("RO12RBND1234567890123455"), client2);
            repo.AdaugaCont(cont1);
            repo.AdaugaCont(cont2);
            cont1.DepuneBani(new Suma(99.0)); //depune 99
            

            // act & assert
            //vrea sa transfere 100
            Assert.Throws<InsufficientFundsException>(() => cont1.TransferBani(new Suma(100.0), cont2.IBAN, repo.getConturi));
        }



        [Fact]
        public void VerificaRespingeFacturaFonduriInsuficiente()
        {
            //test: verifica ca se arunca o exceptie cand se vrea o tranzactie(plata factura) pt care nu sunt fonduri insufuciente
            // arrange
            var repo = new ConturiRepository();
            var client1 = ConturiFactory.Instance.CreazaClient(new PlainText("Ion"), new PlainText("Timisoara"));
            var client2 = ConturiFactory.Instance.CreazaClient(new PlainText("Vasile"), new PlainText("Arad"));
            var cont1 = ConturiFactory.Instance.CreazaCont(new IBAN("RO12RBND1234567890123456"), client1);
            var cont2 = ConturiFactory.Instance.CreazaCont(new IBAN("RO12RBND1234567890123455"), client2);
            repo.AdaugaCont(cont1);
            repo.AdaugaCont(cont2);
            cont1.DepuneBani(new Suma(99.0)); //depune 99


            // act & assert
            //vrea sa transfere 100
            Assert.Throws<InsufficientFundsException>(() => cont1.PlatesteFactura(new Suma(100.0), cont2.IBAN, repo.getConturi));
        }



        [Fact]
        public void VerificaDepunere()
        {
            //test: verifica ca depunerea banilor actualizeaza soldul
            // arrange
            var repo = new ConturiRepository();
            var client1 = ConturiFactory.Instance.CreazaClient(new PlainText("Ion"), new PlainText("Timisoara"));
            var cont1 = ConturiFactory.Instance.CreazaCont(new IBAN("RO12RBND1234567890123456"), client1);
            
            //act
            cont1.DepuneBani(new Suma(99.0)); //depune 99

            //assert
            Assert.Equal(99.0, cont1.Sold.getSuma);
        }



        [Fact]
        public void VerificaTranzactiePartenerInexistent()
        {
            //test: verifica ca se arunca o exceptie cand se vrea o tranzactie catre un cont care nu exista

            // arrange
            var repo = new ConturiRepository();
            var client1 = ConturiFactory.Instance.CreazaClient(new PlainText("Ion"), new PlainText("Timisoara"));
            var client2 = ConturiFactory.Instance.CreazaClient(new PlainText("Vasile"), new PlainText("Arad"));
            var cont1 = ConturiFactory.Instance.CreazaCont(new IBAN("RO12RBND1234567890123456"), client1);
            var cont2 = ConturiFactory.Instance.CreazaCont(new IBAN("RO12RBND1234567890123455"), client2);
            repo.AdaugaCont(cont1);
            repo.AdaugaCont(cont2);
            cont1.DepuneBani(new Suma(99.0)); //depune 99 ca sa aiba de unde sa trasnfere

            //act & assert
            Assert.Throws<AccountNotFoundException>(() => cont1.TransferBani(new Suma(10.0), new IBAN("RO12RBND1334367830323455"), repo.getConturi));
        }



        [Fact]
        public void VerificaTranzactie()
        {
            //test: verifica ca se updateaza conturile ambilor parteneri la o tranzactie

            // arrange
            var repo = new ConturiRepository();
            var client1 = ConturiFactory.Instance.CreazaClient(new PlainText("Ion"), new PlainText("Timisoara"));
            var client2 = ConturiFactory.Instance.CreazaClient(new PlainText("Vasile"), new PlainText("Arad"));
            var cont1 = ConturiFactory.Instance.CreazaCont(new IBAN("RO12RBND1234567890123456"), client1);
            var cont2 = ConturiFactory.Instance.CreazaCont(new IBAN("RO12RBND1234567890123455"), client2);
            repo.AdaugaCont(cont1);
            repo.AdaugaCont(cont2);
            cont1.DepuneBani(new Suma(99.0)); //depune 99 ca sa aiba de unde sa trasnfere

            //act
            repo.updateConturi = cont1.TransferBani(new Suma(10.0), cont2.IBAN, repo.getConturi);

            //assert
            Assert.Equal(89.0, cont1.Sold.getSuma);
            Assert.Equal(10.0, cont2.Sold.getSuma);
        }



        [Fact]
        public void VerificaRaport()
        {
            //test: verifica ca se genereaza raport ok

            // arrange
            var repo = new ConturiRepository();
            RaportTranzactiiService raport = new RaportTranzactiiService();
            var client1 = ConturiFactory.Instance.CreazaClient(new PlainText("Ion"), new PlainText("Timisoara"));
            var client2 = ConturiFactory.Instance.CreazaClient(new PlainText("Vasile"), new PlainText("Arad"));
            var cont1 = ConturiFactory.Instance.CreazaCont(new IBAN("RO12RBND1234567890123456"), client1);
            var cont2 = ConturiFactory.Instance.CreazaCont(new IBAN("RO12RBND1234567890123455"), client2);
            repo.AdaugaCont(cont1);
            repo.AdaugaCont(cont2);

            cont1.DepuneBani(new Suma(99.0)); //depune 99 ca sa aiba de unde sa trasnfere
            repo.updateConturi = cont1.TransferBani(new Suma(10.0), cont2.IBAN, repo.getConturi);
            repo.updateConturi = cont1.PlatesteFactura(new Suma(20.0), cont2.IBAN, repo.getConturi);
            raport.RapoarteTranzactii(cont1);

            //vreau doar sa genereze raportul
        }



        [Fact]
        public void VerificaGrafic()
        {
            //test: verifica datele pt grafic
            // arrange
            var repo = new ConturiRepository();
            GraficSoldService grafic = new GraficSoldService();
            var client1 = ConturiFactory.Instance.CreazaClient(new PlainText("Ion"), new PlainText("Timisoara"));
            var client2 = ConturiFactory.Instance.CreazaClient(new PlainText("Vasile"), new PlainText("Arad"));
            var cont1 = ConturiFactory.Instance.CreazaCont(new IBAN("RO12RBND1234567890123456"), client1);
            var cont2 = ConturiFactory.Instance.CreazaCont(new IBAN("RO12RBND1234567890123455"), client2);
            repo.AdaugaCont(cont1);
            repo.AdaugaCont(cont2);

            cont1.DepuneBani(new Suma(99.0)); //depune 99 ca sa aiba de unde sa trasnfere
            repo.updateConturi = cont1.TransferBani(new Suma(10.0), cont2.IBAN, repo.getConturi);
            repo.updateConturi = cont1.PlatesteFactura(new Suma(20.0), cont2.IBAN, repo.getConturi);
            grafic.GraficSoldInTimp(cont1);

            //vreau doar sa vad graficul
        }
    }
}
