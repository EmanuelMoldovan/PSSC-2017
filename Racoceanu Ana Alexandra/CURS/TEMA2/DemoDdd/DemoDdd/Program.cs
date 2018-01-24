using Modele.Etaj;
using Modele.Generic;
using Repositories.Etaj;
using Servicii.Disciplina;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoDdd
{
    public class Program
    {
        static void Main(string[] args)
        {
            var etaj = EtajFactory.Instance.CreeazaEtaj("04");
            var repository = new EtajRepository();
            repository.AdaugaEtaj(etaj);
            
            etaj.RezervareOaspeti(EtajFactory.Instance.CreeazaOaspete(12345678901, "Andrei"));
            
            etaj.IncepeSezonul();

            etaj.inchidereSezon();

            var publish = new PublicareRaportPlata("Hilton", "311");
            publish.PublicareNotePeWebSite("PSSC");

            repository.ActualizeazaEtaj(etaj);

            Console.WriteLine("Press any key to terminate.");
            Console.ReadLine();
        }
    }
}
