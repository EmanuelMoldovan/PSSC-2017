using Modele.Cont;
using Modele.Generic;
using Modele.Generic.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Teste.Model
{
    public class Teste
    {
        public Teste()
        {

        }


        [Fact]
        public void NuAcceptaIBANIncorect()
        {
            AG_ROOT_Cont cont;
            var ex = Assert.Throws<IBANFormatNotOKException>(() => cont = new AG_ROOT_Cont(new IBAN("123"), new Client(new PlainText("Ion"), new PlainText("timisoara"))));
        }


        [Fact]
        public void DepuneBani()
        {
            //clientul are 100 de lei in cont
            var cont = new AG_ROOT_Cont(new IBAN("RO22BACX6548206443372891"), new Client(new PlainText("Ion"), new PlainText("timisoara")), new Suma(100));
            cont.DepuneBani(new Suma(50)); //depune 50
            Assert.Equal(150.0, cont.Sold.getSuma); //verifica ca s-au depus
        }

        [Fact]
        public void TransferaBani()
        {
            //clientul 1 are 100 de lei in cont
            var cont1 = new AG_ROOT_Cont(new IBAN("RO22BACX6548206443372891"), new Client(new PlainText("Ion"), new PlainText("timisoara")), new Suma(100));
            //clientul 2 are 500 de lei in cont
            var cont2 = new AG_ROOT_Cont(new IBAN("RO22BACX6548206443372892"), new Client(new PlainText("Vasile"), new PlainText("timisoara")), new Suma(500));

            //din contul 2 transferam 50 lei in contul 1
            List<AG_ROOT_Cont> conturi = (new AG_ROOT_Cont()).TransferBaniIntreDouaConturi(new Suma(50.0), cont2, cont1);

            Assert.Equal(150, conturi[1].Sold.getSuma);
            Assert.Equal(450, conturi[0].Sold.getSuma);
        }

        [Fact]
        public void VerificaIstoricTranzactii()
        {
            //clientul 1 are 100 de lei in cont
            var cont1 = new AG_ROOT_Cont(new IBAN("RO22BACX6548206443372891"), new Client(new PlainText("Ion"), new PlainText("timisoara")), new Suma(100));
            //clientul 2 are 500 de lei in cont
            var cont2 = new AG_ROOT_Cont(new IBAN("RO22BACX6548206443372892"), new Client(new PlainText("Vasile"), new PlainText("timisoara")), new Suma(500));

            //din contul 2 transferam 50 lei in contul 1
            List<AG_ROOT_Cont> conturi = (new AG_ROOT_Cont()).TransferBaniIntreDouaConturi(new Suma(50.0), cont2, cont1);

            //verifica destinatarul
            Assert.Equal(TipTranzactie.Transfer, conturi[1].IstoricTranzactii.getTranzactii[0].Tip);
            Assert.Equal(cont2.IBAN.getIBAN, conturi[1].IstoricTranzactii.getTranzactii[0].PartenerTranzactie.getIBAN);
            Assert.Equal(50, conturi[1].IstoricTranzactii.getTranzactii[0].Suma.getSuma);

            //verifica sursa
            Assert.Equal(TipTranzactie.Transfer, conturi[0].IstoricTranzactii.getTranzactii[0].Tip);
            Assert.Equal(cont1.IBAN.getIBAN, conturi[0].IstoricTranzactii.getTranzactii[0].PartenerTranzactie.getIBAN);
            Assert.Equal(50, conturi[0].IstoricTranzactii.getTranzactii[0].Suma.getSuma);
        }

        [Fact]
        public void NuPermiteTranzactiiPesteSoldulCurent()
        {
            //clientul 1 are 100 de lei in cont
            var cont1 = new AG_ROOT_Cont(new IBAN("RO22BACX6548206443372891"), new Client(new PlainText("Ion"), new PlainText("timisoara")), new Suma(100));
            //clientul 2 are 30 de lei in cont
            var cont2 = new AG_ROOT_Cont(new IBAN("RO22BACX6548206443372892"), new Client(new PlainText("Vasile"), new PlainText("timisoara")), new Suma(30));

            List<AG_ROOT_Cont> conturi;
            //din contul 2 vrem sa transferam 50 lei in contul 1
            var ex = Assert.Throws<InsufficientFundsException>(() => conturi = (new AG_ROOT_Cont()).TransferBaniIntreDouaConturi(new Suma(50.0), cont2, cont1));
        }
    }
}
