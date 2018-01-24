using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Gradina
{
    public class ToatePlantele
    {
        public void AfiseazaToatePlantele(int i) {
            var repo = new Repositories.Gradina.GradinaRepository();
            var gradina = repo.CautaGradina(i);
            Console.WriteLine("Lista de plante din gradina: ");
            repo.AfiseazaFlori(gradina);
            repo.AfiseazaLegume(gradina);
            repo.AfiseazaPomi(gradina);
            Console.WriteLine();
            
        }
    }
}
