using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ripository.Pachet
{
    public class PachetRepositories :IPachetRipositories
    {
        private static List<Modele.Pachete.Pachet> _pachet = new List<Modele.Pachete.Pachet>();
        private int pachete_introduse = 0;
        private int pret_total = 0;
        private int greutate_totala = 0;
        public void AdaugaPachet(Modele.Pachete.Pachet pachet)
        {
            var result = _pachet.FirstOrDefault(p => p.Equals(pachet));

            if (result != null) throw new DuplicateWaitObjectException();

            _pachet.Add(pachet);
            Console.WriteLine("Un nou pachet a fost adaugat.");
        }

        public void ActualizeazaPachet(Modele.Pachete.Pachet pachet)
        {
            //persit changes to the database
            Console.WriteLine("Modificarile au fost salvate.");
        }

        public Modele.Pachete.Pachet GasestePachetDupaNume(string nume)
        {
            return _pachet.FirstOrDefault(p => p.numePachet == nume);
        }

        public void Afiseaza_Detalii_Ripository()
        {
           

            for(int i=0;i<_pachet.Count;i++)
            {
                pachete_introduse += 1;
                pret_total = pret_total + _pachet[i].pretPachet;
                greutate_totala = greutate_totala + _pachet[i].greutatePachet;
            }
            
            Console.WriteLine("Afisarea Detaliilor:");

            Console.Write("Numarul de pachete introduse: ");
            Console.WriteLine(pachete_introduse);
            Console.Write("Pretul total al pachetelor:");
            Console.WriteLine(pret_total);
            Console.Write("Greutatea totala al pachetelor: ");
            Console.WriteLine(greutate_totala);
           
            
        }
    }
}
