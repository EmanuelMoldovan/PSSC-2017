using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Repository.Depozit;
using Modele.Depozit;
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
            var depozit = DepozitFactory.Instance.CreazaDepozit(1);
            var depozit1 = DepozitFactory.Instance.CreazaDepozit(1);
            var depozit2 = DepozitFactory.Instance.CreazaDepozit(0);
            var repository = new DepozitRepositorys();
            repository.AdaugaDepozit(depozit);
            repository.AdaugaDepozit(depozit1);
            repository.AdaugaDepozit(depozit2);
            depozit.AdaugaTricou("Polo",'M', 12);
        }
    }
}
