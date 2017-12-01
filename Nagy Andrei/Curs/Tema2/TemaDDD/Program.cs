using Model.Client;
using Model.Generic;
using Model.ParcAuto;
using Repository.ParcAuto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TemaDDD
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var repository = new ParcAutoRepository();
           // PlainText localitate = new PlainText("Timisoara");
            var parcAuto = ParcAutoFactory.Instance.CreeazaParcAuto("Autoklass", "Timisoara", "Timis", "Soarelui", 102);
            repository.AdaugaParcAuto(parcAuto);

            var masina1 = ParcAutoFactory.Instance.CreeazaMasina(Model.ParcAuto.TipMasina.Break, "WV Golf", "2003", "230k", "nu bate nu trocane");
            var masina2 = ParcAutoFactory.Instance.CreeazaMasina(Model.ParcAuto.TipMasina.Berlina, "BMW seria3", "2000", "275k", "urme usoare de uzura");
            var masina3 = ParcAutoFactory.Instance.CreeazaMasina(Model.ParcAuto.TipMasina.Break, "WV Bora", "2003", "175k", "stare perfecta");

            repository.AdaugaMasina(masina1);
            repository.AdaugaMasina(masina2);
            repository.AdaugaMasina(masina3);

            var dealer = ParcAutoFactory.Instance.CreeazaDealer("Popescu", "Emil", "19203022993");

            var client = ClientFactory.Instance.CreeazaClient("Nagy", "Andrei", "19503180222222");
            parcAuto.DeschideParc();

            var masinaCautata = repository.CautaMasina("BMW seria3");
            if (masinaCautata.ToString() != null && parcAuto.Stare==StareParcAuto.Deschis)
                Console.WriteLine("Masina a fost gasita!");

            client.ClientMultumit();

            if (client.Stare != Model.Client.StareClient.Multumit)
            {
                //client nemultumit -> cauta alta masina
            }
            else
            {
                var contract = ClientFactory.Instance.CreeazaContractCumparare(dealer,masinaCautata,client);
                var administratiaFinanciara = new AdministratiaFinanciara(contract);
                administratiaFinanciara.MasinaCumparata();
            }

            Console.ReadKey();
            parcAuto.InchideParc();
        }
    }
}