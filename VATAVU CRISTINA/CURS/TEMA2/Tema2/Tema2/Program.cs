using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modele.Cont;
using Modele.Generic;
using Repositories.Conturi;
using Servicii.Conturi;

namespace Tema2
{
    class Program
    {
        static void Main(string[] args)
        {
	        ConturiRepository repo = new ConturiRepository();
            GraficSoldService grafic = new GraficSoldService();
            RaportTranzactiiService raport = new RaportTranzactiiService();
            Client client1 = ConturiFactory.Instance.CreazaClient(new PlainText("Ion"), new PlainText("Timisoara"));
            Client client2 = ConturiFactory.Instance.CreazaClient(new PlainText("Vasile"), new PlainText("Arad"));
            Cont cont1 = ConturiFactory.Instance.CreazaCont(new IBAN("RO12RBND1234567890123456"), client1);
            Cont cont2 = ConturiFactory.Instance.CreazaCont(new IBAN("RO12RBND1234567890123455"), client2);
            repo.AdaugaCont(cont1);
            repo.AdaugaCont(cont2);

            cont1.DepuneBani(new Suma(99.0)); //depune 99 ca sa aiba de unde sa trasnfere
            repo.updateConturi = cont1.TransferBani(new Suma(10.0), cont2.IBAN, repo.getConturi);
            repo.updateConturi = cont1.PlatesteFactura(new Suma(20.0), cont2.IBAN, repo.getConturi);

            grafic.GraficSoldInTimp(cont1);
            raport.RapoarteTranzactii(cont1);
            raport.RapoarteTranzactii(cont2);
            Console.ReadLine();
        }
    }
}
