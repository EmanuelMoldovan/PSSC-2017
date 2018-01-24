using MagazinElectroniceRepositories.cs;
using Model.Generic;
using Model.MagazinElectronice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema2_PSSC
{
    class Program
    {
        static void Main(string[] args)
        {
            var altex = MagazinElectroniceFactory.instance.Creeaza("Altex");
            var mediaGalaxy = MagazinElectroniceFactory.instance.Creeaza("MediaGalaxy", "Str Lalelelor", 30);
            var flanco = MagazinElectroniceFactory.instance.Creeaza("Flanco");
            var repository = new MagazinElectroniceRepo();
            repository.AdaugaMagazin(altex);
            repository.AdaugaMagazin(mediaGalaxy);
            repository.AdaugaMagazin(flanco);
            repository.AfisareListaMagazine();

            var laptop = new Laptop(new Procesor(4, "Intel", 2.7), new PlacaVideo("NVidia", 16, "GTX1080"), OS.Linux, 512, "Asus", 15.6, 3000);
            mediaGalaxy.AdaugaProdus(laptop);
            var laptopCautat = mediaGalaxy.AfisareProdusDupaNume(TipProdus.Laptop, "Asus");
            Console.WriteLine(((Laptop)laptopCautat).ToString());
            Console.ReadLine();
        }
    }
}
