using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Gradina;
namespace Repositories.Gradina
{
    public class GradinaRepository
    {
        private static List<Models.Gradina.Gradina> gradini = new List<Models.Gradina.Gradina>();

        public GradinaRepository()
        {
        }
        public void AdaugaGradina(Models.Gradina.Gradina gradina)
        {
            try
            {
                var result = gradini.FirstOrDefault(d => d.Equals(gradina));
                if (result != null) throw new LocationAlreadyTakenException("Gradina exista deja la locatia" + gradina.nrLocatie);
                gradini.Add(gradina);
                Console.WriteLine("O noua gradina a fost plantata la locatia " + gradina.nrLocatie);
            }
            catch(LocationAlreadyTakenException e)
            {
                Console.WriteLine(e.Message);
            }
         
        }

        public void StergeGradina(Models.Gradina.Gradina gradina)
        {
            Console.WriteLine("Gradina a fost deplantata.");
        }

        public Models.Gradina.Gradina CautaGradina(int nrLocatie)
        {
            return gradini.FirstOrDefault(d => d.nrLocatie == nrLocatie);
        }

        public void CautaLocuriOcupate()
        {
            Console.Write("Locuri ocupate: ");
            foreach (Models.Gradina.Gradina gradina in gradini)
            {
                Console.Write(gradina.nrLocatie + " ");
            }
            Console.WriteLine();      
        }

        public void AfiseazaPomi(Models.Gradina.Gradina gradina)
        {
            Console.WriteLine(gradina.Pomi.ToString());
        }

        public void AfiseazaLegume(Models.Gradina.Gradina gradina)
        {
            Console.WriteLine(gradina.Legume.ToString());
        }

        public void AfiseazaFlori(Models.Gradina.Gradina gradina)
        {
            Console.WriteLine(gradina.Flori.ToString());
        }
    }
}
