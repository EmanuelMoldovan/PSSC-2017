using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PSSC_DDDModel.Modele.Farmacie;
using PSSC_DDDModel.Repositories;
namespace PSSC_DDDModel
{
    class Program
    {
        static void Main(string[] args)
        {
            var farmacie = FarmacieFactory.Instance.CreateFarmacia("Catena");
            var repository = new FarmacieRepository();

            repository.AdaugaFarmacie(farmacie);

            farmacie.AdaugareMedicament("Nurofen", "123");
            Console.WriteLine("S-au gasit "+farmacie.CautaStocMedicamente("Nurofen")+" inregistrari cu numele dat");


            Farmacia f = repository.GasesteFarmaciaDupaNume("Catena");
            Console.WriteLine(f.nume.Text);

            Console.WriteLine(farmacie.StocMedicamente());

            Console.WriteLine("Press any key to terminate.");
            Console.ReadLine();
        }
    }
}
