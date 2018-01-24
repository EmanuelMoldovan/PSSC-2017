using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ripository.Pachet;
using Modele.Pachete;
using Modele.Generic;


namespace DDD_Project
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            var pachet1 = PachetFactory.Instance.CreazaPachet("Pachetul1", 1500, tip_Pachet.cos);
            var pachet2 = PachetFactory.Instance.CreazaPachet("Pachetul2", 1000, tip_Pachet.cutie);
            var pachet3 = PachetFactory.Instance.CreazaPachet("Pachetul3", 1200, tip_Pachet.cos);

            pachet1.AdaugaFructeUscate(tip_FructeUscate.smochine, 2, 50, 100);
            pachet1.AdaugaNuci(tip_Nuci.migdale, 2, 100, 200);
            pachet1.AdaugaSeminte(tip_Seminte.chia, 1, 100, 20);

            pachet2.AdaugaFructeUscate(tip_FructeUscate.stafide, 2, 100, 200);
            pachet2.AdaugaNuci(tip_Nuci.caju, 2, 100, 70);
            pachet2.AdaugaSeminte(tip_Seminte.dovleac, 1, 100, 90);

            pachet3.AdaugaFructeUscate(tip_FructeUscate.merisoare, 2, 70, 80);
            pachet3.AdaugaNuci(tip_Nuci.fistic, 2, 100, 150);
            pachet3.AdaugaSeminte(tip_Seminte.chia, 2, 100, 20);

            var repository1 = new PachetRepositories();
            repository1.AdaugaPachet(pachet1);
            repository1.AdaugaPachet(pachet2);
            repository1.AdaugaPachet(pachet3);
            repository1.ActualizeazaPachet(pachet1);
            repository1.ActualizeazaPachet(pachet2);
            repository1.ActualizeazaPachet(pachet3);

            repository1.Afiseaza_Detalii_Ripository();
            repository1.GasestePachetDupaNume(pachet1.numePachet);


            Console.WriteLine("Press any key to terminate.");
            Console.ReadLine();


        }
    }
}
