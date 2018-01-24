using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Repository.Magazin;
using Modele.Magazin;
using Modele.Generic;

namespace DDD
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            var depozit = MagazinFactory.Instance.CreeazaMagazin(1);
            var depozit1 = MagazinFactory.Instance.CreeazaMagazin(1);
            var depozit2 = MagazinFactory.Instance.CreeazaMagazin(0);
            var repository = new MagazinRepositorys();
            repository.AdaUgaMagazin(depozit);
            repository.AdaUgaMagazin(depozit1);
            repository.AdaUgaMagazin(depozit2);
            depozit.AdaugaPlacaVideo("NVIDIA",256, 8);
        }
    }
}
