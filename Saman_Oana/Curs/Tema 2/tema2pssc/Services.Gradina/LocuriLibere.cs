using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Gradina
{
    class LocuriLibere
    {
        public void AfisareLocuriLibere()
        {
            var repo = new Repositories.Gradina.GradinaRepository();
            Console.Write("Locurile libere sunt: ");
            for (int i = 0; i < 10; i++)
            {
                if (repo.CautaGradina(i) == null)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
